using System;
using System.Collections.Generic;

namespace EncuestasInterfer.Models;

public partial class OpcionRespuesta
{
    public int IdOpcionRespuesta { get; set; }

    public int? IdPregunta { get; set; }

    public string? TextoOpcion { get; set; }

    public int? ValorNumerico { get; set; }

    public bool? Activa { get; set; }

    public virtual Pregunta? IdPreguntaNavigation { get; set; }

    public virtual ICollection<RespuestaDetalle> RespuestaDetalle { get; set; } = new List<RespuestaDetalle>();

    public virtual ICollection<RespuestaMultiple> RespuestaMultiple { get; set; } = new List<RespuestaMultiple>();
}
