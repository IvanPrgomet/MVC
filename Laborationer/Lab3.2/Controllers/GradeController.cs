using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab3._2.Models;

namespace Lab3._2.Controllers
{
    public class GradeController : Controller
    {
        public PartialViewResult _ListForStudent(int studentId)
        {
            List<Grade> grades = ((Student)Session["Student"]).Grades;
            return PartialView(grades);
        }

        public PartialViewResult _Add(int studentId)
        {
            return PartialView(new Grade() {StudentId = studentId});
        }

        [HttpPost]
        public ActionResult _Add(Grade model)
        {
            ((Student)Session["Student"]).Grades.Add(model);
            return RedirectToAction(actionName: "_ListForStudent", routeValues: new { studentId = model.StudentId });
        }

    }
}