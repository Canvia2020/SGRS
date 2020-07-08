using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGRS.Controllers
{
    public class CentrosSaludController : Controller
    {
        public ActionResult ListaCentroDeSalud()
        {
            return PartialView();
        }
        public ActionResult NuevoCentroDeSalud()
        {
            return PartialView();
        }
    }
}