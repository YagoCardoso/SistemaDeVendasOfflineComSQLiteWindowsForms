using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pdv.Domain.Entidades;

namespace Pdv.Data.Maps
{
    public class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("Pessoa");
            builder.HasKey(x => x.Cpf);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(255).HasColumnType("varchar(255)");
            builder.Property(x => x.Rg).HasMaxLength(9).HasColumnType("varchar(9)");
            builder.Property(x => x.Telefone).IsRequired().HasMaxLength(11).HasColumnType("varchar(11)");
            builder.Property(x => x.DataNascimento).IsRequired().HasColumnType("datetime");
            //builder.HasOne(x => x.Endereco).WithMany(x => x.);
            //Link the Id of address with this entity --- IdAddress
        }
    }
}