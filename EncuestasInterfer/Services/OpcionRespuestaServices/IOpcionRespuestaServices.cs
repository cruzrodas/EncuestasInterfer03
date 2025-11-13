using EncuestasInterfer.Models;

namespace EncuestasInterfer.Services.OpcionRespuestaServices
{
    public interface IOpcionRespuestaServices
    {
        Task<List<OpcionRespuesta>> GetAllAsync();
        Task<OpcionRespuesta> GetByIdAsync(int id);
        Task<List<OpcionRespuesta>> GetByPreguntaAsync(int idPregunta);
        Task<bool> AddUpdateAsync(OpcionRespuesta opcionRespuesta);
        Task<bool> DeleteAsync(int id);
        Task<bool> DeleteByPreguntaAsync(int idPregunta);
        Task<bool> AddMultipleAsync(List<OpcionRespuesta> opciones);

    }
}
