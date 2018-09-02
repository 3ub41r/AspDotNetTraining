using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspDotNetTraining.Models;
using AspDotNetTraining.Services;
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

        [HttpPost]
        public ActionResult Create(Student student)
        {
            using (var c = new ConnectionFactory().GetConnection())
            {
                const string sql = @"
                INSERT INTO Student (Name, IcNumber, MatricNumber)
                VALUES (@Name, @IcNumber, @MatricNumber)";

                c.Execute(sql, student);

                return RedirectToAction("Index");
            }
        }

        public ActionResult Edit(int id)
        {
            var student = new StudentService().Find(id);

            if (student == null) return HttpNotFound();

            return View("New", student);
        }

        public ActionResult Update(Student student)
        {
            new StudentService().Update(student);

            return RedirectToAction("Index");
        }
    }
}