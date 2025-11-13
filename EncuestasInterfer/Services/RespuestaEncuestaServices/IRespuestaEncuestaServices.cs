using EncuestasInterfer.Models;

namespace EncuestasInterfer.Services.RespuestaEncuestaServices
{
    public interface IRespuestaEncuestaServices
    {
        Task<List<RespuestaEncuesta>> GetAllAsync();
        Task<RespuestaEncuesta> GetByIdAsync(int id);
        Task<RespuestaEncuesta> GetByIdWithDetallesAsync(int id);
        Task<List<RespuestaEncuesta>> GetByEncuestaAsync(int idEncuesta);
        Task<int> AddAsync(RespuestaEncuesta respuestaEncuesta);
        Task<bool> UpdateAsync(RespuestaEncuesta respuestaEncuesta);
        Task<bool> DeleteAsync(int id);
        Task<int> GetCountByEncuestaAsync(int idEncuesta);

    }
}
