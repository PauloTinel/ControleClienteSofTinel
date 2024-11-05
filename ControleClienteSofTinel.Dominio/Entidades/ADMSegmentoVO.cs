using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ControleClienteSofTinel.Dominio.Entidades;

namespace ControleClienteSofTinel.Dominio.Entidades
{
    public class ADMSegmentoVO : CadastroVO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Ativo { get; set; }
    }
    
}
