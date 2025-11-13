using EncuestasInterfer.Models;
using Microsoft.EntityFrameworkCore;

namespace EncuestasInterfer.Services.RespuestaEncuestaService
{
    public class SRespuestaEncuestaService : IRespuestaEncuestaService
    {
        private readonly EncuestaFeriaContext _encuestaDBContext;

        public SRespuestaEncuestaService(EncuestaFeriaContext encuestaDBContext)
        {
            _encuestaDBContext = encuestaDBContext;
        }

        public async Task<List<RespuestaEncuesta>> GetAllAsync()
        {
            return await _encuestaDBContext.RespuestaEncuesta
                .Include(r => r.IdEncuestaNavigation)
                .Include(r => r.IdTipoDocuementoIdentificacionNavigation)
                .Include(r => r.IdGeneroNavigation)
                .Include(r => r.IdNacionalidadNavigation)
                .Include(r => r.IdDepartamentoNavigation)
                .Include(r => r.IdMunicipioNavigation)
                .OrderByDescending(r => r.FechaRealizacion)
                .ToListAsync();
        }

        public async Task<RespuestaEncuesta> GetByIdWithDetailsAsync(int id)
        {
            try
            {
                var result = await _encuestaDBContext.RespuestaEncuesta
                    .Include(r => r.IdEncuestaNavigation)
                    .Include(r => r.IdTipoDocuementoIdentificacionNavigation)
                    .Include(r => r.IdGeneroNavigation)
                    .Include(r => r.IdNacionalidadNavigation)
                    .Include(r => r.IdDepartamentoNavigation)
                    .Include(r => r.IdMunicipioNavigation)
                    .Include(r => r.RespuestaDetalle)
                        .ThenInclude(rd => rd.IdPreguntaNavigation)
                            .ThenInclude(p => p.IdTipoPreguntaNavigation)
                    .Include(r => r.RespuestaDetalle)
                        .ThenInclude(rd => rd.IdOpcionNavigation)
                    .Include(r => r.RespuestaDetalle)
                        .ThenInclude(rd => rd.RespuestaMultiple)
                            .ThenInclude(rm => rm.IdOpcionNavigation)
                    .FirstOrDefaultAsync(r => r.IdRespuestaEncuesta == id);

                if (result == null)
                {
                    throw new KeyNotFoundException($"No se encontró la respuesta de encuesta con ID {id}");
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar la respuesta de encuesta", ex);
            }
        }

        public async Task<MPaginatedResult<RespuestaEncuesta>> GetPaginatedAsync(
            int pageNumber,
            int pageSize,
            string searchTerm = "",
            int? idEncuesta = null)
        {
            IQueryable<RespuestaEncuesta> query = _encuestaDBContext.RespuestaEncuesta
                .Include(r => r.IdEncuestaNavigation)
                .Include(r => r.IdTipoDocuementoIdentificacionNavigation)
                .Include(r => r.IdGeneroNavigation)
                .Include(r => r.IdNacionalidadNavigation)
                .Include(r => r.IdDepartamentoNavigation)
                .Include(r => r.IdMunicipioNavigation);

            // Filtrar por encuesta si se especifica
            if (idEncuesta.HasValue)
            {
                query = query.Where(r => r.IdEncuesta == idEncuesta.Value);
            }

            // Filtro por término de búsqueda
            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(r =>
                    (r.NumeroIdentificacion != null && r.NumeroIdentificacion.Contains(searchTerm)) ||
                    (r.IdEncuestaNavigation.Titulo != null && r.IdEncuestaNavigation.Titulo.Contains(searchTerm))
                );
            }

            // Ordenar por fecha más reciente
            query = query.OrderByDescending(r => r.FechaRealizacion);

            var totalItems = await query.CountAsync();

            var items = await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return new MPaginatedResult<RespuestaEncuesta>
            {
                Items = items,
                TotalCount = totalItems,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
        }

        public async Task<List<RespuestaDetalle>> GetDetallesByRespuestaIdAsync(int idRespuestaEncuesta)
        {
            return await _encuestaDBContext.RespuestaDetalle
                .Include(rd => rd.IdPreguntaNavigation)
                    .ThenInclude(p => p.IdTipoPreguntaNavigation)
                .Include(rd => rd.IdOpcionNavigation)
                .Include(rd => rd.RespuestaMultiple)
                    .ThenInclude(rm => rm.IdOpcionNavigation)
                .Where(rd => rd.IdRespuestaEncuesta == idRespuestaEncuesta)
                .OrderBy(rd => rd.IdPregunta)
                .ToListAsync();
        }
    }
}