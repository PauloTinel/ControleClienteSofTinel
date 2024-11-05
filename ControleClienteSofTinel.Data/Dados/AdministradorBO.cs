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
    public class AdministradorBO
    {
        public SvaContext context;
        public AdministradorBO()
        {
            context = new SvaContext();
        }

        public ADMAdministradorVO GetSingleCodAdministrador(int? Id = null,
                                                            string Nome = null,
                                                            string Email = null,
                                                            string Senha = null,
                                                            string SenhaRed = null,
                                                            string Perfil = null,
                                                            int? Status = null,
                                                            string Codigo = null,
                                                            string Ativo = null)
        {
            return GetAllCodAdministrador(Id: Id,
                                           Codigo: Codigo,
                                           Nome: Nome,
                                           Email: Email,
                                           Senha: Senha,
                                           SenhaRed : SenhaRed,
                                           Perfil: Perfil,
                                           Status: Status,
                                           Ativo: Ativo
                ).FirstOrDefault();
        }

        public List<ADMAdministradorVO> GetAllCodAdministrador(int? Id = null,
                                                            string Nome = null,
                                                            string Email = null,
                                                            string Senha = null,
                                                            string SenhaRed = null,
                                                            string Perfil = null,
                                                            int? Status = null,
                                                            string Codigo = null,
                                                            string Ativo = null)
        {
            List<ADMAdministradorVO> AdministradorVOs = new List<ADMAdministradorVO>();
            string where = " WHERE ";
            List<DbParameter> dbParameters = new List<DbParameter>();
            StringBuilder query = new StringBuilder();

            query.AppendLine(" SELECT cc.Id, cc.Nome, cc.Codigo, cc.Email, cc.Senha, cc.SenhaRed, cc.Status, cc.Ativo, cc.Perfil,  ");
            query.AppendLine(" cc.CadastradoPor, cc.Cadastro, cc.EditadoPor, cc.Edicao, cc.VersaoRegistro ");
            query.AppendLine(" FROM ADMAdministrador AS cc ");

            if (Id != null)
            {
                query.AppendLine(where + " cc.Id=@Id");
                where = " AND ";
                dbParameters.Add(context.GetDbParameter("Id", Id));
            }
            if (Ativo != null)
            {
                query.AppendLine(where + " cc.Ativo=@Ativo");
                where = " AND ";
                dbParameters.Add(context.GetDbParameter("Ativo", Ativo));
            }
            if (!string.IsNullOrWhiteSpace(Codigo))
            {
                query.AppendLine(where + " cc.Codigo LIKE @Codigo");
                where = " AND ";
                dbParameters.Add(context.GetDbParameter("Codigo", "%" + Codigo + "%"));
            }
            if (Id != null)
            {
                query.AppendLine(where + " cc.Ativo LIKE @Ativo");
                where = " AND ";
                dbParameters.Add(context.GetDbParameter("Ativo", "%" + Ativo + "%"));
            }
            if (!string.IsNullOrWhiteSpace(Nome))
            {
                query.AppendLine(where + " cc.Nome LIKE @Nome");
                where = " AND ";
                dbParameters.Add(context.GetDbParameter("Nome", "%" + Nome + "%"));
            }
            if (!string.IsNullOrWhiteSpace(Email))
            {
                query.AppendLine(where + " cc.Email LIKE @Email");
                where = " AND ";
                dbParameters.Add(context.GetDbParameter("Email", "%" + Email + "%"));
            }
            if (!string.IsNullOrWhiteSpace(Perfil))
            {
                query.AppendLine(where + " cc.Perfil LIKE @Perfil");
                where = " AND ";
                dbParameters.Add(context.GetDbParameter("Perfil", "%" + Perfil + "%"));
            }
            AdministradorVOs = context.ADMAdministrador.FromSqlRaw(query.ToString(), dbParameters.ToArray())
                .ToList();

            return AdministradorVOs;
        }

        public void Create(ADMAdministradorVO CodAdministradorVO)
        {
            CodAdministradorVO.CadastradoPor = "Paulo";
            CodAdministradorVO.VersaoRegistro = DateTime.Now.Ticks.ToString() + new Random().Next(0, 1000).ToString();
            CodAdministradorVO.Codigo = "11" + new Random().Next(0, 1000).ToString();
            context.ADMAdministrador.Add(CodAdministradorVO);
            context.SaveChanges();
        }

        public void Edit(ADMAdministradorVO CodAdministradorVO)
        {
            context.Entry(CodAdministradorVO).Property(p => p.VersaoRegistro).OriginalValue = CodAdministradorVO.VersaoRegistro;
            CodAdministradorVO.VersaoRegistro = DateTime.Now.Ticks.ToString() + new Random().Next(0, 1000).ToString("0000");
            CodAdministradorVO.Codigo = "10" + new Random().Next(0, 1000).ToString("0000");

            context.Entry(CodAdministradorVO).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(ADMAdministradorVO CodAdministradorVO)
        {
            context.Entry(CodAdministradorVO).State = EntityState.Deleted;
            context.SaveChanges();
        }
    }
}

