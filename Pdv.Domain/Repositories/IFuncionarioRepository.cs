using Pdv.Domain.Entidades.Funcionario;

namespace Pdv.Domain.Repositories
{
    public interface IFuncionarioRepository
    {
        void InserirFuncionario(Funcionario funcionario);
        void AlterarFuncionario(string cpf);
        Funcionario ObterFuncionario(string cpf);
        void DeletarFuncionario(string cpf);
    }
}
