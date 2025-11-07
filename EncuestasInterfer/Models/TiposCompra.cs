using System;
using System.Collections.Generic;

namespace EncuestasInterfer.Models;

public partial class TiposCompra
{
    public int IdTipoCompra { get; set; }

    public string? NombreTipoCompra { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<RespuestaEncuesta> RespuestaEncuesta { get; set; } = new List<RespuestaEncuesta>();
}
