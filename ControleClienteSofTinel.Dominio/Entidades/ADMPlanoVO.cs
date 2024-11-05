using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ControleClienteSofTinel.Dominio.Entidades;

namespace ControleClienteSofTinel.Dominio.Entidades
{
    public class ADMPlanoVO : CadastroVO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Ativo { get; set; }
    }
  
}

