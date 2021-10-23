using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemoMastek
{
    class Employee
    {
        //auto implemented properties 

        public int Empno { get; set; }

        public string EmpName { get; set; }

        public string Address { get; set; }

        public string Dept { get; set; }

        public double Salary { get; set; }

        public override string ToString()
        {
            return string.Format($"Empno  = {Empno}   EmpName = {EmpName}  Address = {Address} Dept = {Dept}  Salary ={Salary}");
        }

    }
}
