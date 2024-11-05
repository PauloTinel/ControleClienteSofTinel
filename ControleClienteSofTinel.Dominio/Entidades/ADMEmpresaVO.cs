using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ControleClienteSofTinel.Dominio.Entidades;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleClienteSofTinel.Dominio.Entidades
{
    public class ADMEmpresaVO : CadastroVO
    {
        public int Id { get; set; }

        public string Codigo { get; set; }

        public string RazaoSocial { get; set; }

        public string NomeFantasia { get; set; }

        public string CNPJ { get; set; }

        public string Email { get; set; }

        public string Responsavel { get; set; }

        public string Telefone { get; set; }

        public string Celular { get; set; }

        public string HoraAbertura { get; set; }

        public string AberturaInicial { get; set; }

        public string AberturaFinal { get; set; }

        public string HoraFechamento { get; set; }

        public string ImageLogotipo { get; set; }

        public string Ativo { get; set; }
        public string rua { get; set; }

        public string cep { get; set; }

        public string bairro { get; set; }

        public string cidade { get; set; }

        public int Numero { get; set; }
        public string Complemento { get; set; }

        public string uf { get; set; }

        [ForeignKey("Segmento")]
        public int? IdSegmento { get; set; }
        public virtual ADMSegmentoVO Segmento { get; set; }

        [ForeignKey("Plano")]
        public int? IdPlano { get; set; }
        public virtual ADMPlanoVO Plano { get; set; }

        public double? LimiteDistanciaEntrega { get; set; }

        [DataType(DataType.Currency, ErrorMessage = "Valor deve ser uma quantia de dinheiro válida")]
        [Range(0.01, 9999.00)]

        public decimal ValorComissao { get; set; }

        public double? Latitude { get; set; }

        public double? Longitude { get; set; }
    }

}

