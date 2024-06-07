using System;
using System.Collections.Generic;
using System.Text;

namespace Pdv.Domain.Entidades.Funcionario
{
    public class Funcionario : Pessoa
    {
        public ContaAcesso ContaAcesso { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataAdmissao { get; set; } = DateTime.Now;
        public DateTime? DataDesligamento { get; set; } = null;

        public Funcionario(
            string nome,
            string cpf,
            string rg,
            string telefone,
            DateTime dataNascimento,
            Endereco endereco,
            ContaAcesso contaAcesso,
            decimal salario
        ) : base(nome, cpf, rg, telefone, dataNascimento, endereco)
        {
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            Telefone = telefone;
            DataNascimento = dataNascimento;
            Endereco = endereco;
            ContaAcesso = contaAcesso;
            Salario = salario;
        }
    }
}
