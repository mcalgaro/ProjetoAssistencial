﻿using ProjetoAssistencial.Cliente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoAssistencial.Cliente.Controllers
{
    public class VoluntarioController : Controller
    {
        // GET: Voluntario
        public ActionResult Index()
        {
            List<Acao> Acoes = MockFactory.MockFactory.GerarListaAcoes(10);

            ViewBag.Acoes = Acoes;

            List<Doacao> Doacoes = MockFactory.MockFactory.GerarListaDoacoes(10);

            ViewBag.Doacoes = Doacoes;

            return View();
        }

        [HttpPost]
        public ActionResult GravarDoacao()
        {
            return RedirectToAction("Index", "Voluntario");
        }

        public ActionResult Doar()
        {
            return View("Doar");
        }

        public ActionResult AceitarAcao()
        {

            return null;
            //return View("Doar");
        }

    }
}