using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Html_Helper1.Models
{
    public class Employee
    {
        public int id { get; set; }

        [Display(Name = "Enter name")]
        public string Name { get; set; }
        public string email { get; set; }
        public bool isonline { get; set; }

        [Display(Name = "Date of birth")]
        [DataType(DataType.Date)]
        public DateTime dateofbirth { get; set; }
    }
}