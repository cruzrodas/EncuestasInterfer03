using System;
using System.Collections.Generic;

namespace EncuestasInterfer.Models;

public partial class TipoPregunta
{
    public int IdTipoPregunta { get; set; }

    public string? NombreTipoPregunta { get; set; }

    public string? Descripcion { get; set; }

    public bool? RequiereOpciones { get; set; }

    public bool? PermiteMultiple { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<Pregunta> Pregunta { get; set; } = new List<Pregunta>();
}
