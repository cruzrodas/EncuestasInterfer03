using Microsoft.EntityFrameworkCore;
using EncuestasInterfer.Models;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace EncuestasInterfer.Services.GeneroServices
{
    public class SGeneroServices : IGeneroServices
    {
        private readonly EncuestaFeriaContext _encuestaDBContext;

        public SGeneroServices(EncuestaFeriaContext compraDbContext)
        {
            _encuestaDBContext = compraDbContext;
        }

        public async Task<bool> AddUpdateAsync(Genero genero)
        {
            if (genero.IdGenero > 0)
            {
                // Buscar la feria existente en la base de datos
                var existinggenero = await _encuestaDBContext.Genero.FindAsync(genero.IdGenero);

                if (existinggenero != null)
                {
                    // Actualizar las propiedades existentes

                    existinggenero.NombreGenero = genero.NombreGenero;

                    // Marcar el espacio como modificado
                    _encuestaDBContext.Genero.Update(existinggenero);
                }
                else
                {
                    return false; // Si no se encontró el espacio, devolver false
                }
            }
            else
            {
                // Si no hay ID, se trata de un nuevo espacio, agregarlo
                _encuestaDBContext.Genero.Add(genero);
                genero.Activo = true;
            }

            // Guardar los cambios en la base de datos
            await _encuestaDBContext.SaveChangesAsync();
            return true; // Retornar true si se ha agregado o actualizado correctamente
        }

        public async Task<bool> DeleteAsync(int genero)
        {
            var estado = await _encuestaDBContext.Genero.FindAsync(genero);
            if (estado != null)
            {
                estado.Activo = false; 

                _encuestaDBContext.Genero.Update(estado);
                await _encuestaDBContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<Genero>> GetAllAsync()
        {
            return await _encuestaDBContext.Genero
              .Where(g => g.Activo == true)
              .ToListAsync();
        }

        public async Task<Genero> GetByIdAsync(int id_genero)
        {

            try
            {
                var result = await _encuestaDBContext.Genero
                    .FirstOrDefaultAsync(fa => fa.IdGenero == id_genero);

                if (result == null)
                {
                    // Manejar el caso donde no se encontró el objeto
                    throw new KeyNotFoundException($"No se encontró el genero de feria con ID {id_genero}");
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar el Genero", ex);
            }
        }

        public async Task<MPaginatedResult<Genero>> GetPaginatedAsync(int pageNumber, int pageSize, string searchTerm = "", bool sortAscending = true)
        {
            IQueryable<Genero> query = _encuestaDBContext.Genero
            .Where(g => g.Activo == true);

            // Filtro por el término de búsqueda
            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(fa => fa.NombreGenero != null && fa.NombreGenero.Contains(searchTerm));
            }

            // Ordenamiento
            query = sortAscending
                ? query.OrderBy(fa => fa.IdGenero).ThenBy(fa => fa.NombreGenero)
                : query.OrderByDescending(fa => fa.IdGenero).ThenByDescending(fa => fa.NombreGenero);

            var totalItems = await query.CountAsync();

            // Aplicar paginación
            var items = await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return new MPaginatedResult<Genero>
            {
                Items = items,
                TotalCount = totalItems,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
        }
    }
}
