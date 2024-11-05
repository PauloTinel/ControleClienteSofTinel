﻿// <auto-generated />
using System;
using ControleClienteSofTinel.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ControleClienteSofTinel.Data.Migrations
{
    [DbContext(typeof(SvaContext))]
    [Migration("20241105170103__bv11")]
    partial class _bv11
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ControleClienteSofTinel.Dominio.Entidades.ADMAdministradorVO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ativo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CadastradoPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Cadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Edicao")
                        .HasColumnType("datetime2");

                    b.Property<string>("EditadoPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Perfil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SenhaRed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<string>("VersaoRegistro")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ADMAdministrador");
                });

            modelBuilder.Entity("ControleClienteSofTinel.Dominio.Entidades.ADMEmpresaVO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AberturaFinal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AberturaInicial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("CNPJ")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CadastradoPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Cadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Edicao")
                        .HasColumnType("datetime2");

                    b.Property<string>("EditadoPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoraAbertura")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoraFechamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdPlano")
                        .HasColumnType("int");

                    b.Property<int?>("IdSegmento")
                        .HasColumnType("int");

                    b.Property<string>("ImageLogotipo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Latitude")
                        .HasColumnType("float");

                    b.Property<double?>("LimiteDistanciaEntrega")
                        .HasColumnType("float");

                    b.Property<double?>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("NomeFantasia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("RazaoSocial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Responsavel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ValorComissao")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("VersaoRegistro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rua")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("uf")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdPlano");

                    b.HasIndex("IdSegmento");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("ControleClienteSofTinel.Dominio.Entidades.ADMPedidoStatusVO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CadastradoPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Cadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Edicao")
                        .HasColumnType("datetime2");

                    b.Property<string>("EditadoPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VersaoRegistro")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PedidoStatus");
                });

            modelBuilder.Entity("ControleClienteSofTinel.Dominio.Entidades.ADMPedidoVO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ADMPedidoStatusId")
                        .HasColumnType("int");

                    b.Property<string>("CadastradoPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Cadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataPagto")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataPrevPagto")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Edicao")
                        .HasColumnType("datetime2");

                    b.Property<string>("EditadoPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdEmpresa")
                        .HasColumnType("int");

                    b.Property<int?>("IdPedidoStatus")
                        .HasColumnType("int");

                    b.Property<int?>("IdPlano")
                        .HasColumnType("int");

                    b.Property<int?>("IdSegmento")
                        .HasColumnType("int");

                    b.Property<string>("NrPedido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("ValorDesconto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ValorPedido")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ValorTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("VersaoRegistro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("nDia")
                        .HasColumnType("int");

                    b.Property<int?>("nMes")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ADMPedidoStatusId");

                    b.HasIndex("IdEmpresa");

                    b.HasIndex("IdPlano");

                    b.HasIndex("IdSegmento");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("ControleClienteSofTinel.Dominio.Entidades.ADMPlanoVO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ativo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CadastradoPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Cadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Edicao")
                        .HasColumnType("datetime2");

                    b.Property<string>("EditadoPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VersaoRegistro")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Plano");
                });

            modelBuilder.Entity("ControleClienteSofTinel.Dominio.Entidades.ADMRemessaVO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Agencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Banco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Beneficiario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Boleto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CNPJ")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CadastradoPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Cadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataVencimento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Edicao")
                        .HasColumnType("datetime2");

                    b.Property<string>("EditadoPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdEmpresa")
                        .HasColumnType("int");

                    b.Property<string>("Mensagem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NossoNumero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NumeroArquivoRemessa")
                        .HasColumnType("int");

                    b.Property<string>("NumeroConvenio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("ValorDocumento")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("VersaoRegistro")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Remessas");
                });

            modelBuilder.Entity("ControleClienteSofTinel.Dominio.Entidades.ADMSegmentoVO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ativo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CadastradoPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Cadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Edicao")
                        .HasColumnType("datetime2");

                    b.Property<string>("EditadoPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VersaoRegistro")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Segmento");
                });

            modelBuilder.Entity("ControleClienteSofTinel.Dominio.Identity.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ControleClienteSofTinel.Dominio.Entidades.ADMEmpresaVO", b =>
                {
                    b.HasOne("ControleClienteSofTinel.Dominio.Entidades.ADMPlanoVO", "Plano")
                        .WithMany()
                        .HasForeignKey("IdPlano");

                    b.HasOne("ControleClienteSofTinel.Dominio.Entidades.ADMSegmentoVO", "Segmento")
                        .WithMany()
                        .HasForeignKey("IdSegmento");
                });

            modelBuilder.Entity("ControleClienteSofTinel.Dominio.Entidades.ADMPedidoVO", b =>
                {
                    b.HasOne("ControleClienteSofTinel.Dominio.Entidades.ADMPedidoStatusVO", "ADMPedidoStatus")
                        .WithMany()
                        .HasForeignKey("ADMPedidoStatusId");

                    b.HasOne("ControleClienteSofTinel.Dominio.Entidades.ADMEmpresaVO", "Empresa")
                        .WithMany()
                        .HasForeignKey("IdEmpresa");

                    b.HasOne("ControleClienteSofTinel.Dominio.Entidades.ADMPlanoVO", "Plano")
                        .WithMany()
                        .HasForeignKey("IdPlano");

                    b.HasOne("ControleClienteSofTinel.Dominio.Entidades.ADMSegmentoVO", "Segmento")
                        .WithMany()
                        .HasForeignKey("IdSegmento");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ControleClienteSofTinel.Dominio.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ControleClienteSofTinel.Dominio.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ControleClienteSofTinel.Dominio.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ControleClienteSofTinel.Dominio.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
