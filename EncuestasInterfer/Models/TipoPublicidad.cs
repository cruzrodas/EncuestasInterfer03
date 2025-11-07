using System;
using System.Collections.Generic;

namespace EncuestasInterfer.Models;

public partial class TipoPublicidad
{
    public int IdTipoPublicidad { get; set; }

    public string? NombreTipoPublicidad { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<RespuestaEncuesta> RespuestaEncuesta { get; set; } = new List<RespuestaEncuesta>();
}
