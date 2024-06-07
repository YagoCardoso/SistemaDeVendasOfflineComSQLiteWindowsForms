using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pdv.Domain.Entidades;

namespace Pdv.Data.Maps
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Rua).IsRequired().HasMaxLength(100).HasColumnType("varchar(100)");
            builder.Property(e => e.Cidade).IsRequired().HasMaxLength(60).HasColumnType("varchar(60)");
            builder.Property(e => e.Bairro).IsRequired().HasMaxLength(60).HasColumnType("varchar(60)");
            builder.Property(e => e.Uf).IsRequired().HasMaxLength(2).HasColumnType("varchar(2)");
            builder.Property(e => e.CodigoCep).IsRequired().HasMaxLength(8).HasColumnType("varchar(8)");
        }
    }
}
