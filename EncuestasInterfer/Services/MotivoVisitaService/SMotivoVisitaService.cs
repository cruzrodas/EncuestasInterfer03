using EncuestasInterfer.Models;
using Microsoft.EntityFrameworkCore;
using static MudBlazor.CategoryTypes;

namespace EncuestasInterfer.Services.MotivoVisitaService
{
    public class SMotivoVisitaService : IMotivoVisitaServices
    {
        private readonly EncuestaFeriaContext _encuestaDBContext;

        public SMotivoVisitaService(EncuestaFeriaContext encuestaDBContext)
        {
            _encuestaDBContext = encuestaDBContext;
        }

        public async Task<bool> AddUpdateAsync(MotivoVisita motivoVisita)
        {
            if (motivoVisita.IdMotivoVisita > 0)
            {
                // Buscar la feria existente en la base de datos
                var existingmotivovisita = await _encuestaDBContext.MotivoVisita.FindAsync(motivoVisita.IdMotivoVisita);

                if (existingmotivovisita != null)
                {
                    // Actualizar las propiedades existentes

                    existingmotivovisita.NombreMotivo = motivoVisita.NombreMotivo;

                    // Marcar el espacio como modificado
                    _encuestaDBContext.MotivoVisita.Update(existingmotivovisita);
                }
                else
                {
                    return false; // Si no se encontró el espacio, devolver false
                }
            }
            else
            {
                // Si no hay ID, se trata de un nuevo espacio, agregarlo
                _encuestaDBContext.MotivoVisita.Add(motivoVisita);
                motivoVisita.Activo = true;
            }

            // Guardar los cambios en la base de datos
            await _encuestaDBContext.SaveChangesAsync();
            return true; // Retornar true si se ha agregado o actualizado correctamente
        }

        public async Task<bool> DeleteAsync(int motivovisita)
        {
            var estado = await _encuestaDBContext.MotivoVisita.FindAsync(motivovisita);
            if (estado != null)
            {
                estado.Activo = false;

                _encuestaDBContext.MotivoVisita.Update(estado);
                await _encuestaDBContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<MotivoVisita>> GetAllAsync()
        {
            return await _encuestaDBContext.MotivoVisita
          .Where(g => g.Activo == true)
          .ToListAsync();
        }

        public async Task<MotivoVisita> GetByIdAsync(int id_mvisita)
        {
            try
            {
                var result = await _encuestaDBContext.MotivoVisita
                    .FirstOrDefaultAsync(fa => fa.IdMotivoVisita == id_mvisita);

                if (result == null)
                {
                    // Manejar el caso donde no se encontró el objeto
                    throw new KeyNotFoundException($"No se encontró el motivo de la visita de feria con ID {id_mvisita}");
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar el Motivo de la visita", ex);
            }
        }

        public async Task<MPaginatedResult<MotivoVisita>> GetPaginatedAsync(int pageNumber, int pageSize, string searchTerm = "", bool sortAscending = true)
        {
            IQueryable<MotivoVisita> query = _encuestaDBContext.MotivoVisita
           .Where(g => g.Activo == true);

            // Filtro por el término de búsqueda
            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(fa => fa.NombreMotivo != null && fa.NombreMotivo.Contains(searchTerm));
            }

            // Ordenamiento
            query = sortAscending
                ? query.OrderBy(fa => fa.IdMotivoVisita).ThenBy(fa => fa.NombreMotivo)
                : query.OrderByDescending(fa => fa.IdMotivoVisita).ThenByDescending(fa => fa.NombreMotivo);

            var totalItems = await query.CountAsync();

            // Aplicar paginación
            var items = await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return new MPaginatedResult<MotivoVisita>
            {
                Items = items,
                TotalCount = totalItems,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
        }
    }
}
