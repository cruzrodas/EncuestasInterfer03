using EncuestasInterfer.Models;
using Microsoft.EntityFrameworkCore;
using static MudBlazor.CategoryTypes;

namespace EncuestasInterfer.Services.TiposCompraServices
{
    public class STiposCompraServices : ITiposCompraServices
    {

        private readonly EncuestaFeriaContext _encuestaDBContext;

        public STiposCompraServices(EncuestaFeriaContext encuestaDBContext)
        {
            _encuestaDBContext = encuestaDBContext;
        }

        public async Task<bool> AddUpdateAsync(TiposCompra tcompra)
        {
            if (tcompra.IdTipoCompra > 0)
            {
                // Buscar la feria existente en la base de datos
                var existingtcompra = await _encuestaDBContext.TiposCompra.FindAsync(tcompra.IdTipoCompra);

                if (existingtcompra != null)
                {
                    // Actualizar las propiedades existentes

                    existingtcompra.NombreTipoCompra = tcompra.NombreTipoCompra;

                    // Marcar el espacio como modificado
                    _encuestaDBContext.TiposCompra.Update(existingtcompra);
                }
                else
                {
                    return false; // Si no se encontró el espacio, devolver false
                }
            }
            else
            {
                // Si no hay ID, se trata de un nuevo espacio, agregarlo
                _encuestaDBContext.TiposCompra.Add(tcompra);
                tcompra.Activo = true;
            }

            // Guardar los cambios en la base de datos
            await _encuestaDBContext.SaveChangesAsync();
            return true; // Retornar true si se ha agregado o actualizado correctamente
        }

        public async Task<bool> DeleteAsync(int tcompra)
        {
            var estado = await _encuestaDBContext.TiposCompra.FindAsync(tcompra);
            if (estado != null)
            {
                estado.Activo = false;

                _encuestaDBContext.TiposCompra.Update(estado);
                await _encuestaDBContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<TiposCompra>> GetAllAsync()
        {
            return await _encuestaDBContext.TiposCompra
           .Where(g => g.Activo == true)
          .ToListAsync();
        }

        public async Task<TiposCompra> GetByIdAsync(int id_tcompra)
        {
            try
            {
                var result = await _encuestaDBContext.TiposCompra
                    .FirstOrDefaultAsync(fa => fa.IdTipoCompra == id_tcompra);

                if (result == null)
                {
                    // Manejar el caso donde no se encontró el objeto
                    throw new KeyNotFoundException($"No se encontró el genero de feria con ID {id_tcompra}");
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar el Tipo de Compra", ex);
            }
        }

        public async Task<MPaginatedResult<TiposCompra>> GetPaginatedAsync(int pageNumber, int pageSize, string searchTerm = "", bool sortAscending = true)
        {
            IQueryable<TiposCompra> query = _encuestaDBContext.TiposCompra
            .Where(g => g.Activo == true);

            // Filtro por el término de búsqueda
            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(fa => fa.NombreTipoCompra != null && fa.NombreTipoCompra.Contains(searchTerm));
            }

            // Ordenamiento
            query = sortAscending
                ? query.OrderBy(fa => fa.IdTipoCompra).ThenBy(fa => fa.NombreTipoCompra)
                : query.OrderByDescending(fa => fa.IdTipoCompra).ThenByDescending(fa => fa.NombreTipoCompra);

            var totalItems = await query.CountAsync();

            // Aplicar paginación
            var items = await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return new MPaginatedResult<TiposCompra>
            {
                Items = items,
                TotalCount = totalItems,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
        }
    }
}
