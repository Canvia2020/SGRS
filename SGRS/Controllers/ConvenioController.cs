﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGRS.Controllers
{
    public class ConvenioController : Controller
    {
        public ActionResult ListaConvenio()
        {
            return PartialView();
        }
        public ActionResult NuevoConvenio()
        {
            return PartialView();
        }


    }
}