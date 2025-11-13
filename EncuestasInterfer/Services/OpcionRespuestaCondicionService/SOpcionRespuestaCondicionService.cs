using EncuestasInterfer.Models;
using Microsoft.EntityFrameworkCore;

namespace EncuestasInterfer.Services.OpcionRespuestaCondicionService
{
    public class SOpcionRespuestaCondicionService : IOpcionRespuestaCondicionService
    {
        private readonly EncuestaFeriaContext _context;

        public SOpcionRespuestaCondicionService(EncuestaFeriaContext context)
        {
            _context = context;
        }

        public async Task<bool> AddUpdateAsync(OpcionRespuestaCondicion condicion)
        {
            if (condicion.IdOpcionRespuestaCondicion > 0)
            {
                var existing = await _context.OpcionRespuestaCondicion
                    .FindAsync(condicion.IdOpcionRespuestaCondicion);

                if (existing != null)
                {
                    existing.IdOpcionRespuesta = condicion.IdOpcionRespuesta;
                    existing.TipoAccion = condicion.TipoAccion;
                    existing.IdPreguntaDestino = condicion.IdPreguntaDestino;
                    existing.Activa = condicion.Activa;

                    _context.OpcionRespuestaCondicion.Update(existing);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                condicion.Activa = true;
                _context.OpcionRespuestaCondicion.Add(condicion);
            }

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var condicion = await _context.OpcionRespuestaCondicion.FindAsync(id);
            if (condicion != null)
            {
                condicion.Activa = false;
                _context.OpcionRespuestaCondicion.Update(condicion);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<OpcionRespuestaCondicion>> GetAllAsync()
        {
            return await _context.OpcionRespuestaCondicion
                .Include(c => c.IdOpcionRespuestaNavigation)
                .Include(c => c.IdPreguntaDestinoNavigation)
                .Where(c => c.Activa == true)
                .ToListAsync();
        }

        public async Task<OpcionRespuestaCondicion> GetByIdAsync(int id)
        {
            var result = await _context.OpcionRespuestaCondicion
                .Include(c => c.IdOpcionRespuestaNavigation)
                .Include(c => c.IdPreguntaDestinoNavigation)
                .FirstOrDefaultAsync(c => c.IdOpcionRespuestaCondicion == id);

            if (result == null)
            {
                throw new KeyNotFoundException($"No se encontró la condición con ID {id}");
            }

            return result;
        }

        public async Task<List<OpcionRespuestaCondicion>> GetByOpcionRespuestaAsync(int idOpcionRespuesta)
        {
            return await _context.OpcionRespuestaCondicion
                .Include(c => c.IdOpcionRespuestaNavigation)
                .Include(c => c.IdPreguntaDestinoNavigation)
                .Where(c => c.IdOpcionRespuesta == idOpcionRespuesta && c.Activa == true)
                .ToListAsync();
        }

        public async Task<List<OpcionRespuestaCondicion>> GetByPreguntaAsync(int idPregunta)
        {
            return await _context.OpcionRespuestaCondicion
                .Include(c => c.IdOpcionRespuestaNavigation)
                    .ThenInclude(o => o.IdPreguntaNavigation)
                .Include(c => c.IdPreguntaDestinoNavigation)
                .Where(c => c.IdOpcionRespuestaNavigation.IdPregunta == idPregunta && c.Activa == true)
                .ToListAsync();
        }
    }
}