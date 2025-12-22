using EncuestasInterfer.BioTime;

namespace EncuestasInterfer.Services.AsistenciaServices
{
    /// <summary>
    /// Interfaz para el servicio de control de asistencia
    /// Utiliza directamente los modelos de BioTime sin DTOs
    /// </summary>
    public interface IAsistenciaServiceSQL
    {
        /// <summary>
        /// Obtiene todos los empleados activos
        /// </summary>
        Task<List<PersonnelEmployee>> GetEmpleadosActivosAsync();

        /// <summary>
        /// Obtiene los empleados que registraron asistencia en una fecha específica
        /// </summary>
        Task<List<PersonnelEmployee>> GetEmpleadosAsistieronAsync(DateTime fecha);

        /// <summary>
        /// Obtiene los empleados que NO registraron asistencia en una fecha específica
        /// </summary>
        Task<List<PersonnelEmployee>> GetEmpleadosNoAsistieronAsync(DateTime fecha);

        /// <summary>
        /// Obtiene todos los marcajes (transactions) de una fecha específica
        /// </summary>
        Task<List<IclockTransaction>> GetMarcajesPorFechaAsync(DateTime fecha);

        /// <summary>
        /// Obtiene todos los marcajes de un empleado en una fecha específica
        /// </summary>
        Task<List<IclockTransaction>> GetMarcajesPorEmpleadoYFechaAsync(int empleadoId, DateTime fecha);

        /// <summary>
        /// Obtiene el historial de marcajes de un empleado en un rango de fechas
        /// </summary>
        Task<List<IclockTransaction>> GetHistorialMarcajesEmpleadoAsync(int empleadoId, DateTime fechaInicio, DateTime fechaFin);

        /// <summary>
        /// Obtiene el conteo de empleados activos
        /// </summary>
        Task<int> GetTotalEmpleadosActivosAsync();

        /// <summary>
        /// Obtiene el conteo de empleados que asistieron en una fecha
        /// </summary>
        Task<int> GetTotalAsistenciasPorFechaAsync(DateTime fecha);

        /// <summary>
        /// Obtiene el conteo de empleados ausentes en una fecha
        /// </summary>
        Task<int> GetTotalAusenciasPorFechaAsync(DateTime fecha);

        /// <summary>
        /// Obtiene el total de marcajes realizados en una fecha
        /// </summary>
        Task<int> GetTotalMarcajesPorFechaAsync(DateTime fecha);

        /// <summary>
        /// Calcula el porcentaje de asistencia para una fecha específica
        /// </summary>
        Task<decimal> GetPorcentajeAsistenciaPorFechaAsync(DateTime fecha);

        /// <summary>
        /// Obtiene el primer marcaje (entrada) de un empleado en una fecha
        /// </summary>
        Task<IclockTransaction?> GetPrimeraEntradaAsync(int empleadoId, DateTime fecha);

        /// <summary>
        /// Obtiene el último marcaje (salida) de un empleado en una fecha
        /// </summary>
        Task<IclockTransaction?> GetUltimaSalidaAsync(int empleadoId, DateTime fecha);

        /// <summary>
        /// Obtiene los empleados agrupados por departamento con su asistencia
        /// </summary>
        Task<Dictionary<string, List<PersonnelEmployee>>> GetAsistenciaPorDepartamentoAsync(DateTime fecha);

        /// <summary>
        /// Obtiene las estadísticas de asistencia por departamento (% de asistencia)
        /// </summary>
        Task<Dictionary<string, decimal>> GetEstadisticasPorDepartamentoAsync(DateTime fecha);

        /// <summary>
        /// Verifica si un empleado específico asistió en una fecha
        /// </summary>
        Task<bool> EmpleadoAsistioAsync(int empleadoId, DateTime fecha);

        /// <summary>
        /// Obtiene el total de marcajes de un empleado en una fecha
        /// </summary>
        Task<int> GetTotalMarcajesEmpleadoAsync(int empleadoId, DateTime fecha);
    }
}