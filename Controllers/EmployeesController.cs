using BlazorWebAsmDemoApp.Server.Models;
using BlazorWebAsmDemoApp.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebAsmDemoApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private trainingContext db;

        public EmployeesController(trainingContext context)
        {
            db = context;
        }
        [HttpGet]
        public IEnumerable<Emp>GetEmployees()
        {
            var data = db.Emps.ToList();

            return data;
        }
    }
}
