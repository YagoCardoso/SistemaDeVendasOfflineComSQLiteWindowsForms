using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Pdv.Domain.Enums
{
    public enum TipoAcesso
    {
        [Description("Inativo")]
        Inativo = 0,

        [Description("Administrador")]
        Administrador = 1,
        
        [Description("Funcionário")]
        Funcionario = 2
    }
}
