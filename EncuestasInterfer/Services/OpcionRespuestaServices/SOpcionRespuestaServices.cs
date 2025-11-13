using EncuestasInterfer.Models;
using Microsoft.EntityFrameworkCore;

namespace EncuestasInterfer.Services.OpcionRespuestaServices
{
    public class SOpcionRespuestaServices : IOpcionRespuestaServices
    {
        private readonly EncuestaFeriaContext _encuestaDBContext;

        public SOpcionRespuestaServices(EncuestaFeriaContext encuestaDBContext)
        {
            _encuestaDBContext = encuestaDBContext;
        }

        public async Task<bool> AddUpdateAsync(OpcionRespuesta opcionRespuesta)
        {
            if (opcionRespuesta.IdOpcionRespuesta > 0)
            {
                // Actualizar opción existente
                var existingOpcion = await _encuestaDBContext.OpcionRespuesta.FindAsync(opcionRespuesta.IdOpcionRespuesta);

                if (existingOpcion != null)
                {
                    existingOpcion.IdPregunta = opcionRespuesta.IdPregunta;
                    existingOpcion.TextoOpcion = opcionRespuesta.TextoOpcion;
                    existingOpcion.ValorNumerico = opcionRespuesta.ValorNumerico;
                    existingOpcion.Activa = opcionRespuesta.Activa;

                    _encuestaDBContext.OpcionRespuesta.Update(existingOpcion);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                // Crear nueva opción
                opcionRespuesta.Activa = true;
                _encuestaDBContext.OpcionRespuesta.Add(opcionRespuesta);
            }

            await _encuestaDBContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var opcion = await _encuestaDBContext.OpcionRespuesta.FindAsync(id);
            if (opcion != null)
            {
                opcion.Activa = false;
                _encuestaDBContext.OpcionRespuesta.Update(opcion);
                await _encuestaDBContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteByPreguntaAsync(int idPregunta)
        {
            var opciones = await _encuestaDBContext.OpcionRespuesta
                .Where(o => o.IdPregunta == idPregunta)
                .ToListAsync();

            foreach (var opcion in opciones)
            {
                opcion.Activa = false;
            }

            _encuestaDBContext.OpcionRespuesta.UpdateRange(opciones);
            await _encuestaDBContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<OpcionRespuesta>> GetAllAsync()
        {
            return await _encuestaDBContext.OpcionRespuesta
                .Include(o => o.IdPreguntaNavigation)
                .Where(o => o.Activa == true)
                .OrderBy(o => o.IdPregunta)
                .ThenBy(o => o.IdOpcionRespuesta)
                .ToListAsync();
        }

        public async Task<OpcionRespuesta> GetByIdAsync(int id)
        {
            try
            {
                var result = await _encuestaDBContext.OpcionRespuesta
                    .Include(o => o.IdPreguntaNavigation)
                    .FirstOrDefaultAsync(o => o.IdOpcionRespuesta == id);

                if (result == null)
                {
                    throw new KeyNotFoundException($"No se encontró la opción de respuesta con ID {id}");
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar la opción de respuesta", ex);
            }
        }

        public async Task<List<OpcionRespuesta>> GetByPreguntaAsync(int idPregunta)
        {
            return await _encuestaDBContext.OpcionRespuesta
                .Where(o => o.IdPregunta == idPregunta && o.Activa == true)
                .OrderBy(o => o.IdOpcionRespuesta)
                .ToListAsync();
        }

        public async Task<bool> AddMultipleAsync(List<OpcionRespuesta> opciones)
        {
            try
            {
                foreach (var opcion in opciones)
                {
                    opcion.Activa = true;
                }

                await _encuestaDBContext.OpcionRespuesta.AddRangeAsync(opciones);
                await _encuestaDBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}