using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
    }
}