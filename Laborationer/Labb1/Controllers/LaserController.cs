﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Labb1.Controllers
{
    public class LaserController : Controller
    {
        // GET: Laser
        public ActionResult Sabel(int? id)
        {
            ViewBag.Ivan = id;
            return View();
        }

        public ActionResult Pointer()
        {
            return View();
        }

        public ActionResult Eye()
        {
            return View();
        }

        public ActionResult Printer()
        {
            return View();
        }
    }
}