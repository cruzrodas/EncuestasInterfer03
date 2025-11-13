using EncuestasInterfer.Models;
using Microsoft.EntityFrameworkCore;

namespace EncuestasInterfer.Services.TipoPreguntaServices
{
    public class STipoPreguntaServices : ITipoPreguntaServices
    {
        private readonly EncuestaFeriaContext _encuestaDBContext;

        public STipoPreguntaServices(EncuestaFeriaContext encuestaDBContext)
        {
            _encuestaDBContext = encuestaDBContext;
        }

        public async Task<List<TipoPregunta>> GetAllAsync()
        {
            return await _encuestaDBContext.TipoPregunta
                .Where(tp => tp.Activo == true)
                .OrderBy(tp => tp.NombreTipoPregunta)
                .ToListAsync();
        }

        public async Task<List<TipoPregunta>> GetActivosAsync()
        {
            return await _encuestaDBContext.TipoPregunta
                .Where(tp => tp.Activo == true)
                .OrderBy(tp => tp.NombreTipoPregunta)
                .ToListAsync();
        }

        public async Task<TipoPregunta> GetByIdAsync(int id)
        {
            try
            {
                var result = await _encuestaDBContext.TipoPregunta
                    .FirstOrDefaultAsync(tp => tp.IdTipoPregunta == id);

                if (result == null)
                {
                    throw new KeyNotFoundException($"No se encontró el tipo de pregunta con ID {id}");
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar el tipo de pregunta", ex);
            }
        }
    }
}