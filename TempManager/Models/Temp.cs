using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
namespace TempManager.Models
{
    public class Temp
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Date is required.")]
        [Remote("CheckDate", "Validation")]
        public DateTime? Date { get; set; }

        [Required(ErrorMessage = "Low temp required.")]
        [Range(-200, 200, ErrorMessage = "Must be in the range of -200 and 200.")]
        public double? Low { get; set; }

        [Required(ErrorMessage = "High temp required.")]
        [Range(-200, 200, ErrorMessage = "Must be in the range of -200 and 200.")]
        public double? High { get; set; }
    }
}
