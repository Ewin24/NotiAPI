using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Configuration;
public class GenericosVsSubmodulosConfiguration : IEntityTypeConfiguration<GenericosVsSubmodulos>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<GenericosVsSubmodulos> builder)
    {
        builder.ToTable("genericosvssubmodulos");
        
        builder.HasKey(x => x.Id);
        builder.Property(x => x.FechaCreacion);
        builder.Property(x => x.FechaModificacion);

        builder.HasOne(G => G.PermisosGenericos)
        .WithMany(P => P.GenericosVsSubmodulos)
        .HasForeignKey(G => G.idGenericos);

        builder.HasOne(G => G.Roles)
        .WithMany(R => R.GenericosVsSubmodulos)
        .HasForeignKey(G => G.idRol);

        builder.HasOne(G => G.MaestrosVsSubmodulos)
        .WithMany(M => M.GenericosVsSubmodulos)
        .HasForeignKey(G => G.idSubmodulos);
    }
}