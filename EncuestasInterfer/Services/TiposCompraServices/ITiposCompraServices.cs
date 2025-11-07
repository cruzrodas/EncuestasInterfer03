using EncuestasInterfer.Models;

namespace EncuestasInterfer.Services.TiposCompraServices
{
    public interface ITiposCompraServices
    {

        Task<bool> AddUpdateAsync(TiposCompra tcompra);
        Task<bool> DeleteAsync(int tcompra);
        Task<List<TiposCompra>> GetAllAsync();
        Task<TiposCompra> GetByIdAsync(int id_tcompra);

        Task<MPaginatedResult<TiposCompra>> GetPaginatedAsync(int pageNumber, int pageSize, string searchTerm = "", bool sortAscending = true);
    }
}
