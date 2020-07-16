using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGRS.Controllers
{
    public class ActividadesController : Controller
    {
        public ActionResult ListaActividades()
        {
            return PartialView();
        }
        public ActionResult NuevoActividades()
        {
            return PartialView();
        }


    }
}