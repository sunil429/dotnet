using BlazorEmployeeDemo.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEmployeeDemo.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private static List<EmployeeModel> empList = new List<EmployeeModel>();

        public EmployeesController()
        {
            //populate empList with records
            if (empList.Count == 0)
            {
                empList.Add(new EmployeeModel { EmpNo = 1, EmpName = "Bhavana", HireDate = Convert.ToDateTime("01/01/2001"), Salary = 100000 });
                empList.Add(new EmployeeModel { EmpNo = 2, EmpName = "Vishal", HireDate = Convert.ToDateTime("12/12/2012"), Salary = 500000 });
            }
        }

        [HttpGet]
        public IEnumerable<EmployeeModel> GetAllEmps()
        {
            return empList.ToArray();
        }

        [HttpPost]
        public void PostEmp(EmployeeModel employee)
        {
            empList.Add(employee);
        }
    }
}
