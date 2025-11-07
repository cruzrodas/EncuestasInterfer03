using System;
using System.Collections.Generic;

namespace EncuestasInterfer.Models;

public partial class Departamento
{
    public int IdDepartamento { get; set; }

    public string? NombreDepartamento { get; set; }

    public bool? Activo { get; set; }

    public int? IdNacionalidad { get; set; }

    public virtual Nacionalidad? IdNacionalidadNavigation { get; set; }

    public virtual ICollection<Municipio> Municipio { get; set; } = new List<Municipio>();

    public virtual ICollection<RespuestaEncuesta> RespuestaEncuesta { get; set; } = new List<RespuestaEncuesta>();
}
