using EncuestasInterfer.Models;
using EncuestasInterfer.Services.TipoIdentificacionService;
using Microsoft.EntityFrameworkCore;

namespace EncuestasInterfer.Services.TipoIdentificacionServices
{
    public class STipoIdentificacionServices : ITipoIdentificacionServices
    {
        private readonly EncuestaFeriaContext _encuestaDBContext;

        public STipoIdentificacionServices(EncuestaFeriaContext encuestaDBContext)
        {
            _encuestaDBContext = encuestaDBContext;
        }

        public async Task<bool> AddUpdateAsync(TipoIdentificacion tipoIdentificacion)
        {
            if (tipoIdentificacion.IdTipoIdentificacion > 0)
            {
                var existingTipoIdentificacion = await _encuestaDBContext.TipoIdentificacion
                    .FindAsync(tipoIdentificacion.IdTipoIdentificacion);

                if (existingTipoIdentificacion != null)
                {
                    existingTipoIdentificacion.NombreIdentificacion = tipoIdentificacion.NombreIdentificacion;
                    existingTipoIdentificacion.DescripcionIdentificacion = tipoIdentificacion.DescripcionIdentificacion;

                    _encuestaDBContext.TipoIdentificacion.Update(existingTipoIdentificacion);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                _encuestaDBContext.TipoIdentificacion.Add(tipoIdentificacion);
                tipoIdentificacion.Activo = true;
            }

            await _encuestaDBContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var tipoIdentificacion = await _encuestaDBContext.TipoIdentificacion.FindAsync(id);
            if (tipoIdentificacion != null)
            {
                tipoIdentificacion.Activo = false;
                _encuestaDBContext.TipoIdentificacion.Update(tipoIdentificacion);
                await _encuestaDBContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<TipoIdentificacion>> GetAllAsync()
        {
            return await _encuestaDBContext.TipoIdentificacion
                .Where(t => t.Activo == true)
                .ToListAsync();
        }

        public async Task<TipoIdentificacion> GetByIdAsync(int id)
        {
            try
            {
                var result = await _encuestaDBContext.TipoIdentificacion
                    .FirstOrDefaultAsync(t => t.IdTipoIdentificacion == id);

                if (result == null)
                {
                    throw new KeyNotFoundException($"No se encontró el tipo de identificación con ID {id}");
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar el tipo de identificación", ex);
            }
        }

        public async Task<MPaginatedResult<TipoIdentificacion>> GetPaginatedAsync(int pageNumber, int pageSize, string searchTerm = "", bool sortAscending = true)
        {
            IQueryable<TipoIdentificacion> query = _encuestaDBContext.TipoIdentificacion
                .Where(t => t.Activo == true);

            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(t =>
                    (t.NombreIdentificacion != null && t.NombreIdentificacion.Contains(searchTerm)) ||
                    (t.DescripcionIdentificacion != null && t.DescripcionIdentificacion.Contains(searchTerm))
                );
            }

            query = sortAscending
                ? query.OrderBy(t => t.IdTipoIdentificacion).ThenBy(t => t.NombreIdentificacion)
                : query.OrderByDescending(t => t.IdTipoIdentificacion).ThenByDescending(t => t.NombreIdentificacion);

            var totalItems = await query.CountAsync();

            var items = await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return new MPaginatedResult<TipoIdentificacion>
            {
                Items = items,
                TotalCount = totalItems,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
        }
    }
}