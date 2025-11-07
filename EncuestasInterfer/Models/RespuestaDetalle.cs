using System;
using System.Collections.Generic;

namespace EncuestasInterfer.Models;

public partial class RespuestaDetalle
{
    public int IdRespuestaDetalle { get; set; }

    public int IdRespuestaEncuesta { get; set; }

    public int IdPregunta { get; set; }

    public int? ValorNumerico { get; set; }

    public string? ValorTexto { get; set; }

    public int? IdOpcion { get; set; }

    public DateTime? FechaRespuesta { get; set; }

    public virtual OpcionRespuesta? IdOpcionNavigation { get; set; }

    public virtual Pregunta IdPreguntaNavigation { get; set; } = null!;

    public virtual RespuestaEncuesta IdRespuestaEncuestaNavigation { get; set; } = null!;

    public virtual ICollection<RespuestaMultiple> RespuestaMultiple { get; set; } = new List<RespuestaMultiple>();
}
