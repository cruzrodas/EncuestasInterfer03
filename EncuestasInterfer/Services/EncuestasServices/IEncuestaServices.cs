using EncuestasInterfer.Models;

namespace EncuestasInterfer.Services.EncuestasServices
{
    public interface IEncuestaServices
    {
        Task<List<Encuesta>> GetAllAsync();
        Task<Encuesta> GetByIdAsync(int id);
        Task<Encuesta> GetByIdWithPreguntasAsync(int id);
        Task<MPaginatedResult<Encuesta>> GetPaginatedAsync(int pageNumber, int pageSize, string searchTerm = "", bool sortAscending = true);
        Task<bool> AddUpdateAsync(Encuesta encuesta);
        Task<bool> DeleteAsync(int id);
        Task<List<Encuesta>> GetEncuestasActivasAsync();
        Task<bool> ActivarDesactivarAsync(int id, bool activo);
    }
}
