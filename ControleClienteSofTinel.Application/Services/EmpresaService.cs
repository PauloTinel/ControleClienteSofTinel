using ControleClienteSofTinel.Data.Dados;
using ControleClienteSofTinel.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleClienteSofTinel.Application.Services
{
    public class EmpresaService
    {
        public ADMEmpresaVO GetSingleCodEmpresa(int? Id = null,
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
            return new EmpresaBO().GetSingleEmpresa(Id: Id,
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
                                Longitude: Longitude);
        }

        public List<ADMEmpresaVO> GetAllCodEmpresa(int? Id = null,
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
            return new EmpresaBO().GetAllEmpresa(Id: Id,
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
                                Longitude: Longitude);
        }

        public Dictionary<string, string> Create(ADMEmpresaVO EmpresaVO)
        {
            var validate = new Dictionary<string, string>();
            try
            {
                EmpresaVO.VersaoRegistro = DateTime.Now.Ticks.ToString() + new Random().Next(0, 1000).ToString("0000");
                new EmpresaBO().Create(EmpresaVO);
            }
            catch (Exception ex)
            {
                validate.Add("Problema ocorrido", "Motivo: " + ex.Message);
            }
            return validate;
        }

        public Dictionary<string, string> Edit(ADMEmpresaVO EmpresaVO)
        {
            var validate = new Dictionary<string, string>();
            try
            {
                new EmpresaBO().Edit(EmpresaVO);
            }
            catch (Exception ex)
            {
                validate.Add("Problema ocorrido", "Motivo: " + ex.Message);
            }
            return validate;
        }

        public Dictionary<string, string> Delete(ADMEmpresaVO EmpresaVO)
        {
            var validate = new Dictionary<string, string>();
            try
            {
                new EmpresaBO().Delete(EmpresaVO);
            }
            catch (Exception ex)
            {
                validate.Add("Problema ocorrido", "Motivo: " + ex.Message);
            }
            return validate;
        }
    }
}

