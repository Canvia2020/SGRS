using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGRS.Controllers
{
    public class DetalleIndicadorController : Controller
    {
        public ActionResult ListaDetalleIndicador()
        {
            return PartialView();
        }
        public ActionResult NuevoDetalleIndicador()
        {
            return PartialView();
        }


    }
}