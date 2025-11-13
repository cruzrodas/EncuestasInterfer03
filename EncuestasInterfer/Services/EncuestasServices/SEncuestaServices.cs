using EncuestasInterfer.Models;
using EncuestasInterfer.Services.EncuestasServices;
using Microsoft.EntityFrameworkCore;

namespace EncuestasInterfer.Services.EncuestaServices
{
    public class SEncuestaServices : IEncuestaServices
    {
        private readonly EncuestaFeriaContext _encuestaDBContext;

        public SEncuestaServices(EncuestaFeriaContext encuestaDBContext)
        {
            _encuestaDBContext = encuestaDBContext;
        }

        public async Task<bool> AddUpdateAsync(Encuesta encuesta)
        {
            if (encuesta.IdEncuesta > 0)
            {
                // Actualizar encuesta existente
                var existingEncuesta = await _encuestaDBContext.Encuesta.FindAsync(encuesta.IdEncuesta);

                if (existingEncuesta != null)
                {
                    existingEncuesta.Titulo = encuesta.Titulo;
                    existingEncuesta.Descripcion = encuesta.Descripcion;
                    existingEncuesta.FechaInicio = encuesta.FechaInicio;
                    existingEncuesta.FechaFin = encuesta.FechaFin;
                    existingEncuesta.Activa = encuesta.Activa;
                    existingEncuesta.FechaActualiacion = DateTime.Now;

                    _encuestaDBContext.Encuesta.Update(existingEncuesta);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                // Crear nueva encuesta
                encuesta.FechaCreacion = DateTime.Now;
                encuesta.Activa = true;
                _encuestaDBContext.Encuesta.Add(encuesta);
            }

            await _encuestaDBContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var encuesta = await _encuestaDBContext.Encuesta.FindAsync(id);
            if (encuesta != null)
            {
                encuesta.Activa = false;
                encuesta.FechaActualiacion = DateTime.Now;
                _encuestaDBContext.Encuesta.Update(encuesta);
                await _encuestaDBContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<Encuesta>> GetAllAsync()
        {
            return await _encuestaDBContext.Encuesta
                .Where(e => e.Activa == true)
                .OrderByDescending(e => e.FechaCreacion)
                .ToListAsync();
        }

        public async Task<Encuesta> GetByIdAsync(int id)
        {
            try
            {
                var result = await _encuestaDBContext.Encuesta
                    .FirstOrDefaultAsync(e => e.IdEncuesta == id);

                if (result == null)
                {
                    throw new KeyNotFoundException($"No se encontró la encuesta con ID {id}");
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar la encuesta", ex);
            }
        }

        public async Task<Encuesta> GetByIdWithPreguntasAsync(int id)
        {
            try
            {
                var result = await _encuestaDBContext.Encuesta
                    .Include(e => e.Pregunta)
                        .ThenInclude(p => p.IdTipoPreguntaNavigation)
                    .Include(e => e.Pregunta)
                        .ThenInclude(p => p.OpcionRespuesta)
                    .FirstOrDefaultAsync(e => e.IdEncuesta == id);

                if (result == null)
                {
                    throw new KeyNotFoundException($"No se encontró la encuesta con ID {id}");
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar la encuesta con preguntas", ex);
            }
        }

        public async Task<List<Encuesta>> GetEncuestasActivasAsync()
        {
            return await _encuestaDBContext.Encuesta
                .Where(e => e.Activa == true &&
                           e.FechaInicio <= DateTime.Now &&
                           e.FechaFin >= DateTime.Now)
                .OrderByDescending(e => e.FechaCreacion)
                .ToListAsync();
        }

        public async Task<MPaginatedResult<Encuesta>> GetPaginatedAsync(int pageNumber, int pageSize, string searchTerm = "", bool sortAscending = true)
        {
            IQueryable<Encuesta> query = _encuestaDBContext.Encuesta
                .Where(e => e.Activa == true);

            // Filtro por el término de búsqueda
            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(e =>
                    (e.Titulo != null && e.Titulo.Contains(searchTerm)) ||
                    (e.Descripcion != null && e.Descripcion.Contains(searchTerm))
                );
            }

            // Ordenamiento
            query = sortAscending
                ? query.OrderBy(e => e.IdEncuesta).ThenBy(e => e.Titulo)
                : query.OrderByDescending(e => e.IdEncuesta).ThenByDescending(e => e.Titulo);

            var totalItems = await query.CountAsync();

            // Aplicar paginación
            var items = await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return new MPaginatedResult<Encuesta>
            {
                Items = items,
                TotalCount = totalItems,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
        }

        public async Task<bool> ActivarDesactivarAsync(int id, bool activo)
        {
            var encuesta = await _encuestaDBContext.Encuesta.FindAsync(id);
            if (encuesta != null)
            {
                encuesta.Activa = activo;
                encuesta.FechaActualiacion = DateTime.Now;
                _encuestaDBContext.Encuesta.Update(encuesta);
                await _encuestaDBContext.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}