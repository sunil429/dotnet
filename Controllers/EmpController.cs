﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCDemoAppMastek.Models;
using Microsoft.Extensions.Configuration;
using MVCDemoAppMastek.ViewModels;

namespace MVCDemoAppMastek.Controllers
{
    public class EmpController : Controller
    {
        trainingContext db;

        public EmpController(trainingContext context)
        {
            db = context;
        }
        public IActionResult Index(string SearchString)
        {

            var empData = from e in db.Emps select e;
            if(!string.IsNullOrEmpty(SearchString))
            {
                empData = empData.Where(e => e.Ename.ToUpper().Contains(SearchString.ToUpper()));
            }
            ViewBag.filter = SearchString;
            return View(empData.ToList());
        }

        public IActionResult Details(int id)
        { 
            Emp emp = db.Emps.SingleOrDefault(e => e.Empno == id);
            if(emp != null)
            {
                return View(emp);
            }
            return NotFound(); // status code
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Emp());
        }

        [HttpPost]
        public IActionResult Create(Emp emp)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Emps.Add(emp);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                else
                {
                    return View(emp);
                }
            }

            catch(Exception ex)
            {
                if(ex.InnerException != null)
                {
                    ModelState.AddModelError("", ex.InnerException.Message);
                }
                else
                {
                    ModelState.AddModelError("", ex.Message);
                }

                return View(emp);
            }

        }


        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if(id == null)
            {
                return BadRequest();
            }

            Emp emp = db.Emps.SingleOrDefault(e => e.Empno == id);

            if(emp == null)
            {
                return View(emp);
            }

            return View(emp);
        }

        [HttpPost]
        public IActionResult Edit(int id, Emp emp)
        {
            if(id != emp.Empno)
            {
                return BadRequest();
            }

            if(!db.Emps.Any(e => e.Empno == id))
            {
                return NotFound();
            }
            if(ModelState.IsValid)
            {
                try
                {
                    db.Update(emp);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                catch(Exception ex)
                {
                    if(ex.InnerException != null)
                    {
                        ModelState.AddModelError("", ex.InnerException.Message);
                    }
                    else
                    {
                        ModelState.AddModelError("", ex.Message);
                    }
                }
            }
            return View(emp);
        }


        [HttpGet]
        public IActionResult Delete(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            Emp emp = db.Emps.SingleOrDefault(e => e.Empno == id);

            if (emp == null)
            {
                return NotFound();
            }

            return View(emp);

        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int? id)
        {


            Emp emp = db.Emps.SingleOrDefault(e => e.Empno == id);
                    db.Emps.Remove(emp);
                    db.SaveChanges();
                    return RedirectToAction("Index");       
   
        }
        public IActionResult ViewModelDemo()
        {

            //   var data = (from e in db.Emps join d in db.Depts on e.Deptno equals d.Deptno select new EmpDeptViewModel { Employee = e, Department = d }).ToList();
            //  return View(data);


            //left outer join

            var data = (from e in db.Emps join d in db.Depts on e.Deptno equals d.Deptno into joindata from deptobj in joindata.DefaultIfEmpty() orderby deptobj.Dname select new EmpDeptViewModel { Employee = e, Department = deptobj }).ToList();

            return View(data);
        }
     
    } 

}