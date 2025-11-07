using System;
using System.Collections.Generic;

namespace EncuestasInterfer.Models;

public partial class RespuestaMultiple
{
    public int IdRespuestaMultiple { get; set; }

    public int IdRespuestaDetalle { get; set; }

    public int IdOpcion { get; set; }

    public virtual OpcionRespuesta IdOpcionNavigation { get; set; } = null!;

    public virtual RespuestaDetalle IdRespuestaDetalleNavigation { get; set; } = null!;
}
