using EncuestasInterfer.Models;

namespace EncuestasInterfer.Services.MotivoVisitaService
{
    public interface IMotivoVisitaServices
    {
        Task<bool> AddUpdateAsync(MotivoVisita motivoVisita);
        Task<bool> DeleteAsync(int motivovisita);
        Task<List<MotivoVisita>> GetAllAsync();
        Task<MotivoVisita> GetByIdAsync(int id_mvisita);

        Task<MPaginatedResult<MotivoVisita>> GetPaginatedAsync(int pageNumber, int pageSize, string searchTerm = "", bool sortAscending = true);
    }
}
