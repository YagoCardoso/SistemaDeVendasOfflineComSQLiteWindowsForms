using System;
using Flunt.Notifications;

namespace Pdv.Domain.Entidades
{
    public class Cliente : Notifiable<Notification>
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public Endereco Endereco { get; set; }
        
        public Cliente(
                string nome,
                string cpf,
                string rg,
                string telefone,
                DateTime dataNascimento,
                Endereco endereco
        )
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
