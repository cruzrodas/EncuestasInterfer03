using EncuestasInterfer.Models;

namespace EncuestasInterfer.Services.DepartamentoService
{
    public interface IDepartamenteServices
    {
        Task<List<Departamento>> GetAllAsync();
        Task<List<Departamento>> GetByNacionalidadAsync(int idNacionalidad);
        Task<Departamento> GetByIdAsync(int id);
        Task<MPaginatedResult<Departamento>> GetPaginatedAsync(int pageNumber, int pageSize, string searchTerm = "", bool sortAscending = true);
        Task<bool> AddUpdateAsync(Departamento departamento);
        Task<bool> DeleteAsync(int id);
    }
}
