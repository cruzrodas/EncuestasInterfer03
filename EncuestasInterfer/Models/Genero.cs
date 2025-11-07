using System;
using System.Collections.Generic;

namespace EncuestasInterfer.Models;

public partial class Genero
{
    public int IdGenero { get; set; }

    public string? NombreGenero { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<RespuestaEncuesta> RespuestaEncuesta { get; set; } = new List<RespuestaEncuesta>();
}
