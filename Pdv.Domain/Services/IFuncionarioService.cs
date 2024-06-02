using Pdv.Domain.Entidades.Funcionario;

namespace Pdv.Domain.Services
{
    public interface IFuncionarioService
    {
        void InserirFuncionario(Funcionario funcionario);
        void AlterarFuncionario(string cpf);
        Funcionario ObterFuncionario(string cpf);
        void DeletarFuncionario(string cpf);
    }
}
