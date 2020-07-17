using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGRS.Controllers
{
    public class ReporteController : Controller
    {
        public ActionResult ReporteIndicador()
        {
            return PartialView();
        }
        public ActionResult ReporteGasto()
        {
            return PartialView();
        }
        public ActionResult ReporteRequerimiento()
        {
            return PartialView();
        }

      




    }
}