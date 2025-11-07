using EncuestasInterfer.Models;
using EncuestasInterfer.Services.DepartamentoService;
using Microsoft.EntityFrameworkCore;

namespace EncuestasInterfer.Services.DepartamentoServices
{
    public class SDepartamentoServices : IDepartamenteServices
    {
        private readonly EncuestaFeriaContext _encuestaDBContext;

        public SDepartamentoServices(EncuestaFeriaContext encuestaDBContext)
        {
            _encuestaDBContext = encuestaDBContext;
        }

        public async Task<bool> AddUpdateAsync(Departamento departamento)
        {
            if (departamento.IdDepartamento > 0)
            {
                var existingDepartamento = await _encuestaDBContext.Departamento.FindAsync(departamento.IdDepartamento);

                if (existingDepartamento != null)
                {
                    existingDepartamento.NombreDepartamento = departamento.NombreDepartamento;
                    existingDepartamento.IdNacionalidad = departamento.IdNacionalidad;
                    _encuestaDBContext.Departamento.Update(existingDepartamento);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                _encuestaDBContext.Departamento.Add(departamento);
                departamento.Activo = true;
            }

            await _encuestaDBContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var departamento = await _encuestaDBContext.Departamento.FindAsync(id);
            if (departamento != null)
            {
                departamento.Activo = false;
                _encuestaDBContext.Departamento.Update(departamento);
                await _encuestaDBContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<Departamento>> GetAllAsync()
        {
            return await _encuestaDBContext.Departamento
                .Include(d => d.IdNacionalidadNavigation)
                .Where(d => d.Activo == true)
                .ToListAsync();
        }

        public async Task<List<Departamento>> GetByNacionalidadAsync(int idNacionalidad)
        {
            return await _encuestaDBContext.Departamento
                .Where(d => d.Activo == true && d.IdNacionalidad == idNacionalidad)
                .ToListAsync();
        }

        public async Task<Departamento> GetByIdAsync(int id)
        {
            try
            {
                var result = await _encuestaDBContext.Departamento
                    .Include(d => d.IdNacionalidadNavigation)
                    .FirstOrDefaultAsync(d => d.IdDepartamento == id);

                if (result == null)
                {
                    throw new KeyNotFoundException($"No se encontró el departamento con ID {id}");
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar el departamento", ex);
            }
        }

        public async Task<MPaginatedResult<Departamento>> GetPaginatedAsync(int pageNumber, int pageSize, string searchTerm = "", bool sortAscending = true)
        {
            IQueryable<Departamento> query = _encuestaDBContext.Departamento
                .Include(d => d.IdNacionalidadNavigation)
                .Where(d => d.Activo == true);

            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(d => d.NombreDepartamento != null && d.NombreDepartamento.Contains(searchTerm));
            }

            query = sortAscending
                ? query.OrderBy(d => d.IdDepartamento).ThenBy(d => d.NombreDepartamento)
                : query.OrderByDescending(d => d.IdDepartamento).ThenByDescending(d => d.NombreDepartamento);

            var totalItems = await query.CountAsync();

            var items = await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return new MPaginatedResult<Departamento>
            {
                Items = items,
                TotalCount = totalItems,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
        }
    }
}