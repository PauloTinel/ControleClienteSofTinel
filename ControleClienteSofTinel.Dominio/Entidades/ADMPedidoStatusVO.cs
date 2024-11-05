using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ControleClienteSofTinel.Dominio.Entidades;
using System.ComponentModel.DataAnnotations;

namespace ControleClienteSofTinel.Dominio.Entidades
{
    public class ADMPedidoStatusVO : CadastroVO
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }

        public string Descricao { get; set; }
    }

    public class ADMPlanoMap : IEntityTypeConfiguration<ADMPlanoVO>
    {
        public void Configure(EntityTypeBuilder<ADMPlanoVO> modelBuilder)
        {
            modelBuilder
                .HasKey(k => k.Id);

            modelBuilder
                .Property(p => p.Nome)
                .HasMaxLength(60)
                .IsRequired();

            modelBuilder
                .Property(p => p.Descricao)
                .HasMaxLength(255);

            modelBuilder
                .Property(p => p.VersaoRegistro)
                .IsConcurrencyToken();

            modelBuilder
                .Property(p => p.CadastradoPor)
                .HasMaxLength(1000);

            modelBuilder
                .Property(p => p.EditadoPor)
                .HasMaxLength(1000);

            modelBuilder
                .Property(p => p.Ativo)
                .HasMaxLength(30);
        }
    }
}

