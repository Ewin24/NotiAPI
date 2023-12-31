using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class RolvsMaestroConfiguration : IEntityTypeConfiguration<RolvsMaestro>
{
    public void Configure(EntityTypeBuilder<RolvsMaestro> builder)
    {
        builder.ToTable("rolvsmaestro");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.FechaCreacion);
        builder.Property(x => x.FechaModificacion);

        builder.HasOne(R => R.ModulosMaestros)
        .WithMany(M => M.RolvsMaestros)
        .HasForeignKey(R => R.IdMaestro);

        builder.HasOne(R => R.Roles)
        .WithMany(R => R.RolVsMaestros)
        .HasForeignKey(R => R.IdRol);
    }
}