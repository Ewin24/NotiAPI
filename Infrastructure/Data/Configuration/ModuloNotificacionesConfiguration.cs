using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class ModuloNotificacionesConfiguration : IEntityTypeConfiguration<ModuloNotificaciones>
    {
        public void Configure(EntityTypeBuilder<ModuloNotificaciones> builder)
        {
            builder.ToTable("ModuloNotificaciones");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id");
            builder.Property(x => x.AsuntoNotificacion).HasMaxLength(80).IsRequired();
            builder.Property(x => x.FechaCreacion);
            builder.Property(x => x.FechaModificacion);


            builder.HasOne(M => M.Radicados)
            .WithMany(N => N.ModuloNotificaciones)
            .HasForeignKey(M => M.IdRadicado);

            builder.HasOne(M => M.Formatos)
            .WithMany(F => F.ModuloNotificaciones)
            .HasForeignKey(M => M.IdFormato);

            builder.HasOne(M => M.TipoRequerimientos)
            .WithMany(T => T.ModuloNotificaciones)
            .HasForeignKey(M => M.IdRequerimiento);

            builder.HasOne(M => M.TipoNotificaciones)
            .WithMany(T => T.ModuloNotificaciones)
            .HasForeignKey(M => M.IdTipoNotificacion);

            builder.HasOne(M => M.HiloRespuestaNotificaciones)
            .WithMany(H => H.ModuloNotificaciones)
            .HasForeignKey(M => M.IdhiloRespuesta);

            builder.HasOne(M => M.EstadoNotificaciones)
            .WithMany(E => E.ModuloNotificaciones)
            .HasForeignKey(M => M.IdEstadoNotificacion);
        }
    }
}