using Pdv.Domain.Entidades.Funcionario;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pdv.Data.Maps
{
    public class ContaAcessoMap : IEntityTypeConfiguration<ContaAcesso>
    {
        public void Configure(EntityTypeBuilder<ContaAcesso> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}
