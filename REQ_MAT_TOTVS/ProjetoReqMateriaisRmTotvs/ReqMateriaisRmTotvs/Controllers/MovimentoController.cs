using ReqMateriaisRmTotvs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReqMateriaisRmTotvs.Controllers
{
    public class MovimentoController : Controller
    {
        // GET: Movimento
        public ActionResult Index()
        {
            return View(new Movimento());
        }
        public ActionResult Adiciona()
        {
            return View();
        }
    }
}