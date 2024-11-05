using System;

namespace ControleClienteSofTinel.Dominio.Entidades
{
    public abstract class CadastroVO
    {
        public virtual DateTime? Cadastro { get; set; }

        public virtual string CadastradoPor { get; set; }

        public virtual DateTime? Edicao { get; set; }

        public virtual string EditadoPor { get; set; }

        public string VersaoRegistro { get; set; }
    }
}
