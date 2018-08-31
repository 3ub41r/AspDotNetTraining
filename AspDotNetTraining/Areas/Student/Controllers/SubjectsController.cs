using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspDotNetTraining.Models;

namespace AspDotNetTraining.Areas.Student.Controllers
{
    [RouteArea("Student")]
    [RoutePrefix("Subjects")]
    [Route("{action=Index}")]
    public class SubjectsController : Controller
    {
        // GET: Student/Subjects
        public ActionResult Index()
        {
            // Pass data as model
            var student = new Models.Student
            {
                Name = "Zubair",
                IcNumber = "123456789123"
            };

            return View(student);
        }

        public ActionResult Register()
        {
            // Pass data as ViewData
            var student = new Models.Student
            {
                Name = "Zubair",
                IcNumber = "123456789123"
            };

            ViewBag.Student = student;

            ViewData["Student"] = student;

            return View();
        }

        public ActionResult List()
        {
            var student = new Models.Student
            {
                Name = "Zubair",
                IcNumber = "123456789123",
                Payments = new List<Payment>
                {
                    new Payment { Amount = 100 },
                    new Payment { Amount = 200 },
                    new Payment { Amount = 300 }
                }
            };

            return View(student);
        }
    }
}