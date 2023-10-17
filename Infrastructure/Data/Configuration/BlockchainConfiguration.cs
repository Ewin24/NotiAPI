using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class BlockchainConfiguration : IEntityTypeConfiguration<BlockChain>
{
    public void Configure(EntityTypeBuilder<BlockChain> builder)
    {
        builder.ToTable("Blockchain");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnName("Id");

        builder.Property(x => x.IdAuditoria).IsRequired();
        builder.Property(x => x.HashGenerado).HasMaxLength(100);
        builder.Property(x => x.FechaCreacion);
        builder.Property(x => x.FechaModificacion);

        builder.HasOne(A => A.Auditoria)
        .WithMany(A => A.blockChains)
        .HasForeignKey(A => A.IdAuditoria);

        builder.HasOne(T => T.TipoNotificaciones)
        .WithMany(T => T.BlockChains)
        .HasForeignKey(T => T.IdTipoNotificaciones);

        builder.HasOne(H => H.HiloRespuestaNotificacion)
        .WithMany(H => H.BlockChains)
        .HasForeignKey(H => H.IdHiloRespuesta);
    }
}