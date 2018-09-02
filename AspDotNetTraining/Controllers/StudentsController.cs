using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspDotNetTraining.Models;
using Dapper;

namespace AspDotNetTraining.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Index()
        {
            // Get connection string
            var connection = ConfigurationManager.ConnectionStrings["Database"];

            using (var c = new SqlConnection(connection.ToString()))
            {
                var students = c.Query<Student>("SELECT * FROM Student");
                return View(students);
            }
        }

        public ActionResult New()
        {
            return View();
        }
    }
}