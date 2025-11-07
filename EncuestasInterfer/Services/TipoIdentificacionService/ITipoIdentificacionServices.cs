using EncuestasInterfer.Models;

namespace EncuestasInterfer.Services.TipoIdentificacionService
{
    public interface ITipoIdentificacionServices
    {
        Task<List<TipoIdentificacion>> GetAllAsync();
        Task<TipoIdentificacion> GetByIdAsync(int id);
        Task<MPaginatedResult<TipoIdentificacion>> GetPaginatedAsync(int pageNumber, int pageSize, string searchTerm = "", bool sortAscending = true);
        Task<bool> AddUpdateAsync(TipoIdentificacion tipoIdentificacion);
        Task<bool> DeleteAsync(int id);
    }
}
