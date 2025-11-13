using EncuestasInterfer.Models;

namespace EncuestasInterfer.Services.RespuestaDetalleServices
{
    public interface IRespuestaDetalleServices
    {
        Task<int> AddAsync(RespuestaDetalle respuestaDetalle);
        Task<bool> AddMultipleAsync(List<RespuestaDetalle> respuestasDetalle);
        Task<List<RespuestaDetalle>> GetByRespuestaEncuestaAsync(int idRespuestaEncuesta);
        Task<bool> DeleteByRespuestaEncuestaAsync(int idRespuestaEncuesta);
    }
}
