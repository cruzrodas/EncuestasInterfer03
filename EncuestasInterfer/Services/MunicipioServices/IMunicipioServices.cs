using EncuestasInterfer.Models;

namespace EncuestasInterfer.Services.MunicipioServices
{
    public interface IMunicipioServices
    {
        Task<List<Municipio>> GetAllAsync();
        Task<List<Municipio>> GetByDepartamentoAsync(int idDepartamento);
        Task<Municipio> GetByIdAsync(int id);
        Task<MPaginatedResult<Municipio>> GetPaginatedAsync(int pageNumber, int pageSize, string searchTerm = "", bool sortAscending = true);
        Task<bool> AddUpdateAsync(Municipio municipio);
        Task<bool> DeleteAsync(int id);

    }
}
