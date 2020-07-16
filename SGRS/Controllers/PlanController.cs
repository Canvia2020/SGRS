using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGRS.Controllers
{
    public class PlanController : Controller
    {
        public ActionResult ListaPlan()
        {
            return PartialView();
        }
        public ActionResult NuevoPlan()
        {
            return PartialView();
        }


    }
}