using EncuestasInterfer.Models;

namespace EncuestasInterfer.Services.NacionalidadServices
{
    public interface INacionalidadService
    {
        Task<List<Nacionalidad>> GetAllAsync();
        Task<Nacionalidad> GetByIdAsync(int id);
        Task<MPaginatedResult<Nacionalidad>> GetPaginatedAsync(int pageNumber, int pageSize, string searchTerm = "", bool sortAscending = true);
        Task<bool> AddUpdateAsync(Nacionalidad nacionalidad);
        Task<bool> DeleteAsync(int id);

    }
}
