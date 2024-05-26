using Pdv.Domain.Entidades;

namespace Pdv.Domain.Repositories
{
    public interface IClienteRepository
    {
        void InserirCliente(Cliente cliente);
        void AlterarCliente(Cliente cliente);
        Cliente ObterCliente(string cpf);        
        void DeleteCliente(string cpf);
    }
}
