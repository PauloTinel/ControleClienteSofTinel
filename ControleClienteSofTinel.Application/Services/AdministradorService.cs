using ControleClienteSofTinel.Data.Dados;
using ControleClienteSofTinel.Dominio.Entidades;
using System;
using System.Collections.Generic;

namespace ControleClienteSofTinel.Application.Services
{
    public class AdministradorService
    {
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
            return new AdministradorBO().GetSingleCodAdministrador(Id: Id,
                                           Codigo: Codigo,
                                           Nome: Nome,
                                           Email: Email,
                                           Senha: Senha,
                                           SenhaRed: SenhaRed,
                                           Perfil: Perfil,
                                           Status: Status,
                                           Ativo: Ativo);
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
            return new AdministradorBO().GetAllCodAdministrador(Id, Nome, Codigo, Ativo);
        }

        public Dictionary<string, string> Create(ADMAdministradorVO AdministradorVO)
        {
            var validate = new Dictionary<string, string>();
            try
            {
                AdministradorVO.VersaoRegistro = DateTime.Now.Ticks.ToString() + new Random().Next(0, 1000).ToString("0000");
                new AdministradorBO().Create(AdministradorVO);
            }
            catch (Exception ex)
            {
                validate.Add("Problema ocorrido", "Motivo: " + ex.Message);
            }
            return validate;
        }

        public Dictionary<string, string> Edit(ADMAdministradorVO AdministradorVO)
        {
            var validate = new Dictionary<string, string>();
            try
            {
                new AdministradorBO().Edit(AdministradorVO);
            }
            catch (Exception ex)
            {
                validate.Add("Problema ocorrido", "Motivo: " + ex.Message);
            }
            return validate;
        }

        public Dictionary<string, string> Delete(ADMAdministradorVO AdministradorVO)
        {
            var validate = new Dictionary<string, string>();
            try
            {
                new AdministradorBO().Delete(AdministradorVO);
            }
            catch (Exception ex)
            {
                validate.Add("Problema ocorrido", "Motivo: " + ex.Message);
            }
            return validate;
        }
    }
}
