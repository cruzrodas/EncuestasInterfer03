using EncuestasInterfer.Models;
using Microsoft.EntityFrameworkCore;

namespace EncuestasInterfer.Services.AnalisisEncuestaServices
{
    public class SAnalisisEncuestaService : IAnalisisEncuestaService
    {
        private readonly EncuestaFeriaContext _context;

        public SAnalisisEncuestaService(EncuestaFeriaContext context)
        {
            _context = context;
        }

        public async Task<Dictionary<string, int>> GetRespuestasPorEscalaAsync(int idPregunta)
        {
            var respuestas = await _context.RespuestaDetalle
                .Where(rd => rd.IdPregunta == idPregunta && rd.ValorNumerico.HasValue)
                .GroupBy(rd => rd.ValorNumerico!.Value)
                .Select(g => new { Escala = g.Key, Cantidad = g.Count() })
                .OrderBy(x => x.Escala)
                .ToListAsync();

            return respuestas.ToDictionary(r => $"Escala {r.Escala}", r => r.Cantidad);
        }

        public async Task<Dictionary<string, Dictionary<string, int>>> GetEdadesPorMunicipioAsync(int idEncuesta)
        {
            var respuestas = await _context.RespuestaEncuesta
                .Include(r => r.IdMunicipioNavigation)
                .Where(r => r.IdEncuesta == idEncuesta && r.EdadActual.HasValue)
                .ToListAsync();

            var resultado = new Dictionary<string, Dictionary<string, int>>();

            foreach (var resp in respuestas)
            {
                var rangoEdad = ObtenerRangoEdad(resp.EdadActual!.Value);
                var municipio = resp.IdMunicipioNavigation?.NombreMunicipio ?? "Sin Municipio";

                if (!resultado.ContainsKey(rangoEdad))
                    resultado[rangoEdad] = new Dictionary<string, int>();

                if (!resultado[rangoEdad].ContainsKey(municipio))
                    resultado[rangoEdad][municipio] = 0;

                resultado[rangoEdad][municipio]++;
            }

            return resultado;
        }

        public async Task<Dictionary<string, Dictionary<string, int>>> GetEdadesPorGeneroAsync(int idEncuesta)
        {
            var respuestas = await _context.RespuestaEncuesta
                .Include(r => r.IdGeneroNavigation)
                .Where(r => r.IdEncuesta == idEncuesta && r.EdadActual.HasValue)
                .ToListAsync();

            var resultado = new Dictionary<string, Dictionary<string, int>>();

            foreach (var resp in respuestas)
            {
                var rangoEdad = ObtenerRangoEdad(resp.EdadActual!.Value);
                var genero = resp.IdGeneroNavigation?.NombreGenero ?? "No especificado";

                if (!resultado.ContainsKey(rangoEdad))
                    resultado[rangoEdad] = new Dictionary<string, int>();

                if (!resultado[rangoEdad].ContainsKey(genero))
                    resultado[rangoEdad][genero] = 0;

                resultado[rangoEdad][genero]++;
            }

            return resultado;
        }

        public async Task<Dictionary<string, int>> GetVisitantesPorMunicipioAsync(int idEncuesta)
        {
            var visitantes = await _context.RespuestaEncuesta
                .Include(r => r.IdMunicipioNavigation)
                .Where(r => r.IdEncuesta == idEncuesta)
                .GroupBy(r => r.IdMunicipioNavigation!.NombreMunicipio)
                .Select(g => new { Municipio = g.Key ?? "Sin Municipio", Cantidad = g.Count() })
                .OrderByDescending(x => x.Cantidad)
                .ToListAsync();

            return visitantes.ToDictionary(v => v.Municipio, v => v.Cantidad);
        }

        private string ObtenerRangoEdad(int edad)
        {
            return edad switch
            {
                >= 0 and <= 12 => "Niños (0-12 años)",
                >= 13 and <= 17 => "Adolescentes (13-17 años)",
                >= 18 and <= 24 => "Jóvenes (18-24 años)",
                >= 25 and <= 39 => "Jóvenes adultos (25-39 años)",
                >= 40 and <= 54 => "Adultos (40-54 años)",
                >= 55 and <= 64 => "Adultos mayores (55-64 años)",
                >= 65 and <= 74 => "Ciudadanos de Oro (65-74 años)",
                >= 75 => "Longevos (75+ años)",
                _ => "Sin clasificar"
            };
        }
    }
}