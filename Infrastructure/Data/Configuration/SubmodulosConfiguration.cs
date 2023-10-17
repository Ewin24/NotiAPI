using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class SubmodulosConfiguration : IEntityTypeConfiguration<SubModulos>
{
    public void Configure(EntityTypeBuilder<SubModulos> builder)
    {
        builder.ToTable("submodulos");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.NombreSubmodulo);
        builder.Property(x => x.FechaCreacion);
        builder.Property(x => x.FechaModificacion);

        builder.Property(x => x.Id).HasColumnName("id");
    }
}