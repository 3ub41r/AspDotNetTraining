using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspDotNetTraining.Areas.Student.Controllers
{
    [RouteArea("Student")]
    [RoutePrefix("Subjects")]
    [Route("{action}")]
    public class SubjectsController : Controller
    {
        // GET: Student/Subjects
        public ActionResult Index()
        {
            return Content("Welcome to /student/subjects");
        }

        public ActionResult Register()
        {
            return View();
        }
    }
}