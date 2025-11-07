using System;
using System.Collections.Generic;

namespace EncuestasInterfer.Models;

public partial class TipoIdentificacion
{
    public int IdTipoIdentificacion { get; set; }

    public string? NombreIdentificacion { get; set; }

    public string? DescripcionIdentificacion { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<RespuestaEncuesta> RespuestaEncuesta { get; set; } = new List<RespuestaEncuesta>();
}
