using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGRS.Controllers
{
    public class ProgramaController : Controller
    {
        // GET: Programa
        public ActionResult ListaPrograma()
        {

            return PartialView();
        }

        [HttpPost]
        public ActionResult NuevoPrograma()
        {

            return PartialView();
        }
    }
}