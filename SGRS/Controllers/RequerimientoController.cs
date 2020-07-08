using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGRS.Controllers
{
    public class RequerimientoController : Controller
    {
        // GET: Requerimiento
        public ActionResult ListaRequerimiento()
        {
            return PartialView();
        }
        public ActionResult NuevoRequerimiento()
        {
            return PartialView();
        }
    }
}