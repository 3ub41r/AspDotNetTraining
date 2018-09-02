using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AspDotNetTraining.Models;
using Dapper;

namespace AspDotNetTraining.Services
{
    public class StudentService
    {
        /// <summary>
        /// Find student by Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Student Find(int id)
        {
            const string sql = @"SELECT * FROM Student WHERE Id = @Id";

            using (var c = new ConnectionFactory().GetConnection())
            {
                return c.QuerySingleOrDefault<Student>(sql, new { Id = id });
            }
        }

        /// <summary>
        /// Update student.
        /// </summary>
        /// <param name="student"></param>
        public void Update(Student student)
        {
            const string sql = @"
            UPDATE Student
            SET Name = @Name, IcNumber = @IcNumber, MatricNumber = @MatricNumber
            WHERE Id = @Id";

            using (var c = new ConnectionFactory().GetConnection())
            {
                c.Execute(sql, student);
            }
        }
    }
}