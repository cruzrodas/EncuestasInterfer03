namespace EncuestasInterfer.Services.AnalisisEncuestaServices
{
    public interface IAnalisisEncuestaService
    {
        Task<Dictionary<string, int>> GetRespuestasPorEscalaAsync(int idPregunta);
        Task<Dictionary<string, Dictionary<string, int>>> GetEdadesPorMunicipioAsync(int idEncuesta);
        Task<Dictionary<string, Dictionary<string, int>>> GetEdadesPorGeneroAsync(int idEncuesta);
        Task<Dictionary<string, int>> GetVisitantesPorMunicipioAsync(int idEncuesta);

    }
}
