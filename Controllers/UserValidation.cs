using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using MVCDemoAppMastek.Models;

namespace MVCDemoAppMastek.Controllers
{
    public class UserValidation : Controller
    {
        trainingContext db;

        public UserValidation(trainingContext context)
        {
            db = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            

            return View(new Userdatum());
        }

        [HttpPost]
        public IActionResult Index(Userdatum user)
        {
            Userdatum obj = db.Userdata.SingleOrDefault(u => u.Username == user.Username && u.Password == user.Password);
           if(obj != null)
            {
                return RedirectToAction("Index", "Emp");
            }

           else
            {
                ModelState.AddModelError("error", "Invalid Username or Password");
            }
            return View(user);
        }
    }
}
