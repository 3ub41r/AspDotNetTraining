using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspDotNetTraining.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "IC Number")]
        public string IcNumber { get; set; }

        public string MatricNumber { get; set; }
        public List<Payment> Payments { get; set; }
    }
}

