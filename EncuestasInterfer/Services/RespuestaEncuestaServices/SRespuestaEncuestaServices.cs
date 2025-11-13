using EncuestasInterfer.Models;
using Microsoft.EntityFrameworkCore;

namespace EncuestasInterfer.Services.RespuestaEncuestaServices
{
    public class SRespuestaEncuestaServices : IRespuestaEncuestaServices
    {
        private readonly EncuestaFeriaContext _encuestaDBContext;

        public SRespuestaEncuestaServices(EncuestaFeriaContext encuestaDBContext)
        {
            _encuestaDBContext = encuestaDBContext;
        }

        public async Task<int> AddAsync(RespuestaEncuesta respuestaEncuesta)
        {
            respuestaEncuesta.FechaRealizacion = DateTime.Now;
            await _encuestaDBContext.RespuestaEncuesta.AddAsync(respuestaEncuesta);
            await _encuestaDBContext.SaveChangesAsync();
            return respuestaEncuesta.IdRespuestaEncuesta;
        }

        public async Task<bool> UpdateAsync(RespuestaEncuesta respuestaEncuesta)
        {
            var existing = await _encuestaDBContext.RespuestaEncuesta.FindAsync(respuestaEncuesta.IdRespuestaEncuesta);
            if (existing != null)
            {
                existing.IdTipoDocuementoIdentificacion = respuestaEncuesta.IdTipoDocuementoIdentificacion;
                existing.NumeroIdentificacion = respuestaEncuesta.NumeroIdentificacion;
                existing.EdadActual = respuestaEncuesta.EdadActual;
                existing.IdGenero = respuestaEncuesta.IdGenero;
                existing.IdNacionalidad = respuestaEncuesta.IdNacionalidad;
                existing.IdDepartamento = respuestaEncuesta.IdDepartamento;
                existing.IdMunicipio = respuestaEncuesta.IdMunicipio;

                _encuestaDBContext.RespuestaEncuesta.Update(existing);
                await _encuestaDBContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var respuesta = await _encuestaDBContext.RespuestaEncuesta.FindAsync(id);
            if (respuesta != null)
            {
                _encuestaDBContext.RespuestaEncuesta.Remove(respuesta);
                await _encuestaDBContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<RespuestaEncuesta>> GetAllAsync()
        {
            return await _encuestaDBContext.RespuestaEncuesta
                .Include(r => r.IdEncuestaNavigation)
                .Include(r => r.IdGeneroNavigation)
                .Include(r => r.IdNacionalidadNavigation)
                .OrderByDescending(r => r.FechaRealizacion)
                .ToListAsync();
        }

        public async Task<RespuestaEncuesta> GetByIdAsync(int id)
        {
            var result = await _encuestaDBContext.RespuestaEncuesta
                .Include(r => r.IdEncuestaNavigation)
                .Include(r => r.IdGeneroNavigation)
                .Include(r => r.IdNacionalidadNavigation)
                .Include(r => r.IdDepartamentoNavigation)
                .Include(r => r.IdMunicipioNavigation)
                .FirstOrDefaultAsync(r => r.IdRespuestaEncuesta == id);

            if (result == null)
            {
                throw new KeyNotFoundException($"No se encontró la respuesta con ID {id}");
            }

            return result;
        }

        public async Task<RespuestaEncuesta> GetByIdWithDetallesAsync(int id)
        {
            var result = await _encuestaDBContext.RespuestaEncuesta
                .Include(r => r.IdEncuestaNavigation)
                .Include(r => r.RespuestaDetalle)
                    .ThenInclude(rd => rd.IdPreguntaNavigation)
                .Include(r => r.RespuestaDetalle)
                    .ThenInclude(rd => rd.IdOpcionNavigation)
                .Include(r => r.RespuestaDetalle)
                    .ThenInclude(rd => rd.RespuestaMultiple)
                        .ThenInclude(rm => rm.IdOpcionNavigation)
                .FirstOrDefaultAsync(r => r.IdRespuestaEncuesta == id);

            if (result == null)
            {
                throw new KeyNotFoundException($"No se encontró la respuesta con ID {id}");
            }

            return result;
        }

        public async Task<List<RespuestaEncuesta>> GetByEncuestaAsync(int idEncuesta)
        {
            return await _encuestaDBContext.RespuestaEncuesta
                .Include(r => r.IdGeneroNavigation)
                .Include(r => r.IdNacionalidadNavigation)
                .Where(r => r.IdEncuesta == idEncuesta)
                .OrderByDescending(r => r.FechaRealizacion)
                .ToListAsync();
        }

        public async Task<int> GetCountByEncuestaAsync(int idEncuesta)
        {
            return await _encuestaDBContext.RespuestaEncuesta
                .Where(r => r.IdEncuesta == idEncuesta)
                .CountAsync();
        }
    }
}