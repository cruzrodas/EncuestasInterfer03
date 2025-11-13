using EncuestasInterfer.Models;

namespace EncuestasInterfer.Services.RespuestaEncuestaService
{
    public interface IRespuestaEncuestaService
    {
        Task<List<RespuestaEncuesta>> GetAllAsync();
        Task<RespuestaEncuesta> GetByIdWithDetailsAsync(int id);
        Task<MPaginatedResult<RespuestaEncuesta>> GetPaginatedAsync(int pageNumber, int pageSize, string searchTerm = "", int? idEncuesta = null);
        Task<List<RespuestaDetalle>> GetDetallesByRespuestaIdAsync(int idRespuestaEncuesta);
    }
}