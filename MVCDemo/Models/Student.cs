using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo.Models
{
    public class Student
    {
        [Required]
        public int? Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime? BirthDate { get; set; }
    }
}
