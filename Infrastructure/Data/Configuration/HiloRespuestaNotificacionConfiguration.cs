using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class HiloRespuestaNotificacionConfiguration : IEntityTypeConfiguration<HiloRespuestaNotificacion>
    {
        public void Configure(EntityTypeBuilder<HiloRespuestaNotificacion> builder)
        {
            builder.ToTable("HiloRespuestaNotificacion");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.NombreTipo).IsRequired().HasMaxLength(80);
            builder.Property(x => x.FechaCreacion);
            builder.Property(x => x.FechaModificacion);
        }
    }
}