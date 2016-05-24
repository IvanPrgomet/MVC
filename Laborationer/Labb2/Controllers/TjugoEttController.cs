using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Labb2.Models;

namespace Labb2.Controllers
{
    public class TjugoEttController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public PartialViewResult _TjugoEtt()
        {
            return PartialView(new TjugoEttModels());
        }

        [HttpPost]
        public PartialViewResult _TjugoEtt(TjugoEttModels model)
        {
            model.IncreaseActualNumber(1);
            model.ComputerChoice();
            model.IncreaseActualNumber(2);
            ModelState.Remove("ActualNumber");
            ModelState.Remove("CpuTurn");
            return PartialView(model);
        }
    }
}