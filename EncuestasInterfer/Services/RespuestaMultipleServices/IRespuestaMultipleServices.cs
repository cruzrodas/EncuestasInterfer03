using EncuestasInterfer.Models;

namespace EncuestasInterfer.Services.RespuestaMultipleServices
{
    public interface IRespuestaMultipleServices
    {
        Task<bool> AddAsync(RespuestaMultiple respuestaMultiple);
        Task<bool> AddMultipleAsync(List<RespuestaMultiple> respuestasMultiples);
        Task<List<RespuestaMultiple>> GetByRespuestaDetalleAsync(int idRespuestaDetalle);
        Task<bool> DeleteByRespuestaDetalleAsync(int idRespuestaDetalle);

    }
}
