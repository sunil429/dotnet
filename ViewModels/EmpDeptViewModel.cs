using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCDemoAppMastek.Models;
using Microsoft.Extensions.Configuration;

namespace MVCDemoAppMastek.ViewModels
{
    public class EmpDeptViewModel
    {
        public Emp Employee { get; set; }

        public Dept Department { get; set; }

        private int years = 0;

        public int YearsCompleted
        {
            get
            {
                if (Employee.Hiredate.HasValue)
                {
                    years = DateTime.Now.Year - Employee.Hiredate.Value.Year;
                }
                return years;
            }
        }

        private string salarycolor;

        public string SalaryColor
        {
            get
            {
                decimal salvalue = 2500;
                if (Employee.Sal.HasValue)
                {
                    if (Employee.Sal.Value > salvalue)
                    {
                        salarycolor = "LightGreen";
                    }
                    else
                    {
                        salarycolor = "LightBlue";
                    }
                }
                else
                {
                    salarycolor = "White";
                }

                return salarycolor;
            }


        }
        #region properties
        public string DeptName
        {
            get
            {
                if(Employee.Deptno.HasValue == false)
                {
                    return string.Empty;
                }
                return Department.Dname;
            }
        }

        public string Location
        {
            get
            {
                if(Employee.Deptno.HasValue == false)
                {
                    return string.Empty;
                }
                return Department.Loc;
            }
        }
      #endregion
    }
}
