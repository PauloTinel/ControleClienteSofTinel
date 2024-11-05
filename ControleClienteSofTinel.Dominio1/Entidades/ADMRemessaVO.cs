using System;

namespace ControleClienteSofTinel.Dominio.Entidades
{
    public class ADMRemessaVO : CadastroVO
    {
        public int Id { get; set; }
        public string NumeroConvenio{ get; set; }
        public string  Banco { get; set; }
        public int? IdEmpresa { get; set; }      
        public string Beneficiario { get; set; }
        public string CNPJ { get; set; }
        public string Endereco { get; set; }
        public string Agencia { get; set; }
        public string NossoNumero { get; set; }
        public Decimal? ValorDocumento { get; set; }
        public string Boleto { get; set; }
        public int? NumeroArquivoRemessa { get; set; }
        public DateTime DataVencimento { get; set; }
        public string Mensagem { get; set; }
    }
}
