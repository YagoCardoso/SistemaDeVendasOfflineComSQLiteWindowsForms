using Pdv.Domain.Entidades;
using Pdv.Domain.Repositories;

namespace Pdv.Domain.Services
{
    public interface IClienteService
    {
        void InserirCliente(Cliente cliente);
        Cliente ObterCliente(string cpf);
    }
}
