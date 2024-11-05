using ControleClienteSofTinel.Application.Services;
using ControleClienteSofTinel.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.Linq;

namespace ControleClienteSofTinel.WebApp.Controllers
{
    public class EmpresaController : Controller
    {

        public IActionResult Index()
        {
            List<ADMEmpresaVO> EmpresaVOs = new EmpresaService().GetAllCodEmpresa();
            return View(EmpresaVOs);
        }

        [HttpPost]
        public IActionResult Index(int? Id = null,
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
            List<ADMEmpresaVO> EmpresaVOs = new EmpresaService()
                .GetAllCodEmpresa(Id: Id,
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

            return View(EmpresaVOs);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ADMEmpresaVO EmpresaVO)
        {
            EmpresaVO.CadastradoPor = User.Identity.Name;
            EmpresaVO.Cadastro = DateTime.Now;
            EmpresaVO.Codigo = "11" + new Random().Next(0, 1000).ToString();

            Dictionary<string, string> retorno = new Dictionary<string, string>();

            if (ModelState.IsValid)
            {
                retorno = new EmpresaService().Create(EmpresaVO: EmpresaVO);
                if (retorno.Count > 0)
                {
                    ModelState.AddModelError(retorno.FirstOrDefault().Key, retorno.FirstOrDefault().Value);
                }
                else
                {
                    TempData["FlashMensage"] = "<p class='alert alert-success'>Salvo com sucesso.</p>";
                }
            }
            return View(EmpresaVO);
        }

        public IActionResult Edit(int Id)
        {
            ADMEmpresaVO EmpresaVO = new EmpresaService().GetSingleCodEmpresa(Id: Id);
            return View(EmpresaVO);
        }

        [HttpPost]
        public IActionResult Edit(ADMEmpresaVO EmpresaVO)
        {
            EmpresaVO.Edicao = DateTime.Now;
            EmpresaVO.EditadoPor = User.Identity.Name;
            Dictionary<string, string> retorno = new Dictionary<string, string>();

            if (ModelState.IsValid)
            {
                retorno = new EmpresaService().Edit(EmpresaVO: EmpresaVO);
                if (retorno.Count > 0)
                {
                    ModelState.AddModelError(retorno.FirstOrDefault().Key, retorno.FirstOrDefault().Value);
                }
                else
                {
                    TempData["FlashMensage"] = "<p class='alert alert-success'>Editado com sucesso.</p>";
                }
            }
            return View(EmpresaVO);
        }


        public IActionResult View(int Id)
        {
            ADMEmpresaVO EmpresaVO = new EmpresaService().GetSingleCodEmpresa(Id: Id);
            return View(EmpresaVO);
        }

        [HttpPost]
        public IActionResult Delete([FromBody] int Id)
        {
            Dictionary<string, string> retorno = new Dictionary<string, string>();
            ADMEmpresaVO EmpresaVO = new EmpresaService().GetSingleCodEmpresa(Id: Id);
            retorno = new EmpresaService().Delete(EmpresaVO: EmpresaVO);
            if (retorno.Count > 0)
            {
                return Json(new { success = false, erro = retorno.FirstOrDefault().Key + " Motivo " + retorno.FirstOrDefault().Value });
            }
            return Json(new { success = true });
        }
    }
}