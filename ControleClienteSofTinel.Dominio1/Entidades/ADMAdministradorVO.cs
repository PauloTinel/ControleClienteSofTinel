using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace ControleClienteSofTinel.Dominio.Entidades
{
    public class ADMAdministradorVO : CadastroVO    
    {
        public int Id { get; set; }
              
        [Required]
        public string Nome { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido.")]
        public string Email { get; set; }        

        [Required]
        public string Senha { get; set; }

        [Required]
        public string SenhaRed { get; set; }

        public int? Status { get; set; }
        public string Codigo { get; set; }
        public string Ativo { get; set; }
    }
    public class AdministradorMap : IEntityTypeConfiguration<ADMAdministradorVO>
    {
        public void Configure(EntityTypeBuilder<ADMAdministradorVO> builder)
        {
            builder
                  .Property(p => p.Id)
                  .HasColumnType("INT");
            builder
                  .Property(p => p.Status)
                  .HasColumnType("INT");
            builder
                .Property(p => p.Codigo)
                .HasColumnType("CHAR(10)")
                .IsRequired();
            builder
                .Property(p => p.Nome)
                .HasColumnType("VARCHAR(50)")
                .IsRequired();
            builder
                .Property(p => p.Email)
                .HasColumnType("VARCHAR(150)");
            builder
                .Property(p => p.Senha)
                .HasColumnType("VARCHAR(20)");
            builder
                .Property(p => p.SenhaRed)
                .HasColumnType("VARCHAR(20)");
            builder
                .Property(p => p.Ativo)
                .HasColumnType("CHAR(10)")
                .IsRequired();
            builder
                .Property(p => p.CadastradoPor)
                .HasColumnType("VARCHAR(50)");
            builder
                .Property(p => p.EditadoPor)
                .HasColumnType("VARCHAR(50)");

            builder
                .Property(p => p.VersaoRegistro)
                .IsConcurrencyToken();
        }
    }
}

