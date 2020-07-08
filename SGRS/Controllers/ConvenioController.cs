using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGRS.Controllers
{
    public class ConvenioController : Controller
    {
        // GET: Convenio
        public ActionResult Convenio_Lista()
        {

            return View();
        }
        [HttpGet]
        public ActionResult Convenio_Add()
        {

            return View();
        }
        //[HttpPost]
        //public ActionResult Convenio_Add()
        //{

        //    return View();
        //}
        //[HttpGet]
        //public ActionResult Convenio_Update()
        //{

        //    return View();
        //}
        //[HttpPost]
        //public ActionResult Convenio_Update()
        //{

        //    return View();
        //}


    }
}