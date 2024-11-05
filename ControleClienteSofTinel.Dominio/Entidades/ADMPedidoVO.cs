using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ControleClienteSofTinel.Dominio.Entidades;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleClienteSofTinel.Dominio.Entidades
{
    public class ADMPedidoVO : CadastroVO
    {
        public int Id { get; set; }
        public string NrPedido { get; set; }

        [ForeignKey("Empresa")]
        public int? IdEmpresa { get; set; }
        public virtual ADMEmpresaVO Empresa { get; set; }

        [ForeignKey("Segmento")]
        public int? IdSegmento { get; set; }
        public virtual ADMSegmentoVO Segmento { get; set; }

        [ForeignKey("Plano")]
        public int? IdPlano { get; set; }
        public virtual ADMPlanoVO Plano { get; set; }

        [ForeignKey("PedidoStatus")]
        public int? IdPedidoStatus { get; set; }
        public virtual ADMPedidoStatusVO ADMPedidoStatus { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime? DataCadastro { get; set; }
        public Decimal? ValorPedido { get; set; }
        public Decimal? ValorDesconto { get; set; }
        public Decimal? ValorTotal { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime? DataPrevPagto { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime? DataPagto { get; set; }

        //Ignoraveis
        public int? nDia { get; set; }
        public int? nMes { get; set; }        
    }
}
