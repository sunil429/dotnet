using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQDemoMastek
{
    class Program
    {

        static void Main(string[] args)
        {
            #region Array

            //int[] numbers = { 44, 566, 3432, 67, 4545, 788, 767, 989, 3434, 656, 3, 7676 };

            // int[] evendata = (from n in numbers where n % 2 == 0 select n).ToArray();

            // evendata = numbers.Where(n => n % 2 == 0).ToArray();

            //for(int i = 0; i < evendata.Length; i++)
            // {
            //  Console.WriteLine(evendata[i]);
            // }

            #endregion

            #region List
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { Empno = 101, EmpName = "bhavana", Address = "mumbai", Dept = "hr", Salary = 15000 });
            empList.Add(new Employee() { Empno = 102, EmpName = "amit", Address = "mumbai", Dept = "sales", Salary = 25000 });
            empList.Add(new Employee() { Empno = 103, EmpName = "vishal", Address = "pune", Dept = "sales", Salary = 20000 });
            empList.Add(new Employee() { Empno = 104, EmpName = "priya", Address = "mumbai", Dept = "hr", Salary = 30000 });
            empList.Add(new Employee() { Empno = 105, EmpName = "asha", Address = "mumbai", Dept = "sales", Salary = 30000 });
            empList.Add(new Employee() { Empno = 106, EmpName = "pankaj", Address = "pune", Dept = "hr", Salary = 35000 });
            empList.Add(new Employee() { Empno = 107, EmpName = "anil", Address = "mumbai", Dept = "sales", Salary = 18000 });
            empList.Add(new Employee() { Empno = 108, EmpName = "preeti", Address = "pune", Dept = "hr", Salary = 25000 });

            #endregion
            //1

            IEnumerable<Employee> query1 = from e in empList select e;

            //---------------------------
            //2 filter
            //list emps working in sales dept


            IEnumerable<Employee> query2 = from e in empList where e.Dept == "sales" select e;



            query2 = empList.Where(e => e.Dept == "sales");


            //------------------------
            //declarative and method syntax

            //3 list all emps who are earning more then 25000

            //4 
            // IEnumerable<Employee> query4 = from e in empList where e.Address == "mumbai" && e.Dept == "sales" select e;
            // IEnumerable<Employee> query3 = from e in empList where e.Salary > 25000 select e;

           // IEnumerable<Employee> query5 = from e in empList
                                         //  where e.EmpName.StartsWith('p')
                                          // select e;
           
            //    query5 = empList.Where(e => e.EmpName.StartsWith("p"));
          //  query5 = empList.Where(e => e.EmpName.StartsWith("p")).ToList();

           // empList.Add(new Employee() { Empno = 201, EmpName = "peter", Address = "Pune", Dept = "hr", Salary = 25000 });

           // Console.WriteLine("-------------------");


           // empList.Add(new Employee() { Empno = 301, EmpName = "peter1", Address = "Pune", Dept = "hr", Salary = 25000 });


           // Console.WriteLine("-------------------");


           // Employee emp = (from e in empList where e.Address == "mumbai" select e).FirstOrDefault();
           // Console.WriteLine("Employee :" + emp);

           // emp = empList.Where(e => e.Empno == 102).FirstOrDefault();

            var query8 = from e in empList select new { e.EmpName, e.Dept, e.Salary };

            var query9 = from e in empList where e.Salary > 20000 && e.Salary < 30000 select new { e.EmpName, e.Salary };

            

            foreach (var item in query8)
            {
               Console.WriteLine(item.EmpName + "  "  + item.Salary);
            }
           
        }
    }
}
