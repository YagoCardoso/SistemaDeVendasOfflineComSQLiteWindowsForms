using System;
using System.Collections.Generic;
using System.Text;

namespace Pdv.Domain.Entidades
{
    public class Cliente : Pessoa
    {
        public Cliente(
            string nome, 
            string cpf, 
            string rg, 
            string telefone, 
            DateTime dataNascimento, 
            Endereco endereco) 
        : base(nome, cpf, rg, telefone, dataNascimento, endereco)
        {
            if (String.IsNullOrEmpty(nome))
                AddNotification("Cliente inválido", "É necessário informar o nome.");

            if (String.IsNullOrEmpty(cpf))
                AddNotification("Cliente inválido", "É necessário informar o cpf.");

            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            Telefone = telefone;
            DataNascimento = dataNascimento;
            Endereco = endereco;
        }
    }
}
