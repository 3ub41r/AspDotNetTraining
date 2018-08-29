using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspDotNetTraining.Controllers.Admin
{
    [RoutePrefix("admin/students")]
    [Route("{action=Index}")]
    public class AdminStudentController : Controller
    {
        public ActionResult Index()
        {
            return Content("Welcome to /admin/students");
        }

        public ActionResult List()
        {
            return Content("Welcome to /admin/students/list");
        }

        [Route("show/{id:int:min(10)}")]
        public ActionResult Show(int id)
        {
            return Content("Showing student with id = " + id);
        }
    }
}