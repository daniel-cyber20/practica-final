using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using proyecto.Models;

namespace proyecto.Controllers
{
    public class PrincipalController : Controller
    {
        productoContext pro = new productoContext();

        // GET: Principal
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Mantenimiento()
        {
            return View();
        }

        public ActionResult Procesos()
        {
            return View();
        }

        public ActionResult Consultas()
        {
            return View();
        }
    }
}