using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspDotNetTraining.Models;
using AspDotNetTraining.ViewModels;

namespace AspDotNetTraining.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult ActionParameterTest(int? id, int? limit, string sortBy)
        {
            return Content($"id = {id}, limit = {limit}, sortBy = {sortBy}");
        }

        public ActionResult Test()
        {
            return Content("This is a test");
        }

        public ActionResult Index()
        {
            return View();
        }

        // /home/about
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Student()
        {
            var viewModel = new HomeStudentViewModel
            {
                Student = new Student
                {
                    Name = "Zubair",
                    IcNumber = "121212121212",
                    MatricNumber = "A1234567890"
                },
                Payments = new List<Payment>
                {
                    new Payment { Amount = 100 },
                    new Payment { Amount = 200 },
                    new Payment { Amount = 300 }
                }
            };

            return View(viewModel);
        }
    }
}