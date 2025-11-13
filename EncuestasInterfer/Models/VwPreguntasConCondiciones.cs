using System;
using System.Collections.Generic;

namespace EncuestasInterfer.Models;

public partial class VwPreguntasConCondiciones
{
    public int IdPregunta { get; set; }

    public int? IdEncuesta { get; set; }

    public string? TextoPregunta { get; set; }

    public int? OrdenPregunta { get; set; }

    public bool? EsCondicional { get; set; }

    public int? PreguntaDestinoSalto { get; set; }

    public int? IdTipoPregunta { get; set; }

    public string? NombreTipoPregunta { get; set; }

    public int? IdOpcionRespuestaCondicion { get; set; }

    public int? IdOpcionRespuesta { get; set; }

    public string? TextoOpcion { get; set; }

    public string? TipoAccion { get; set; }

    public int? IdPreguntaDestino { get; set; }

    public string? TextoPreguntaDestino { get; set; }
}
