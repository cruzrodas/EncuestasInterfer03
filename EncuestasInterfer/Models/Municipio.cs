using System;
using System.Collections.Generic;

namespace EncuestasInterfer.Models;

public partial class Municipio
{
    public int IdMunicipio { get; set; }

    public string? NombreMunicipio { get; set; }

    public bool? Activo { get; set; }

    public int? IdDepartamento { get; set; }

    public virtual Departamento? IdDepartamentoNavigation { get; set; }

    public virtual ICollection<RespuestaEncuesta> RespuestaEncuesta { get; set; } = new List<RespuestaEncuesta>();
}
