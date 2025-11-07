using System;
using System.Collections.Generic;

namespace EncuestasInterfer.Models;

public partial class RespuestaEncuesta
{
    public int IdRespuestaEncuesta { get; set; }

    public int? IdEncuesta { get; set; }

    public int? IdTipoDocuementoIdentificacion { get; set; }

    public string? NumeroIdentificacion { get; set; }

    public int? EdadActual { get; set; }

    public int? IdGenero { get; set; }

    public int? IdNacionalidad { get; set; }

    public int? IdDepartamento { get; set; }

    public int? IdMunicipio { get; set; }

    public string? Direccion { get; set; }

    public int? IdTipoPublicidad { get; set; }

    public int? IdTiposCompra { get; set; }

    public int? IdMotivoVisita { get; set; }

    public DateTime? FechaRealizacion { get; set; }

    public virtual Departamento? IdDepartamentoNavigation { get; set; }

    public virtual Encuesta? IdEncuestaNavigation { get; set; }

    public virtual Genero? IdGeneroNavigation { get; set; }

    public virtual MotivoVisita? IdMotivoVisitaNavigation { get; set; }

    public virtual Municipio? IdMunicipioNavigation { get; set; }

    public virtual Nacionalidad? IdNacionalidadNavigation { get; set; }

    public virtual TipoIdentificacion? IdTipoDocuementoIdentificacionNavigation { get; set; }

    public virtual TipoPublicidad? IdTipoPublicidadNavigation { get; set; }

    public virtual TiposCompra? IdTiposCompraNavigation { get; set; }

    public virtual ICollection<RespuestaDetalle> RespuestaDetalle { get; set; } = new List<RespuestaDetalle>();
}
