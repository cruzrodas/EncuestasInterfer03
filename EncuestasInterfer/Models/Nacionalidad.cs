using System;
using System.Collections.Generic;

namespace EncuestasInterfer.Models;

public partial class Nacionalidad
{
    public int IdNacionalidad { get; set; }

    public string? NombrePais { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<Departamento> Departamento { get; set; } = new List<Departamento>();

    public virtual ICollection<RespuestaEncuesta> RespuestaEncuesta { get; set; } = new List<RespuestaEncuesta>();
}
