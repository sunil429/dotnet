using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Assignment.ViewModels
{
    public class RadioDemoViewModel
    {

        public string Country { get; set; }

        public List<string> CountryList { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
