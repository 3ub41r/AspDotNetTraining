namespace AspDotNetTraining.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Payment")]
    public partial class Payment
    {
        public int Id { get; set; }

        public DateTime? PaymentDate { get; set; }

        [StringLength(5000)]
        public string Description { get; set; }

        public decimal? Amount { get; set; }

        public int StudentId { get; set; }
    }
}
