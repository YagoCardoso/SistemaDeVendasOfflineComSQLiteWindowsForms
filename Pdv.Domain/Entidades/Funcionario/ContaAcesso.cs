using Pdv.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pdv.Domain.Entidades.Funcionario
{
    public abstract class ContaAcesso
    {
        public string Usuario {  get; set; }
        public string Senha { get; set; }
        public TipoAcesso TipoAcesso { get; set; } = TipoAcesso.Funcionario;
    }
}
