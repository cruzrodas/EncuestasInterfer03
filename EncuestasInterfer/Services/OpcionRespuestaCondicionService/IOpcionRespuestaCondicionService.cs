using EncuestasInterfer.Models;

namespace EncuestasInterfer.Services.OpcionRespuestaCondicionService
{
    public interface IOpcionRespuestaCondicionService
    {
        Task<List<OpcionRespuestaCondicion>> GetAllAsync();
        Task<OpcionRespuestaCondicion> GetByIdAsync(int id);
        Task<List<OpcionRespuestaCondicion>> GetByOpcionRespuestaAsync(int idOpcionRespuesta);
        Task<List<OpcionRespuestaCondicion>> GetByPreguntaAsync(int idPregunta);
        Task<bool> AddUpdateAsync(OpcionRespuestaCondicion condicion);
        Task<bool> DeleteAsync(int id);

    }
}
