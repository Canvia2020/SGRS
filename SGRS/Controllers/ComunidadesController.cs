using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGRS.Controllers
{
    public class ComunidadesController : Controller
    {
        public ActionResult ListaComunidades()
        {
            return PartialView();
        }
        public ActionResult NuevoComunidad()
        {
            return PartialView();
        }
    }
}