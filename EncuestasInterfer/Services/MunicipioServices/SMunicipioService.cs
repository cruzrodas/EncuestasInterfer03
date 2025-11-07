using EncuestasInterfer.Models;
using Microsoft.EntityFrameworkCore;

namespace EncuestasInterfer.Services.MunicipioServices
{
    public class SMunicipioServices : IMunicipioServices
    {
        private readonly EncuestaFeriaContext _encuestaDBContext;

        public SMunicipioServices(EncuestaFeriaContext encuestaDBContext)
        {
            _encuestaDBContext = encuestaDBContext;
        }

        public async Task<bool> AddUpdateAsync(Municipio municipio)
        {
            if (municipio.IdMunicipio > 0)
            {
                var existingMunicipio = await _encuestaDBContext.Municipio.FindAsync(municipio.IdMunicipio);

                if (existingMunicipio != null)
                {
                    existingMunicipio.NombreMunicipio = municipio.NombreMunicipio;
                    existingMunicipio.IdDepartamento = municipio.IdDepartamento;
                    _encuestaDBContext.Municipio.Update(existingMunicipio);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                _encuestaDBContext.Municipio.Add(municipio);
                municipio.Activo = true;
            }

            await _encuestaDBContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var municipio = await _encuestaDBContext.Municipio.FindAsync(id);
            if (municipio != null)
            {
                municipio.Activo = false;
                _encuestaDBContext.Municipio.Update(municipio);
                await _encuestaDBContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<Municipio>> GetAllAsync()
        {
            return await _encuestaDBContext.Municipio
                .Include(m => m.IdDepartamentoNavigation)
                .ThenInclude(d => d.IdNacionalidadNavigation)
                .Where(m => m.Activo == true)
                .ToListAsync();
        }

        public async Task<List<Municipio>> GetByDepartamentoAsync(int idDepartamento)
        {
            return await _encuestaDBContext.Municipio
                .Where(m => m.Activo == true && m.IdDepartamento == idDepartamento)
                .ToListAsync();
        }

        public async Task<Municipio> GetByIdAsync(int id)
        {
            try
            {
                var result = await _encuestaDBContext.Municipio
                    .Include(m => m.IdDepartamentoNavigation)
                    .ThenInclude(d => d.IdNacionalidadNavigation)
                    .FirstOrDefaultAsync(m => m.IdMunicipio == id);

                if (result == null)
                {
                    throw new KeyNotFoundException($"No se encontró el municipio con ID {id}");
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar el municipio", ex);
            }
        }

        public async Task<MPaginatedResult<Municipio>> GetPaginatedAsync(int pageNumber, int pageSize, string searchTerm = "", bool sortAscending = true)
        {
            IQueryable<Municipio> query = _encuestaDBContext.Municipio
                .Include(m => m.IdDepartamentoNavigation)
                .ThenInclude(d => d.IdNacionalidadNavigation)
                .Where(m => m.Activo == true);

            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(m => m.NombreMunicipio != null && m.NombreMunicipio.Contains(searchTerm));
            }

            query = sortAscending
                ? query.OrderBy(m => m.IdMunicipio).ThenBy(m => m.NombreMunicipio)
                : query.OrderByDescending(m => m.IdMunicipio).ThenByDescending(m => m.NombreMunicipio);

            var totalItems = await query.CountAsync();

            var items = await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return new MPaginatedResult<Municipio>
            {
                Items = items,
                TotalCount = totalItems,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
        }
    }
}