using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class EstadoNotificacionConfiguration : IEntityTypeConfiguration<EstadoNotificacion>
{
    public void Configure(EntityTypeBuilder<EstadoNotificacion> builder)
    {
        builder.ToTable("estadonotificacion");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.FechaCreacion);
        builder.Property(x => x.FechaCreacion);
        builder.Property(x => x.Nombreestado).HasMaxLength(50).IsRequired();
    }
}