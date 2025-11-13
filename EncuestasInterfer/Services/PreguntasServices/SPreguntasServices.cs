using EncuestasInterfer.Models;
using Microsoft.EntityFrameworkCore;

namespace EncuestasInterfer.Services.PreguntasServices
{
    public class SPreguntaServices : IPreguntasServices
    {
        private readonly EncuestaFeriaContext _encuestaDBContext;

        public SPreguntaServices(EncuestaFeriaContext encuestaDBContext)
        {
            _encuestaDBContext = encuestaDBContext;
        }

        public async Task<bool> AddUpdateAsync(Pregunta pregunta)
        {
            if (pregunta.IdPregunta > 0)
            {
                // *** ACTUALIZAR pregunta existente ***
                var existingPregunta = await _encuestaDBContext.Pregunta.FindAsync(pregunta.IdPregunta);

                if (existingPregunta != null)
                {
                    existingPregunta.IdEncuesta = pregunta.IdEncuesta;
                    existingPregunta.IdTipoPregunta = pregunta.IdTipoPregunta;
                    existingPregunta.TextoPregunta = pregunta.TextoPregunta;
                    existingPregunta.Activa = pregunta.Activa;
                    // NO actualizar OrdenPregunta aquí - solo en UpdateAsync

                    _encuestaDBContext.Pregunta.Update(existingPregunta);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                // *** CREAR NUEVA pregunta con ORDEN AUTOMÁTICO ***
                pregunta.FechaCreacion = DateTime.Now;
                pregunta.Activa = true;

                if (pregunta.IdEncuesta.HasValue)
                {
                    // Obtener el último orden de preguntas de esta encuesta
                    var ultimoOrden = await _encuestaDBContext.Pregunta
                        .Where(p => p.IdEncuesta == pregunta.IdEncuesta && p.Activa == true)
                        .MaxAsync(p => (int?)p.OrdenPregunta) ?? 0;

                    // Asignar el siguiente orden
                    pregunta.OrdenPregunta = ultimoOrden + 1;
                }
                else
                {
                    pregunta.OrdenPregunta = 1;
                }

                _encuestaDBContext.Pregunta.Add(pregunta);
            }

            await _encuestaDBContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var pregunta = await _encuestaDBContext.Pregunta.FindAsync(id);
            if (pregunta != null)
            {
                // Guardar información antes de eliminar
                var idEncuesta = pregunta.IdEncuesta;
                var ordenEliminado = pregunta.OrdenPregunta;

                // Marcar como inactiva
                pregunta.Activa = false;
                _encuestaDBContext.Pregunta.Update(pregunta);
                await _encuestaDBContext.SaveChangesAsync();

                // *** REORDENAR preguntas restantes ***
                if (idEncuesta.HasValue && ordenEliminado.HasValue && ordenEliminado > 0)
                {
                    await ReordenarPreguntasAsync(idEncuesta.Value);
                }

                return true;
            }
            return false;
        }

        public async Task<List<Pregunta>> GetAllAsync()
        {
            return await _encuestaDBContext.Pregunta
                .Include(p => p.IdEncuestaNavigation)
                .Include(p => p.IdTipoPreguntaNavigation)
                .Where(p => p.Activa == true)
                .OrderBy(p => p.IdEncuesta)
                .ThenBy(p => p.OrdenPregunta ?? int.MaxValue)
                .ThenBy(p => p.IdPregunta)
                .ToListAsync();
        }

        public async Task<Pregunta> GetByIdAsync(int id)
        {
            try
            {
                var result = await _encuestaDBContext.Pregunta
                    .Include(p => p.IdEncuestaNavigation)
                    .Include(p => p.IdTipoPreguntaNavigation)
                    .FirstOrDefaultAsync(p => p.IdPregunta == id);

                if (result == null)
                {
                    throw new KeyNotFoundException($"No se encontró la pregunta con ID {id}");
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar la pregunta", ex);
            }
        }

        public async Task<Pregunta> GetByIdWithOpcionesAsync(int id)
        {
            try
            {
                var result = await _encuestaDBContext.Pregunta
                    .Include(p => p.IdEncuestaNavigation)
                    .Include(p => p.IdTipoPreguntaNavigation)
                    .Include(p => p.OpcionRespuesta.Where(o => o.Activa == true))
                    .FirstOrDefaultAsync(p => p.IdPregunta == id);

                if (result == null)
                {
                    throw new KeyNotFoundException($"No se encontró la pregunta con ID {id}");
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar la pregunta con opciones", ex);
            }
        }

        public async Task<Pregunta> GetByIdWithOptionsAsync(int id)
        {
            var result = await _encuestaDBContext.Pregunta
                .Include(p => p.IdTipoPreguntaNavigation)
                .Include(p => p.OpcionRespuesta.Where(o => o.Activa == true))
                .Include(p => p.IdEncuestaNavigation)
                .FirstOrDefaultAsync(p => p.IdPregunta == id);

            if (result == null)
                throw new KeyNotFoundException($"No se encontró la pregunta con ID {id}");

            return result;
        }

        public async Task<List<Pregunta>> GetByEncuestaAsync(int idEncuesta)
        {
            return await _encuestaDBContext.Pregunta
                .Include(p => p.IdTipoPreguntaNavigation)
                .Include(p => p.OpcionRespuesta.Where(o => o.Activa == true))
                .Where(p => p.IdEncuesta == idEncuesta && p.Activa == true)
                .OrderBy(p => p.OrdenPregunta ?? int.MaxValue)
                .ThenBy(p => p.IdPregunta)
                .ToListAsync();
        }

        public async Task<MPaginatedResult<Pregunta>> GetPaginatedAsync(
            int pageNumber,
            int pageSize,
            string searchTerm = "",
            int? idEncuesta = null)
        {
            IQueryable<Pregunta> query = _encuestaDBContext.Pregunta
                .Include(p => p.IdEncuestaNavigation)
                .Include(p => p.IdTipoPreguntaNavigation)
                .Where(p => p.Activa == true);

            // Filtro por encuesta
            if (idEncuesta.HasValue)
            {
                query = query.Where(p => p.IdEncuesta == idEncuesta.Value);
            }

            // Filtro por término de búsqueda
            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(p =>
                    (p.TextoPregunta != null && p.TextoPregunta.Contains(searchTerm))
                );
            }

            // Ordenamiento con soporte para nullable
            query = query
                .OrderBy(p => p.IdEncuesta)
                .ThenBy(p => p.OrdenPregunta ?? int.MaxValue)
                .ThenBy(p => p.IdPregunta);

            var totalItems = await query.CountAsync();

            // Aplicar paginación
            var items = await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return new MPaginatedResult<Pregunta>
            {
                Items = items,
                TotalCount = totalItems,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
        }

        public async Task<bool> ActivarDesactivarAsync(int id, bool activo)
        {
            var pregunta = await _encuestaDBContext.Pregunta.FindAsync(id);
            if (pregunta != null)
            {
                pregunta.Activa = activo;
                _encuestaDBContext.Pregunta.Update(pregunta);
                await _encuestaDBContext.SaveChangesAsync();

                // Si se desactiva, reordenar
                if (!activo && pregunta.IdEncuesta.HasValue)
                {
                    await ReordenarPreguntasAsync(pregunta.IdEncuesta.Value);
                }

                return true;
            }
            return false;
        }

        public async Task<int> GetCountByEncuestaAsync(int idEncuesta)
        {
            return await _encuestaDBContext.Pregunta
                .Where(p => p.IdEncuesta == idEncuesta && p.Activa == true)
                .CountAsync();
        }

        public async Task<bool> UpdateAsync(Pregunta pregunta)
        {
            var existing = await _encuestaDBContext.Pregunta.FindAsync(pregunta.IdPregunta);
            if (existing != null)
            {
                existing.TextoPregunta = pregunta.TextoPregunta;
                existing.IdTipoPregunta = pregunta.IdTipoPregunta;
                existing.OrdenPregunta = pregunta.OrdenPregunta;
                existing.EsCondicional = pregunta.EsCondicional;
                existing.PreguntaDestinoSalto = pregunta.PreguntaDestinoSalto;
                existing.Activa = pregunta.Activa;

                _encuestaDBContext.Pregunta.Update(existing);
                await _encuestaDBContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        // *** MÉTODO PRIVADO PARA REORDENAR PREGUNTAS ***
        private async Task ReordenarPreguntasAsync(int idEncuesta)
        {
            var preguntas = await _encuestaDBContext.Pregunta
                .Where(p => p.IdEncuesta == idEncuesta && p.Activa == true)
                .OrderBy(p => p.OrdenPregunta ?? int.MaxValue)
                .ThenBy(p => p.IdPregunta)
                .ToListAsync();

            int nuevoOrden = 1;
            foreach (var pregunta in preguntas)
            {
                pregunta.OrdenPregunta = nuevoOrden;
                nuevoOrden++;
            }

            await _encuestaDBContext.SaveChangesAsync();
        }

        // *** MÉTODO PARA CAMBIAR ORDEN MANUALMENTE ***
        public async Task<bool> CambiarOrdenAsync(int idPregunta, int nuevoOrden)
        {
            var pregunta = await _encuestaDBContext.Pregunta.FindAsync(idPregunta);
            if (pregunta == null || !pregunta.IdEncuesta.HasValue)
                return false;

            var ordenActual = pregunta.OrdenPregunta ?? 0;
            var idEncuesta = pregunta.IdEncuesta.Value;

            // Obtener todas las preguntas de la encuesta
            var preguntas = await _encuestaDBContext.Pregunta
                .Where(p => p.IdEncuesta == idEncuesta && p.Activa == true)
                .OrderBy(p => p.OrdenPregunta ?? int.MaxValue)
                .ThenBy(p => p.IdPregunta)
                .ToListAsync();

            // Validar que el nuevo orden sea válido
            if (nuevoOrden < 1 || nuevoOrden > preguntas.Count)
                return false;

            // Reordenar
            if (ordenActual > 0)
            {
                if (nuevoOrden < ordenActual)
                {
                    // Mover hacia arriba
                    foreach (var p in preguntas.Where(p =>
                        p.OrdenPregunta.HasValue &&
                        p.OrdenPregunta >= nuevoOrden &&
                        p.OrdenPregunta < ordenActual))
                    {
                        p.OrdenPregunta++;
                    }
                }
                else if (nuevoOrden > ordenActual)
                {
                    // Mover hacia abajo
                    foreach (var p in preguntas.Where(p =>
                        p.OrdenPregunta.HasValue &&
                        p.OrdenPregunta > ordenActual &&
                        p.OrdenPregunta <= nuevoOrden))
                    {
                        p.OrdenPregunta--;
                    }
                }
            }

            pregunta.OrdenPregunta = nuevoOrden;
            await _encuestaDBContext.SaveChangesAsync();
            return true;
        }
    }
}