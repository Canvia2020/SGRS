using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGRS.Controllers
{
    public class SeguridadController : Controller
    {
        // GET: Seguridad
        public ActionResult ListaUsuarios()
        {
            return View();
        }

    }
}