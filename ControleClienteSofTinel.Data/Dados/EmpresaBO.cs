using ControleClienteSofTinel.Data.Context;
using ControleClienteSofTinel.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace ControleClienteSofTinel.Data.Dados
{
    public class EmpresaBO
    {
        public SvaContext context;
        public EmpresaBO()
        {
            context = new SvaContext();
        }

        public ADMEmpresaVO GetSingleEmpresa(
            int? Id = null,
            int? IdSegmento = null,
            int? IdPlano = null,
            string Codigo = null,
            string RazaoSocial = null,
            string NomeFantasia = null,
            string CNPJ = null,
            string Email = null,
            string Responsavel = null,
            string Telefone = null,
            string Celular = null,
            string HoraAbertura = null,
            string AberturaInicial = null,
            string AberturaFinal = null,
            string HoraFechamento = null,
            string ImageLogotipo = null,
            string Ativo = null,
            string rua = null,
            string cep = null,
            string bairro = null,
            string cidade = null,
            string Numero = null,
            string Complemento = null,
            string uf = null,
            double? LimiteDistanciaEntrega = null,
            decimal? ValorComissao = null,
            double? Latitude = null,
            double? Longitude = null)
        {
            return GetAllEmpresa(Id: Id,
                                IdSegmento: IdSegmento,
                                IdPlano: IdPlano,
                                Codigo: Codigo,
                                RazaoSocial: RazaoSocial,
                                NomeFantasia: NomeFantasia,
                                CNPJ: CNPJ,
                                Email: Email,
                                Responsavel: Responsavel,
                                Telefone: Telefone,
                                Celular: Celular,
                                HoraAbertura: HoraAbertura,
                                AberturaInicial: AberturaInicial,
                                AberturaFinal: AberturaFinal,
                                HoraFechamento: HoraFechamento,
                                ImageLogotipo: ImageLogotipo,
                                Ativo: Ativo,
                                rua: rua,
                                cep: cep,
                                bairro: bairro,
                                cidade: cidade,
                                Numero: Numero,
                                Complemento: Complemento,
                                uf: uf,
                                LimiteDistanciaEntrega: LimiteDistanciaEntrega,
                                ValorComissao: ValorComissao,
                                Latitude: Latitude,
                                Longitude: Longitude).FirstOrDefault();
        }

        public List<ADMEmpresaVO> GetAllEmpresa(
            int? Id = null,
            int? IdSegmento = null,
            int? IdPlano = null,
            string Codigo = null,
            string RazaoSocial = null,
            string NomeFantasia = null,
            string CNPJ = null,
            string Email = null,
            string Responsavel = null,
            string Telefone = null,
            string Celular = null,
            string HoraAbertura = null,
            string AberturaInicial = null,
            string AberturaFinal = null,
            string HoraFechamento = null,
            string ImageLogotipo = null,
            string Ativo = null,
            string rua = null,
            string cep = null,
            string bairro = null,
            string cidade = null,
            string Numero = null,
            string Complemento = null,
            string uf = null,
            double? LimiteDistanciaEntrega = null,
            decimal? ValorComissao = null,
            double? Latitude = null,
            double? Longitude = null)
        {
            List<ADMEmpresaVO> EmpresaVOs = new List<ADMEmpresaVO>();
            string where = " WHERE ";
            List<DbParameter> dbParameters = new List<DbParameter>();
            StringBuilder query = new StringBuilder();

            query.AppendLine(" SELECT cc.Id, cc.IdSegmento, cc.IdPlano, cc.Codigo, cc.RazaoSocial, cc.NomeFantasia,  ");
            query.AppendLine(" cc.CNPJ, cc.Email, cc.Responsavel, cc.Telefone, cc.Celular, cc.HoraAbertura,  ");
            query.AppendLine(" cc.AberturaInicial, cc.AberturaFinal, cc.HoraFechamento, cc.ImageLogotipo, cc.Ativo,  ");
            query.AppendLine(" cc.rua, cc.cep, cc.bairro, cc.cidade, cc.Numero, cc.Complemento, cc.uf,  ");
            query.AppendLine(" cc.LimiteDistanciaEntrega, cc.ValorComissao, cc.Latitude, cc.Longitude,  ");
            query.AppendLine(" cc.CadastradoPor, cc.Cadastro, cc.EditadoPor, cc.Edicao, cc.VersaoRegistro ");
            query.AppendLine(" FROM Empresa AS cc ");

            if (Id != null)
            {
                query.AppendLine(where + " cc.Id=@Id");
                where = " AND ";
                dbParameters.Add(context.GetDbParameter("Id", Id));
            }
            if (IdSegmento != null)
            {
                query.AppendLine(where + " cc.IdSegmento=@IdSegmento");
                where = " AND ";
                dbParameters.Add(context.GetDbParameter("IdSegmento", IdSegmento));
            }
            if (IdPlano != null)
            {
                query.AppendLine(where + " cc.IdPlano=@IdPlano");
                where = " AND ";
                dbParameters.Add(context.GetDbParameter("IdPlano", IdPlano));
            }
            if (!string.IsNullOrWhiteSpace(RazaoSocial))
            {
                query.AppendLine(where + " cc.RazaoSocial LIKE @RazaoSocial");
                where = " AND ";
                dbParameters.Add(context.GetDbParameter("RazaoSocial", "%" + RazaoSocial + "%"));
            }
            if (!string.IsNullOrWhiteSpace(NomeFantasia))
            {
                query.AppendLine(where + " cc.NomeFantasia LIKE @NomeFantasia");
                where = " AND ";
                dbParameters.Add(context.GetDbParameter("NomeFantasia", "%" + NomeFantasia + "%"));
            }
            if (!string.IsNullOrWhiteSpace(CNPJ))
            {
                query.AppendLine(where + " cc.CNPJ LIKE @CNPJ");
                where = " AND ";
                dbParameters.Add(context.GetDbParameter("CNPJ", "%" + CNPJ + "%"));
            }
            if (!string.IsNullOrWhiteSpace(Email))
            {
                query.AppendLine(where + " cc.Email LIKE @Email");
                where = " AND ";
                dbParameters.Add(context.GetDbParameter("Email", "%" + Email + "%"));
            }
            if (!string.IsNullOrWhiteSpace(Responsavel))
            {
                query.AppendLine(where + " cc.Responsavel LIKE @Responsavel");
                where = " AND ";
                dbParameters.Add(context.GetDbParameter("Responsavel", "%" + Responsavel + "%"));
            }
            if (!string.IsNullOrWhiteSpace(Ativo))
            {
                query.AppendLine(where + " cc.Ativo LIKE @Ativo");
                where = " AND ";
                dbParameters.Add(context.GetDbParameter("Ativo", "%" + Ativo + "%"));
            }
            if (!string.IsNullOrWhiteSpace(Ativo))
            {
                query.AppendLine(where + " cc.Ativo LIKE @Ativo");
                where = " AND ";
                dbParameters.Add(context.GetDbParameter("Ativo", "%" + Ativo + "%"));
            }
            if (!string.IsNullOrWhiteSpace(Ativo))
            {
                query.AppendLine(where + " cc.Ativo LIKE @Ativo");
                where = " AND ";
                dbParameters.Add(context.GetDbParameter("Ativo", "%" + Ativo + "%"));
            }
            if (!string.IsNullOrWhiteSpace(Ativo))
            {
                query.AppendLine(where + " cc.Ativo LIKE @Ativo");
                where = " AND ";
                dbParameters.Add(context.GetDbParameter("Ativo", "%" + Ativo + "%"));
            }
            if (!string.IsNullOrWhiteSpace(Ativo))
            {
                query.AppendLine(where + " cc.Ativo LIKE @Ativo");
                where = " AND ";
                dbParameters.Add(context.GetDbParameter("Ativo", "%" + Ativo + "%"));
            }
            if (!string.IsNullOrWhiteSpace(Telefone))
            {
                query.AppendLine(where + " cc.Telefone LIKE @Telefone");
                where = " AND ";
                dbParameters.Add(context.GetDbParameter("Telefone", "%" + Telefone + "%"));
            }
            if (!string.IsNullOrWhiteSpace(Celular))
            {
                query.AppendLine(where + " cc.Celular LIKE @Celular");
                where = " AND ";
                dbParameters.Add(context.GetDbParameter("Celular", "%" + Celular + "%"));
            }
            if (!string.IsNullOrWhiteSpace(HoraAbertura))
            {
                query.AppendLine(where + " cc.HoraAbertura LIKE @HoraAbertura");
                where = " AND ";
                dbParameters.Add(context.GetDbParameter("HoraAbertura", "%" + HoraAbertura + "%"));
            }
            if (!string.IsNullOrWhiteSpace(AberturaInicial))
            {
                query.AppendLine(where + " cc.AberturaInicial LIKE @AberturaInicial");
                where = " AND ";
                dbParameters.Add(context.GetDbParameter("AberturaInicial", "%" + AberturaInicial + "%"));
            }
            if (!string.IsNullOrWhiteSpace(AberturaFinal))
            {
                query.AppendLine(where + " cc.AberturaFinal LIKE @AberturaFinal");
                where = " AND ";
                dbParameters.Add(context.GetDbParameter("AberturaFinal", "%" + AberturaFinal + "%"));
            }
            if (!string.IsNullOrWhiteSpace(HoraFechamento))
            {
                query.AppendLine(where + " cc.HoraFechamento LIKE @HoraFechamento");
                where = " AND ";
                dbParameters.Add(context.GetDbParameter("HoraFechamento", "%" + HoraFechamento + "%"));
            }
            if (!string.IsNullOrWhiteSpace(ImageLogotipo))
            {
                query.AppendLine(where + " cc.ImageLogotipo LIKE @ImageLogotipo");
                where = " AND ";
                dbParameters.Add(context.GetDbParameter("ImageLogotipo", "%" + ImageLogotipo + "%"));
            }
            if (!string.IsNullOrWhiteSpace(rua))
            {
                query.AppendLine(where + " cc.rua LIKE @rua");
                where = " AND ";
                dbParameters.Add(context.GetDbParameter("rua", "%" + rua + "%"));
            }
            if (!string.IsNullOrWhiteSpace(cep))
            {
                query.AppendLine(where + " cc.cep LIKE @cep");
                where = " AND ";
                dbParameters.Add(context.GetDbParameter("cep", "%" + cep + "%"));
            }
            if (!string.IsNullOrWhiteSpace(bairro))
            {
                query.AppendLine(where + " cc.bairro LIKE @bairro");
                where = " AND ";
                dbParameters.Add(context.GetDbParameter("bairro", "%" + bairro + "%"));
            }
            if (!string.IsNullOrWhiteSpace(cidade))
            {
                query.AppendLine(where + " cc.cidade LIKE @cidade");
                where = " AND ";
                dbParameters.Add(context.GetDbParameter("cidade", "%" + cidade + "%"));
            }
            if (!string.IsNullOrWhiteSpace(Numero))
            {
                query.AppendLine(where + " cc.Numero LIKE @Numero");
                where = " AND ";
                dbParameters.Add(context.GetDbParameter("Numero", "%" + Numero + "%"));
            }
            if (!string.IsNullOrWhiteSpace(Complemento))
            {
                query.AppendLine(where + " cc.Complemento LIKE @Complemento");
                where = " AND ";
                dbParameters.Add(context.GetDbParameter("Complemento", "%" + Complemento + "%"));
            }
            if (!string.IsNullOrWhiteSpace(uf))
            {
                query.AppendLine(where + " cc.uf LIKE @uf");
                where = " AND ";
                dbParameters.Add(context.GetDbParameter("uf", "%" + uf + "%"));
            }
            if (LimiteDistanciaEntrega!=null)
            {
                query.AppendLine(where + " cc.LimiteDistanciaEntrega LIKE @LimiteDistanciaEntrega");
                where = " AND ";
                dbParameters.Add(context.GetDbParameter("LimiteDistanciaEntrega", "%" + LimiteDistanciaEntrega + "%"));
            }
            if (ValorComissao!=null)
            {
                query.AppendLine(where + " cc.ValorComissao LIKE @ValorComissao");
                where = " AND ";
                dbParameters.Add(context.GetDbParameter("ValorComissao", "%" + ValorComissao + "%"));
            }
            if (Latitude!=null)
            {
                query.AppendLine(where + " cc.Latitude LIKE @Latitude");
                where = " AND ";
                dbParameters.Add(context.GetDbParameter("Latitude", "%" + Latitude + "%"));
            }
            if(Longitude != null)
            {
                query.AppendLine(where + " cc.Longitude LIKE @Longitude");
                where = " AND ";
                dbParameters.Add(context.GetDbParameter("Longitude", "%" + Longitude + "%"));
            }
            if (!string.IsNullOrWhiteSpace(Ativo))
            {
                query.AppendLine(where + " cc.Ativo LIKE @Ativo");
                where = " AND ";
                dbParameters.Add(context.GetDbParameter("Ativo", "%" + Ativo + "%"));
            }          
            EmpresaVOs = context.Empresa.FromSqlRaw(query.ToString(), dbParameters.ToArray())
                .Include(i => i.Segmento)
                .Include(i => i.Plano)
                .ToList();

            return EmpresaVOs;
        }

        public void Create(ADMEmpresaVO EmpresaVO)
        {
            EmpresaVO.CadastradoPor = "Paulo";
            EmpresaVO.VersaoRegistro = DateTime.Now.Ticks.ToString() + new Random().Next(0, 1000).ToString();
            context.Empresa.Add(EmpresaVO);
            context.SaveChanges();
        }

        public void Edit(ADMEmpresaVO EmpresaVO)
        {
            context.Entry(EmpresaVO).Property(p => p.VersaoRegistro).OriginalValue = EmpresaVO.VersaoRegistro;
            EmpresaVO.VersaoRegistro = DateTime.Now.Ticks.ToString() + new Random().Next(0, 1000).ToString("0000");

            context.Entry(EmpresaVO).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(ADMEmpresaVO EmpresaVO)
        {
            context.Entry(EmpresaVO).State = EntityState.Deleted;
            context.SaveChanges();
        }
    }
}


