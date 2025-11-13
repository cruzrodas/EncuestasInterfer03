using EncuestasInterfer.Models;

namespace EncuestasInterfer.Services.PreguntasServices
{
    public interface IPreguntasServices
    {
        // Métodos básicos CRUD
        Task<List<Pregunta>> GetAllAsync();
        Task<Pregunta> GetByIdAsync(int id);
        Task<Pregunta> GetByIdWithOpcionesAsync(int id);
        Task<Pregunta> GetByIdWithOptionsAsync(int id);
        Task<List<Pregunta>> GetByEncuestaAsync(int idEncuesta);
        Task<MPaginatedResult<Pregunta>> GetPaginatedAsync(int pageNumber, int pageSize, string searchTerm = "", int? idEncuesta = null);
        Task<bool> AddUpdateAsync(Pregunta pregunta);
        Task<bool> UpdateAsync(Pregunta pregunta);
        Task<bool> DeleteAsync(int id);

        // Métodos auxiliares
        Task<bool> ActivarDesactivarAsync(int id, bool activo);
        Task<int> GetCountByEncuestaAsync(int idEncuesta);

        // Método nuevo para orden manual
        Task<bool> CambiarOrdenAsync(int idPregunta, int nuevoOrden);
    }
}