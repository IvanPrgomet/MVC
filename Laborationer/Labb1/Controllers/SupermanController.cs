﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Labb1.Controllers
{
    public class SupermanController : Controller
    {
        // GET: Superman
        public ActionResult DoGood()
        {
            return View();
        }
    }
}