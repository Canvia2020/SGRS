using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGRS.Controllers
{
    public class ComponenteController : Controller
    {
      
        public ActionResult ListaComponente()
        {
            return PartialView();
        }
        public ActionResult NuevoComponente()
        {
            return PartialView();
        }
    }
}