using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspDotNetTraining.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public Student Student { get; set; }
    }
}