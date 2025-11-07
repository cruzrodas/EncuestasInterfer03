using EncuestasInterfer.Models;
using Microsoft.EntityFrameworkCore;

namespace EncuestasInterfer.Services.NacionalidadServices
{
    public class SNacionalidadServices : INacionalidadService
    {
        private readonly EncuestaFeriaContext _encuestaDBContext;

        public SNacionalidadServices(EncuestaFeriaContext encuestaDBContext)
        {
            _encuestaDBContext = encuestaDBContext;
        }

        public async Task<bool> AddUpdateAsync(Nacionalidad nacionalidad)
        {
            if (nacionalidad.IdNacionalidad > 0)
            {
                var existingNacionalidad = await _encuestaDBContext.Nacionalidad.FindAsync(nacionalidad.IdNacionalidad);

                if (existingNacionalidad != null)
                {
                    existingNacionalidad.NombrePais = nacionalidad.NombrePais;
                    _encuestaDBContext.Nacionalidad.Update(existingNacionalidad);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                _encuestaDBContext.Nacionalidad.Add(nacionalidad);
                nacionalidad.Activo = true;
            }

            await _encuestaDBContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var nacionalidad = await _encuestaDBContext.Nacionalidad.FindAsync(id);
            if (nacionalidad != null)
            {
                nacionalidad.Activo = false;
                _encuestaDBContext.Nacionalidad.Update(nacionalidad);
                await _encuestaDBContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<Nacionalidad>> GetAllAsync()
        {
            return await _encuestaDBContext.Nacionalidad
                .Where(n => n.Activo == true)
                .ToListAsync();
        }

        public async Task<Nacionalidad> GetByIdAsync(int id)
        {
            try
            {
                var result = await _encuestaDBContext.Nacionalidad
                    .FirstOrDefaultAsync(n => n.IdNacionalidad == id);

                if (result == null)
                {
                    throw new KeyNotFoundException($"No se encontró la nacionalidad con ID {id}");
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar la nacionalidad", ex);
            }
        }

        public async Task<MPaginatedResult<Nacionalidad>> GetPaginatedAsync(int pageNumber, int pageSize, string searchTerm = "", bool sortAscending = true)
        {
            IQueryable<Nacionalidad> query = _encuestaDBContext.Nacionalidad
                .Where(n => n.Activo == true);

            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(n => n.NombrePais != null && n.NombrePais.Contains(searchTerm));
            }

            query = sortAscending
                ? query.OrderBy(n => n.IdNacionalidad).ThenBy(n => n.NombrePais)
                : query.OrderByDescending(n => n.IdNacionalidad).ThenByDescending(n => n.NombrePais);

            var totalItems = await query.CountAsync();

            var items = await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return new MPaginatedResult<Nacionalidad>
            {
                Items = items,
                TotalCount = totalItems,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
        }
    }
}