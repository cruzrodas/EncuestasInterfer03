using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EncuestasInterfer.Models;

public partial class EncuestaFeriaContext : DbContext
{
    public EncuestaFeriaContext()
    {
    }

    public EncuestaFeriaContext(DbContextOptions<EncuestaFeriaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Departamento> Departamento { get; set; }

    public virtual DbSet<Encuesta> Encuesta { get; set; }

    public virtual DbSet<Genero> Genero { get; set; }

    public virtual DbSet<Municipio> Municipio { get; set; }

    public virtual DbSet<Nacionalidad> Nacionalidad { get; set; }

    public virtual DbSet<OpcionRespuesta> OpcionRespuesta { get; set; }

    public virtual DbSet<OpcionRespuestaCondicion> OpcionRespuestaCondicion { get; set; }

    public virtual DbSet<Pregunta> Pregunta { get; set; }

    public virtual DbSet<RespuestaDetalle> RespuestaDetalle { get; set; }

    public virtual DbSet<RespuestaEncuesta> RespuestaEncuesta { get; set; }

    public virtual DbSet<RespuestaMultiple> RespuestaMultiple { get; set; }

    public virtual DbSet<TipoIdentificacion> TipoIdentificacion { get; set; }

    public virtual DbSet<TipoPregunta> TipoPregunta { get; set; }

    public virtual DbSet<VwPreguntasConCondiciones> VwPreguntasConCondiciones { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.HasKey(e => e.IdDepartamento);

            entity.Property(e => e.NombreDepartamento).HasMaxLength(150);

            entity.HasOne(d => d.IdNacionalidadNavigation).WithMany(p => p.Departamento)
                .HasForeignKey(d => d.IdNacionalidad)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Departamento_Nacionalidad");
        });

        modelBuilder.Entity<Encuesta>(entity =>
        {
            entity.HasKey(e => e.IdEncuesta);

            entity.Property(e => e.FechaActualiacion).HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FechaFin).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.Titulo).HasMaxLength(250);
        });

        modelBuilder.Entity<Genero>(entity =>
        {
            entity.HasKey(e => e.IdGenero);

            entity.Property(e => e.NombreGenero).HasMaxLength(50);
        });

        modelBuilder.Entity<Municipio>(entity =>
        {
            entity.HasKey(e => e.IdMunicipio);

            entity.HasIndex(e => e.IdDepartamento, "IX_Municipio_Departamento");

            entity.Property(e => e.NombreMunicipio).HasMaxLength(150);

            entity.HasOne(d => d.IdDepartamentoNavigation).WithMany(p => p.Municipio)
                .HasForeignKey(d => d.IdDepartamento)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Municipio_Departamento");
        });

        modelBuilder.Entity<Nacionalidad>(entity =>
        {
            entity.HasKey(e => e.IdNacionalidad);

            entity.Property(e => e.NombrePais).HasMaxLength(150);
        });

        modelBuilder.Entity<OpcionRespuesta>(entity =>
        {
            entity.HasKey(e => e.IdOpcionRespuesta);

            entity.Property(e => e.TextoOpcion).HasMaxLength(255);

            entity.HasOne(d => d.IdPreguntaNavigation).WithMany(p => p.OpcionRespuesta)
                .HasForeignKey(d => d.IdPregunta)
                .HasConstraintName("FK_OpcionRespuesta_Pregunta");
        });

        modelBuilder.Entity<OpcionRespuestaCondicion>(entity =>
        {
            entity.HasKey(e => e.IdOpcionRespuestaCondicion).HasName("PK__OpcionRe__B81DD5AE9C26FE73");

            entity.HasIndex(e => e.IdOpcionRespuesta, "IX_OpcionRespuestaCondicion_Opcion");

            entity.Property(e => e.Activa).HasDefaultValue(true);
            entity.Property(e => e.TipoAccion)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdOpcionRespuestaNavigation).WithMany(p => p.OpcionRespuestaCondicion)
                .HasForeignKey(d => d.IdOpcionRespuesta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OpcionRespuestaCondicion_OpcionRespuesta");

            entity.HasOne(d => d.IdPreguntaDestinoNavigation).WithMany(p => p.OpcionRespuestaCondicion)
                .HasForeignKey(d => d.IdPreguntaDestino)
                .HasConstraintName("FK_OpcionRespuestaCondicion_PreguntaDestino");
        });

        modelBuilder.Entity<Pregunta>(entity =>
        {
            entity.HasKey(e => e.IdPregunta);

            entity.HasIndex(e => new { e.IdEncuesta, e.OrdenPregunta }, "IX_Pregunta_OrdenPregunta");

            entity.Property(e => e.EsCondicional).HasDefaultValue(false);
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.TextoPregunta).HasMaxLength(500);

            entity.HasOne(d => d.IdEncuestaNavigation).WithMany(p => p.Pregunta)
                .HasForeignKey(d => d.IdEncuesta)
                .HasConstraintName("FK_Pregunta_Encuesta");

            entity.HasOne(d => d.IdTipoPreguntaNavigation).WithMany(p => p.Pregunta)
                .HasForeignKey(d => d.IdTipoPregunta)
                .HasConstraintName("FK_Pregunta_TipoPregunta");
        });

        modelBuilder.Entity<RespuestaDetalle>(entity =>
        {
            entity.HasKey(e => e.IdRespuestaDetalle);

            entity.Property(e => e.FechaRespuesta)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.IdOpcionNavigation).WithMany(p => p.RespuestaDetalle)
                .HasForeignKey(d => d.IdOpcion)
                .HasConstraintName("FK_RespuestaDetalle_OpcionRespuesta");

            entity.HasOne(d => d.IdPreguntaNavigation).WithMany(p => p.RespuestaDetalle)
                .HasForeignKey(d => d.IdPregunta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RespuestaDetalle_Pregunta");

            entity.HasOne(d => d.IdRespuestaEncuestaNavigation).WithMany(p => p.RespuestaDetalle)
                .HasForeignKey(d => d.IdRespuestaEncuesta)
                .HasConstraintName("FK_RespuestaDetalle_RespuestaEncuesta");
        });

        modelBuilder.Entity<RespuestaEncuesta>(entity =>
        {
            entity.HasKey(e => e.IdRespuestaEncuesta);

            entity.Property(e => e.FechaRealizacion).HasColumnType("datetime");
            entity.Property(e => e.NumeroIdentificacion).HasMaxLength(50);

            entity.HasOne(d => d.IdDepartamentoNavigation).WithMany(p => p.RespuestaEncuesta)
                .HasForeignKey(d => d.IdDepartamento)
                .HasConstraintName("FK_RespuestaEncuesta_Departamento");

            entity.HasOne(d => d.IdEncuestaNavigation).WithMany(p => p.RespuestaEncuesta)
                .HasForeignKey(d => d.IdEncuesta)
                .HasConstraintName("FK_RespuestaEncuesta_Encuesta");

            entity.HasOne(d => d.IdGeneroNavigation).WithMany(p => p.RespuestaEncuesta)
                .HasForeignKey(d => d.IdGenero)
                .HasConstraintName("FK_RespuestaEncuesta_Genero");

            entity.HasOne(d => d.IdMunicipioNavigation).WithMany(p => p.RespuestaEncuesta)
                .HasForeignKey(d => d.IdMunicipio)
                .HasConstraintName("FK_RespuestaEncuesta_Municipio");

            entity.HasOne(d => d.IdNacionalidadNavigation).WithMany(p => p.RespuestaEncuesta)
                .HasForeignKey(d => d.IdNacionalidad)
                .HasConstraintName("FK_RespuestaEncuesta_Nacionalidad");

            entity.HasOne(d => d.IdTipoDocuementoIdentificacionNavigation).WithMany(p => p.RespuestaEncuesta)
                .HasForeignKey(d => d.IdTipoDocuementoIdentificacion)
                .HasConstraintName("FK_RespuestaEncuesta_Tipo_Identificacion");
        });

        modelBuilder.Entity<RespuestaMultiple>(entity =>
        {
            entity.HasKey(e => e.IdRespuestaMultiple);

            entity.HasIndex(e => new { e.IdRespuestaDetalle, e.IdOpcion }, "UQ_RespuestaMultiple_Unica").IsUnique();

            entity.HasOne(d => d.IdOpcionNavigation).WithMany(p => p.RespuestaMultiple)
                .HasForeignKey(d => d.IdOpcion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RespuestaMultiple_OpcionRespuesta");

            entity.HasOne(d => d.IdRespuestaDetalleNavigation).WithMany(p => p.RespuestaMultiple)
                .HasForeignKey(d => d.IdRespuestaDetalle)
                .HasConstraintName("FK_RespuestaMultiple_RespuestaDetalle");
        });

        modelBuilder.Entity<TipoIdentificacion>(entity =>
        {
            entity.HasKey(e => e.IdTipoIdentificacion);

            entity.ToTable("Tipo_Identificacion");

            entity.Property(e => e.DescripcionIdentificacion).HasMaxLength(250);
            entity.Property(e => e.NombreIdentificacion).HasMaxLength(100);
        });

        modelBuilder.Entity<TipoPregunta>(entity =>
        {
            entity.HasKey(e => e.IdTipoPregunta);

            entity.Property(e => e.Descripcion).HasMaxLength(255);
            entity.Property(e => e.NombreTipoPregunta).HasMaxLength(100);
        });

        modelBuilder.Entity<VwPreguntasConCondiciones>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_PreguntasConCondiciones");

            entity.Property(e => e.NombreTipoPregunta).HasMaxLength(100);
            entity.Property(e => e.TextoOpcion).HasMaxLength(255);
            entity.Property(e => e.TextoPregunta).HasMaxLength(500);
            entity.Property(e => e.TextoPreguntaDestino).HasMaxLength(500);
            entity.Property(e => e.TipoAccion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
