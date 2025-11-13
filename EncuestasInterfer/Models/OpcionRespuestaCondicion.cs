using System;
using System.Collections.Generic;

namespace EncuestasInterfer.Models;

public partial class OpcionRespuestaCondicion
{
    public int IdOpcionRespuestaCondicion { get; set; }

    public int IdOpcionRespuesta { get; set; }

    public string TipoAccion { get; set; } = null!;

    public int? IdPreguntaDestino { get; set; }

    public bool? Activa { get; set; }

    public virtual OpcionRespuesta IdOpcionRespuestaNavigation { get; set; } = null!;

    public virtual Pregunta? IdPreguntaDestinoNavigation { get; set; }
}
