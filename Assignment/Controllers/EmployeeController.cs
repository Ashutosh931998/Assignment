using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using Assignment.Models;
using System.Data.Entity;
namespace Assignment.Controllers
{
    public class EmployeeController : Controller
    {
        public static List<EmployeeValidation> lstEmployeevalidation = new List<EmployeeValidation>();
       public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeValidation st)
       {
           lstEmployeevalidation.Add(st);
           if (!ModelState.IsValid)
           {
               return View();
           }
           else
           {
               return RedirectToAction("Index");
           }
       }
        public ActionResult Index()
        {
            return View(lstEmployeevalidation);
        }
        public ActionResult Edit(string id)
        {
            EmployeeValidation st = lstEmployeevalidation.FirstOrDefault(e => e.Name.Equals(id));
            return View(st);
        }
        [HttpPost]
        public ActionResult Edit(EmployeeValidation st)
        {
            EmployeeValidation lst = lstEmployeevalidation.FirstOrDefault(e => e.Name.Equals(st.Name));
            lstEmployeevalidation.Remove(lst);
            lstEmployeevalidation.Add(st);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(string id)
        {
            EmployeeValidation st = lstEmployeevalidation.FirstOrDefault(e => e.Name.Equals(id));
            lstEmployeevalidation.Remove(st);
            return RedirectToAction("Index");

        }

       
	}
}