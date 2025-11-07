using EncuestasInterfer.Models;
using EncuestasInterfer.Services.TipoPublicidadServices;
using Microsoft.EntityFrameworkCore;

namespace EncuestasInterfer.Services.TipoPublicidadService
{
    public class STipoPublicidadService : ITipoPublicidadServices
    {
        private readonly EncuestaFeriaContext _encuestaDBContext;

        public STipoPublicidadService(EncuestaFeriaContext encuestaDBContext)
        {
            _encuestaDBContext = encuestaDBContext;
        }

        public async Task<bool> AddUpdateAsync(TipoPublicidad tipoPublicidad)
        {
            if (tipoPublicidad.IdTipoPublicidad > 0)
            {
                // Buscar el tipo de publicidad existente en la base de datos
                var existingTipoPublicidad = await _encuestaDBContext.TipoPublicidad.FindAsync(tipoPublicidad.IdTipoPublicidad);

                if (existingTipoPublicidad != null)
                {
                    // Actualizar las propiedades existentes
                    existingTipoPublicidad.NombreTipoPublicidad = tipoPublicidad.NombreTipoPublicidad;

                    // Marcar como modificado
                    _encuestaDBContext.TipoPublicidad.Update(existingTipoPublicidad);
                }
                else
                {
                    return false; // Si no se encontró el tipo de publicidad, devolver false
                }
            }
            else
            {
                // Si no hay ID, se trata de un nuevo tipo de publicidad, agregarlo
                _encuestaDBContext.TipoPublicidad.Add(tipoPublicidad);
                tipoPublicidad.Activo = true;
            }

            // Guardar los cambios en la base de datos
            await _encuestaDBContext.SaveChangesAsync();
            return true; // Retornar true si se ha agregado o actualizado correctamente
        }

        public async Task<bool> DeleteAsync(int idTipoPublicidad)
        {
            var tipoPublicidad = await _encuestaDBContext.TipoPublicidad.FindAsync(idTipoPublicidad);
            if (tipoPublicidad != null)
            {
                tipoPublicidad.Activo = false;

                _encuestaDBContext.TipoPublicidad.Update(tipoPublicidad);
                await _encuestaDBContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<TipoPublicidad>> GetAllAsync()
        {
            return await _encuestaDBContext.TipoPublicidad
                .Where(tp => tp.Activo == true)
                .ToListAsync();
        }

        public async Task<TipoPublicidad> GetByIdAsync(int id_tpublicidad)
        {
            try
            {
                var result = await _encuestaDBContext.TipoPublicidad
                    .FirstOrDefaultAsync(tp => tp.IdTipoPublicidad == id_tpublicidad);

                if (result == null)
                {
                    // Manejar el caso donde no se encontró el objeto
                    throw new KeyNotFoundException($"No se encontró el tipo de publicidad con ID {id_tpublicidad}");
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar el tipo de publicidad", ex);
            }
        }

        public async Task<MPaginatedResult<TipoPublicidad>> GetPaginatedAsync(int pageNumber, int pageSize, string searchTerm = "", bool sortAscending = true)
        {
            IQueryable<TipoPublicidad> query = _encuestaDBContext.TipoPublicidad
                .Where(tp => tp.Activo == true);

            // Filtro por el término de búsqueda
            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(tp => tp.NombreTipoPublicidad != null && tp.NombreTipoPublicidad.Contains(searchTerm));
            }

            // Ordenamiento
            query = sortAscending
                ? query.OrderBy(tp => tp.IdTipoPublicidad).ThenBy(tp => tp.NombreTipoPublicidad)
                : query.OrderByDescending(tp => tp.IdTipoPublicidad).ThenByDescending(tp => tp.NombreTipoPublicidad);

            var totalItems = await query.CountAsync();

            // Aplicar paginación
            var items = await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return new MPaginatedResult<TipoPublicidad>
            {
                Items = items,
                TotalCount = totalItems,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
        }
    }
}