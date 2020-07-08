using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGRS.Controllers
{
    public class IndicadorController : Controller
    {
        // GET: Inidcador
        public ActionResult ListaIndicador()
        {
            return PartialView();
        }
        public ActionResult NuevoIndicador()
        {
            return PartialView();
        }
    }
}