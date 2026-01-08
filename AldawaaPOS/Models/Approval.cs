using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AldawaaPOS.Models
{
    public class Approval
    {
        [Key]
        public int Id { get; set; }

        public string? Type { get; set; }

        public string? PatientName { get; set; }

        public string? PatientId { get; set; }

        public string? Bayer { get; set; }

        public DateTime RequestTime { get; set; }

        public DateTime ResponseTime { get; set; }

        public string? Status { get; set; }

        public bool IsInvoiced { get; set; }

        public bool HasError { get; set; }

        public bool HasComment { get; set; }

        public bool IsDispensed { get; set; }

        public bool IsCancelled { get; set; }

    }
}
