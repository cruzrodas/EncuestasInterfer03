using EncuestasInterfer.Models;

namespace EncuestasInterfer.Services.TipoPublicidadServices
{
    public interface ITipoPublicidadServices
    {
        Task<List<TipoPublicidad>> GetAllAsync();
        Task<TipoPublicidad> GetByIdAsync(int id_tpublicidad);
        Task<MPaginatedResult<TipoPublicidad>> GetPaginatedAsync(int pageNumber, int pageSize, string searchTerm = "", bool sortAscending = true);
        Task<bool> AddUpdateAsync(TipoPublicidad tipoPublicidad);
        Task<bool> DeleteAsync(int idTipoPublicidad);
    }
}
