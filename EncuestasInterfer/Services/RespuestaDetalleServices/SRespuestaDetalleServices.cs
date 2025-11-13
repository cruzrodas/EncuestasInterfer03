using EncuestasInterfer.Models;
using Microsoft.EntityFrameworkCore;

namespace EncuestasInterfer.Services.RespuestaDetalleServices
{
    public class SRespuestaDetalleServices : IRespuestaDetalleServices
    {
        private readonly EncuestaFeriaContext _encuestaDBContext;

        public SRespuestaDetalleServices(EncuestaFeriaContext encuestaDBContext)
        {
            _encuestaDBContext = encuestaDBContext;
        }

        public async Task<int> AddAsync(RespuestaDetalle respuestaDetalle)
        {
            respuestaDetalle.FechaRespuesta = DateTime.Now;
            await _encuestaDBContext.RespuestaDetalle.AddAsync(respuestaDetalle);
            await _encuestaDBContext.SaveChangesAsync();
            return respuestaDetalle.IdRespuestaDetalle;
        }

        public async Task<bool> AddMultipleAsync(List<RespuestaDetalle> respuestasDetalle)
        {
            try
            {
                foreach (var detalle in respuestasDetalle)
                {
                    detalle.FechaRespuesta = DateTime.Now;
                }

                await _encuestaDBContext.RespuestaDetalle.AddRangeAsync(respuestasDetalle);
                await _encuestaDBContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<RespuestaDetalle>> GetByRespuestaEncuestaAsync(int idRespuestaEncuesta)
        {
            return await _encuestaDBContext.RespuestaDetalle
                .Include(rd => rd.IdPreguntaNavigation)
                .Include(rd => rd.IdOpcionNavigation)
                .Include(rd => rd.RespuestaMultiple)
                    .ThenInclude(rm => rm.IdOpcionNavigation)
                .Where(rd => rd.IdRespuestaEncuesta == idRespuestaEncuesta)
                .OrderBy(rd => rd.IdPregunta)
                .ToListAsync();
        }

        public async Task<bool> DeleteByRespuestaEncuestaAsync(int idRespuestaEncuesta)
        {
            var detalles = await _encuestaDBContext.RespuestaDetalle
                .Where(rd => rd.IdRespuestaEncuesta == idRespuestaEncuesta)
                .ToListAsync();

            if (detalles.Any())
            {
                _encuestaDBContext.RespuestaDetalle.RemoveRange(detalles);
                await _encuestaDBContext.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}