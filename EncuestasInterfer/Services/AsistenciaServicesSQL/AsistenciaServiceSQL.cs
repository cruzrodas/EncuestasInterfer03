using EncuestasInterfer.BioTimeSQL;
using Microsoft.EntityFrameworkCore;

namespace EncuestasInterfer.Services.AsistenciaServicesSQL
{
    /// <summary>
    /// Servicio de control de asistencia sin DTOs
    /// VERSIÓN FINAL: El dispositivo almacena en hora local
    /// Solo especificamos UTC para que PostgreSQL lo acepte, pero NO convertimos la hora
    /// </summary>
    public class AsistenciaServiceSQL : IAsistenciaServiceSQL
    {
        private readonly BioTimeSQLContext _context;

        public AsistenciaServiceSQL(BioTimeSQLContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Obtiene el rango para un día completo
        /// Especifica UTC sin cambiar el valor para que PostgreSQL lo acepte
        /// </summary>
        private static (DateTime Inicio, DateTime Fin) ObtenerRangoDelDia(DateTime fecha)
        {
            // Obtener inicio y fin del día
            var inicioDelDia = fecha.Date; // 00:00:00
            var finDelDia = fecha.Date.AddDays(1).AddTicks(-1); // 23:59:59

            // CRÍTICO: Especificar UTC para PostgreSQL, pero SIN cambiar el valor
            inicioDelDia = DateTime.SpecifyKind(inicioDelDia, DateTimeKind.Utc);
            finDelDia = DateTime.SpecifyKind(finDelDia, DateTimeKind.Utc);

            return (inicioDelDia, finDelDia);
        }

        public async Task<List<PersonnelEmployee>> GetEmpleadosActivosAsync()
        {
            return await _context.PersonnelEmployee
                .Where(e => e.IsActive && !e.Deleted)
                .Include(e => e.Department)
                .Include(e => e.Position)
                .Include(e => e.Company)
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .ToListAsync();
        }

        public async Task<List<PersonnelEmployee>> GetEmpleadosAsistieronAsync(DateTime fecha)
        {
            var (inicioDelDia, finDelDia) = ObtenerRangoDelDia(fecha);

            var idsEmpleadosQueAsistieron = await _context.IclockTransactions
                .Where(t => t.PunchTime >= inicioDelDia && t.PunchTime <= finDelDia)
                .Select(t => t.EmpId)
                .Distinct()
                .ToListAsync();

            return await _context.PersonnelEmployees
                .Where(e => e.IsActive
                    && !e.Deleted
                    && idsEmpleadosQueAsistieron.Contains(e.Id))
                .Include(e => e.Department)
                .Include(e => e.Position)
                .Include(e => e.Company)
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .ToListAsync();
        }

        public async Task<List<PersonnelEmployee>> GetEmpleadosNoAsistieronAsync(DateTime fecha)
        {
            var (inicioDelDia, finDelDia) = ObtenerRangoDelDia(fecha);

            var idsEmpleadosQueAsistieron = await _context.IclockTransactions
                .Where(t => t.PunchTime >= inicioDelDia && t.PunchTime <= finDelDia)
                .Select(t => t.EmpId)
                .Distinct()
                .ToListAsync();

            return await _context.PersonnelEmployees
                .Where(e => e.IsActive
                    && !e.Deleted
                    && !idsEmpleadosQueAsistieron.Contains(e.Id))
                .Include(e => e.Department)
                .Include(e => e.Position)
                .Include(e => e.Company)
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .ToListAsync();
        }

        public async Task<List<IclockTransaction>> GetMarcajesPorFechaAsync(DateTime fecha)
        {
            var (inicioDelDia, finDelDia) = ObtenerRangoDelDia(fecha);

            return await _context.IclockTransactions
                .Where(t => t.PunchTime >= inicioDelDia && t.PunchTime <= finDelDia)
                .Include(t => t.Emp)
                    .ThenInclude(e => e.Department)
                .Include(t => t.Emp)
                    .ThenInclude(e => e.Position)
                .Include(t => t.Terminal)
                .OrderBy(t => t.PunchTime)
                .ToListAsync();
        }

        public async Task<List<IclockTransaction>> GetMarcajesPorEmpleadoYFechaAsync(int empleadoId, DateTime fecha)
        {
            var (inicioDelDia, finDelDia) = ObtenerRangoDelDia(fecha);

            return await _context.IclockTransactions
                .Where(t => t.EmpId == empleadoId
                    && t.PunchTime >= inicioDelDia
                    && t.PunchTime <= finDelDia)
                .Include(t => t.Emp)
                .Include(t => t.Terminal)
                .OrderBy(t => t.PunchTime)
                .ToListAsync();
        }

        public async Task<List<IclockTransaction>> GetHistorialMarcajesEmpleadoAsync(int empleadoId, DateTime fechaInicio, DateTime fechaFin)
        {
            var inicio = DateTime.SpecifyKind(fechaInicio.Date, DateTimeKind.Utc);
            var fin = DateTime.SpecifyKind(fechaFin.Date.AddDays(1).AddTicks(-1), DateTimeKind.Utc);

            return await _context.IclockTransactions
                .Where(t => t.EmpId == empleadoId
                    && t.PunchTime >= inicio
                    && t.PunchTime <= fin)
                .Include(t => t.Emp)
                    .ThenInclude(e => e.Department)
                .Include(t => t.Emp)
                    .ThenInclude(e => e.Position)
                .Include(t => t.Terminal)
                .OrderBy(t => t.PunchTime)
                .ToListAsync();
        }

        public async Task<int> GetTotalEmpleadosActivosAsync()
        {
            return await _context.PersonnelEmployees
                .Where(e => e.IsActive && !e.Deleted)
                .CountAsync();
        }

        public async Task<int> GetTotalAsistenciasPorFechaAsync(DateTime fecha)
        {
            var (inicioDelDia, finDelDia) = ObtenerRangoDelDia(fecha);

            return await _context.IclockTransactions
                .Where(t => t.PunchTime >= inicioDelDia && t.PunchTime <= finDelDia)
                .Select(t => t.EmpId)
                .Distinct()
                .CountAsync();
        }

        public async Task<int> GetTotalAusenciasPorFechaAsync(DateTime fecha)
        {
            var totalEmpleados = await GetTotalEmpleadosActivosAsync();
            var totalAsistencias = await GetTotalAsistenciasPorFechaAsync(fecha);
            return totalEmpleados - totalAsistencias;
        }

        public async Task<int> GetTotalMarcajesPorFechaAsync(DateTime fecha)
        {
            var (inicioDelDia, finDelDia) = ObtenerRangoDelDia(fecha);

            return await _context.IclockTransactions
                .Where(t => t.PunchTime >= inicioDelDia && t.PunchTime <= finDelDia)
                .CountAsync();
        }

        public async Task<decimal> GetPorcentajeAsistenciaPorFechaAsync(DateTime fecha)
        {
            var totalEmpleados = await GetTotalEmpleadosActivosAsync();

            if (totalEmpleados == 0)
                return 0;

            var totalAsistencias = await GetTotalAsistenciasPorFechaAsync(fecha);

            return Math.Round((decimal)totalAsistencias / totalEmpleados * 100, 2);
        }

        public async Task<IclockTransaction?> GetPrimeraEntradaAsync(int empleadoId, DateTime fecha)
        {
            var (inicioDelDia, finDelDia) = ObtenerRangoDelDia(fecha);

            return await _context.IclockTransactions
                .Where(t => t.EmpId == empleadoId
                    && t.PunchTime >= inicioDelDia
                    && t.PunchTime <= finDelDia)
                .Include(t => t.Terminal)
                .OrderBy(t => t.PunchTime)
                .FirstOrDefaultAsync();
        }

        public async Task<IclockTransaction?> GetUltimaSalidaAsync(int empleadoId, DateTime fecha)
        {
            var (inicioDelDia, finDelDia) = ObtenerRangoDelDia(fecha);

            return await _context.IclockTransactions
                .Where(t => t.EmpId == empleadoId
                    && t.PunchTime >= inicioDelDia
                    && t.PunchTime <= finDelDia)
                .Include(t => t.Terminal)
                .OrderByDescending(t => t.PunchTime)
                .FirstOrDefaultAsync();
        }

        public async Task<Dictionary<string, List<PersonnelEmployee>>> GetAsistenciaPorDepartamentoAsync(DateTime fecha)
        {
            var empleadosQueAsistieron = await GetEmpleadosAsistieronAsync(fecha);

            return empleadosQueAsistieron
                .GroupBy(e => e.Department?.DeptName ?? "Sin Departamento")
                .ToDictionary(
                    g => g.Key,
                    g => g.ToList()
                );
        }

        public async Task<Dictionary<string, decimal>> GetEstadisticasPorDepartamentoAsync(DateTime fecha)
        {
            var (inicioDelDia, finDelDia) = ObtenerRangoDelDia(fecha);

            var departamentos = await _context.PersonnelDepartments
                .Where(d => d.PersonnelEmployees.Any(e => e.IsActive && !e.Deleted))
                .Select(d => new
                {
                    d.Id,
                    d.DeptName,
                    TotalEmpleados = d.PersonnelEmployees.Count(e => e.IsActive && !e.Deleted)
                })
                .ToListAsync();

            var asistenciasPorDept = await _context.IclockTransactions
                .Where(t => t.PunchTime >= inicioDelDia && t.PunchTime <= finDelDia)
                .Where(t => t.Emp != null && t.Emp.Department != null)
                .GroupBy(t => new { t.Emp.DepartmentId, t.Emp.Department.DeptName })
                .Select(g => new
                {
                    DepartamentoId = g.Key.DepartmentId,
                    NombreDepartamento = g.Key.DeptName,
                    EmpleadosAsistieron = g.Select(t => t.EmpId).Distinct().Count()
                })
                .ToListAsync();

            var estadisticas = new Dictionary<string, decimal>();

            foreach (var dept in departamentos)
            {
                var asistencia = asistenciasPorDept.FirstOrDefault(a => a.DepartamentoId == dept.Id);
                var porcentaje = dept.TotalEmpleados > 0 && asistencia != null
                    ? Math.Round((decimal)asistencia.EmpleadosAsistieron / dept.TotalEmpleados * 100, 2)
                    : 0;

                estadisticas[dept.DeptName ?? "Sin Departamento"] = porcentaje;
            }

            return estadisticas.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        }

        public async Task<bool> EmpleadoAsistioAsync(int empleadoId, DateTime fecha)
        {
            var (inicioDelDia, finDelDia) = ObtenerRangoDelDia(fecha);

            return await _context.IclockTransactions
                .AnyAsync(t => t.EmpId == empleadoId
                    && t.PunchTime >= inicioDelDia
                    && t.PunchTime <= finDelDia);
        }

        public async Task<int> GetTotalMarcajesEmpleadoAsync(int empleadoId, DateTime fecha)
        {
            var (inicioDelDia, finDelDia) = ObtenerRangoDelDia(fecha);

            return await _context.IclockTransactions
                .Where(t => t.EmpId == empleadoId
                    && t.PunchTime >= inicioDelDia
                    && t.PunchTime <= finDelDia)
                .CountAsync();
        }
    }
}