using System;
using Flunt.Notifications;

namespace Pdv.Domain.Entidades
{
    public abstract class Pessoa : Notifiable<Notification>
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public Endereco Endereco { get; set; }
        
        public Pessoa(
                string nome,
                string cpf,
                string rg,
                string telefone,
                DateTime dataNascimento,
                Endereco endereco
        )
        {
            if (String.IsNullOrEmpty(nome))
                AddNotification("Pessoa inválido", "É necessário informar o nome.");

            if (String.IsNullOrEmpty(cpf))
                AddNotification("Pessoa inválido", "É necessário informar o cpf.");

            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            Telefone = telefone;
            DataNascimento = dataNascimento;
            Endereco = endereco;
        }
    }
}
