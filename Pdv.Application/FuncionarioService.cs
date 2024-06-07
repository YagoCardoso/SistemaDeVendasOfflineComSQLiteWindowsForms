using Pdv.Domain.Entidades.Funcionario;
using Pdv.Domain.Repositories;
using Pdv.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pdv.Application
{
    public class FuncionarioService : IFuncionarioService
    {
        private readonly IFuncionarioRepository _funcionarioRepository;

        public FuncionarioService(IFuncionarioRepository funcionarioRepository)
        { 
            this._funcionarioRepository = funcionarioRepository;
        }

        public void AlterarFuncionario(string cpf)
        {
            throw new NotImplementedException();
        }

        public void DeletarFuncionario(string cpf)
        {
            throw new NotImplementedException();
        }

        public void InserirFuncionario(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

        public Funcionario ObterFuncionario(string cpf)
        {
            throw new NotImplementedException();
        }
    }
}
