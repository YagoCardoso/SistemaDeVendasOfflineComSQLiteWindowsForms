using Pdv.Data.Maps;
using Pdv.Domain.Entidades;
using Pdv.Domain.Entidades.Funcionario;
using Pdv.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace Pdv.Data
{
    public class StoreDataContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<ContaAcesso> ContasAcesso { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PessoaMap());
            modelBuilder.ApplyConfiguration(new EnderecoMap());
            modelBuilder.ApplyConfiguration(new FuncionarioMap());
            modelBuilder.ApplyConfiguration(new ContaAcessoMap());
            
        }
    }
}
