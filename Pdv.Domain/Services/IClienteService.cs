using Pdv.Domain.Entidades;
using Pdv.Domain.Repositories;

namespace Pdv.Domain.Services
{
    public interface IClienteService
    {
        void AlterarCliente(Cliente cliente);
        void DeletarCliente(string cpf);
        void InserirCliente(Cliente cliente);
        Cliente ObterCliente(string cpf);
    }
}
