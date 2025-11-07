using System;
using System.Collections.Generic;

namespace EncuestasInterfer.Models;

public partial class Encuesta
{
    public int IdEncuesta { get; set; }

    public string? Titulo { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaFin { get; set; }

    public bool? Activa { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaActualiacion { get; set; }

    public virtual ICollection<Pregunta> Pregunta { get; set; } = new List<Pregunta>();

    public virtual ICollection<RespuestaEncuesta> RespuestaEncuesta { get; set; } = new List<RespuestaEncuesta>();
}
