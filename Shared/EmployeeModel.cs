using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorEmployeeDemo.Shared
{
   public   class EmployeeModel
    {
        [Required]
        public int? EmpNo { get; set; }

        [Required]
        public string EmpName { get; set; }

        [Required]
        public DateTime? HireDate { get; set; }
        [Required]
        public double? Salary { get; set; }
    }
}
