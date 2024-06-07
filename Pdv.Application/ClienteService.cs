using System;
using Flunt.Notifications;
using Pdv.Domain.Entidades;
using Pdv.Domain.Repositories;
using Pdv.Domain.Services;
namespace Pdv.Application
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository) 
        { 
            _clienteRepository = clienteRepository;
        }

        public void AlterarCliente(Cliente cliente)
        {
            _clienteRepository.AlterarCliente(cliente);
        }

        public void DeletarCliente(string cpf)
        {
            _clienteRepository.DeleteCliente(cpf);
        }

        public void InserirCliente(Cliente cliente)
        {
            _clienteRepository.InserirCliente(cliente);
        }

        public Cliente ObterCliente(string cpf)
        {
            return _clienteRepository.ObterCliente(cpf);
        }
    }
}
