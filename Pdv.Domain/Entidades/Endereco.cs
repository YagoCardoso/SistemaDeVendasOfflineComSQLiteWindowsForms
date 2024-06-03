namespace Pdv.Domain.Entidades
{
    public class Endereco
    {
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string CodigoCep { get; set; }
        public string Uf { get; set; }

        public Endereco(
            string rua, 
            string bairro,
            string cidade,
            string codigoCep,
            string uf
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
