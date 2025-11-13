using EncuestasInterfer.Models;
using Microsoft.EntityFrameworkCore;

namespace EncuestasInterfer.Services.RespuestaMultipleServices
{
    public class SRespuestaMultipleServices : IRespuestaMultipleServices
    {
        private readonly EncuestaFeriaContext _encuestaDBContext;

        public SRespuestaMultipleServices(EncuestaFeriaContext encuestaDBContext)
        {
            _encuestaDBContext = encuestaDBContext;
        }

        public async Task<bool> AddAsync(RespuestaMultiple respuestaMultiple)
        {
            try
            {
                await _encuestaDBContext.RespuestaMultiple.AddAsync(respuestaMultiple);
                await _encuestaDBContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> AddMultipleAsync(List<RespuestaMultiple> respuestasMultiples)
        {
            try
            {
                await _encuestaDBContext.RespuestaMultiple.AddRangeAsync(respuestasMultiples);
                await _encuestaDBContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<RespuestaMultiple>> GetByRespuestaDetalleAsync(int idRespuestaDetalle)
        {
            return await _encuestaDBContext.RespuestaMultiple
                .Include(rm => rm.IdOpcionNavigation)
                .Where(rm => rm.IdRespuestaDetalle == idRespuestaDetalle)
                .ToListAsync();
        }

        public async Task<bool> DeleteByRespuestaDetalleAsync(int idRespuestaDetalle)
        {
            var multiples = await _encuestaDBContext.RespuestaMultiple
                .Where(rm => rm.IdRespuestaDetalle == idRespuestaDetalle)
                .ToListAsync();

            if (multiples.Any())
            {
                _encuestaDBContext.RespuestaMultiple.RemoveRange(multiples);
                await _encuestaDBContext.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}