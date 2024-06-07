using System;
using Pdv.Domain.Enums;

namespace Pdv.Domain.Entidades
{
    public class Endereco
    {
        public Guid Id { get; set; } = new Guid();
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string CodigoCep { get; set; }
        public Uf Uf { get; set; }

        public Endereco(
            string rua, 
            string bairro,
            string cidade,
            string codigoCep,
            Uf uf
        ) 
        {
            Rua = rua;
            Bairro = bairro;
            Cidade = cidade;
            CodigoCep = codigoCep;
            Uf = uf;
        }
    }
}
