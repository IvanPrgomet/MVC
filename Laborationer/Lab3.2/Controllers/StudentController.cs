using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab3._2.Models;

namespace Lab3._2.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Details()
        {
            Student student = new Student()
            {
                StudentId = 1,
                Name = "Ivan",
                LastName = "Prgomet",
                PersonNumber = "920620-6717",
                Address = "Oscarsgatan 4",
                Grades = new List<Grade>
                {
                    new Grade {GradeId = 1, CourseName = "MVC", CourseGrade = "MVG"},
                    new Grade {GradeId = 12, CourseName = "HTML5", CourseGrade = "VG"}
                }
            };
            Session["Student"] = student;
            return View(student);
        }
    }
}