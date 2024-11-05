using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.Linq;
using ControleClienteSofTinel.Dominio.Entidades;
using ControleClienteSofTinel.Application.Services;

namespace MakeIT.SVA.Presentation.Controllers
{
    public class AdministradorController : Controller
    {
        public IActionResult Index()
        {
            List<ADMAdministradorVO> AdministradorVOs = new AdministradorService().GetAllCodAdministrador();
            return View(AdministradorVOs);
        }

        [HttpPost]
        public IActionResult Index(int? Id = null,
                                                            string Nome = null,
                                                            string Email = null,
                                                            string Senha = null,
                                                            string SenhaRed = null,
                                                            string Perfil = null,
                                                            int? Status = null,
                                                            string Codigo = null,
                                                            string Ativo = null)
        {
            List<ADMAdministradorVO> AdministradorVOs = new AdministradorService()
                .GetAllCodAdministrador(Id: Id,
                                           Codigo: Codigo,
                                           Nome: Nome,
                                           Email: Email,
                                           Senha: Senha,
                                           SenhaRed: SenhaRed,
                                           Perfil: Perfil,
                                           Status: Status,
                                           Ativo: Ativo);

            return View(AdministradorVOs);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ADMAdministradorVO AdministradorVO)
        {
            AdministradorVO.CadastradoPor = User.Identity.Name;
            AdministradorVO.Cadastro = DateTime.Now;
            AdministradorVO.Codigo = "11" + new Random().Next(0, 1000).ToString();

            Dictionary<string, string> retorno = new Dictionary<string, string>();

            if (ModelState.IsValid)
            {
                retorno = new AdministradorService().Create(AdministradorVO: AdministradorVO);
                if (retorno.Count > 0)
                {
                    ModelState.AddModelError(retorno.FirstOrDefault().Key, retorno.FirstOrDefault().Value);
                }
                else
                {
                    TempData["FlashMensage"] = "<p class='alert alert-success'>Salvo com sucesso.</p>";
                }
            }
            return View(AdministradorVO);
        }

        public IActionResult Edit(int Id)
        {
            ADMAdministradorVO AdministradorVO = new AdministradorService().GetSingleCodAdministrador(Id: Id);
            return View(AdministradorVO);
        }

        [HttpPost]
        public IActionResult Edit(ADMAdministradorVO AdministradorVO)
        {
            AdministradorVO.Edicao = DateTime.Now;
            AdministradorVO.EditadoPor = User.Identity.Name;
            Dictionary<string, string> retorno = new Dictionary<string, string>();

            if (ModelState.IsValid)
            {
                retorno = new AdministradorService().Edit(AdministradorVO: AdministradorVO);
                if (retorno.Count > 0)
                {
                    ModelState.AddModelError(retorno.FirstOrDefault().Key, retorno.FirstOrDefault().Value);
                }
                else
                {
                    TempData["FlashMensage"] = "<p class='alert alert-success'>Editado com sucesso.</p>";
                }
            }
            return View(AdministradorVO);
        }


        public IActionResult View(int Id)
        {
            ADMAdministradorVO AdministradorVO = new AdministradorService().GetSingleCodAdministrador(Id: Id);
            return View(AdministradorVO);
        }

        [HttpPost]
        public IActionResult Delete([FromBody] int Id)
        {
            Dictionary<string, string> retorno = new Dictionary<string, string>();
            ADMAdministradorVO AdministradorVO = new AdministradorService().GetSingleCodAdministrador(Id: Id);
            retorno = new AdministradorService().Delete(AdministradorVO: AdministradorVO);
            if (retorno.Count > 0)
            {
                return Json(new { success = false, erro = retorno.FirstOrDefault().Key + " Motivo " + retorno.FirstOrDefault().Value });
            }
            return Json(new { success = true });
        }
    }
}