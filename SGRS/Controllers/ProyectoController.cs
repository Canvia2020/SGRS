using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGRS.Controllers
{
    public class ProyectoController : Controller
    {
        // GET: Proyecto
        public ActionResult ListaProyecto()
        {
            return PartialView();
        }
        public ActionResult NuevoProyecto()
        {
            return PartialView();
        }
    }
}