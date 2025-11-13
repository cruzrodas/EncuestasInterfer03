using EncuestasInterfer.Models;

namespace EncuestasInterfer.Services.TipoPreguntaServices
{
    public interface ITipoPreguntaServices
    {
        Task<List<TipoPregunta>> GetAllAsync();
        Task<TipoPregunta> GetByIdAsync(int id);
        Task<List<TipoPregunta>> GetActivosAsync();

    }
}
