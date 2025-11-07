using System;
using System.Collections.Generic;

namespace EncuestasInterfer.Models;

public partial class MotivoVisita
{
    public int IdMotivoVisita { get; set; }

    public string? NombreMotivo { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<RespuestaEncuesta> RespuestaEncuesta { get; set; } = new List<RespuestaEncuesta>();
}
