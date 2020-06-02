using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReqMateriaisRmTotvs.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Este aplicativo permite a inclusão de movimento de Requisição ao ERP RM TOTVS.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Para maiores informações entrar em contato";

            return View();
        }
    }
}