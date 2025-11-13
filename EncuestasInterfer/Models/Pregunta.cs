using System;
using System.Collections.Generic;

namespace EncuestasInterfer.Models;

public partial class Pregunta
{
    public int IdPregunta { get; set; }

    public int? IdEncuesta { get; set; }

    public int? IdTipoPregunta { get; set; }

    public string? TextoPregunta { get; set; }

    public bool? Activa { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public int? OrdenPregunta { get; set; }

    public bool? EsCondicional { get; set; }

    public int? PreguntaDestinoSalto { get; set; }

    public virtual Encuesta? IdEncuestaNavigation { get; set; }

    public virtual TipoPregunta? IdTipoPreguntaNavigation { get; set; }

    public virtual ICollection<OpcionRespuesta> OpcionRespuesta { get; set; } = new List<OpcionRespuesta>();

    public virtual ICollection<OpcionRespuestaCondicion> OpcionRespuestaCondicion { get; set; } = new List<OpcionRespuestaCondicion>();

    public virtual ICollection<RespuestaDetalle> RespuestaDetalle { get; set; } = new List<RespuestaDetalle>();
}
