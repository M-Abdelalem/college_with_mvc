using DAl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace college_inter.Controllers
{
    public class rigister_Controller : Controller
    {
        // GET: rigister_
        public ActionResult Index(string text)
        {
            DAl.Irepository<Registration> s = new registration_manager();
            var z = s.select();

           
            return View(z);
        }
        public ActionResult Edit(Registration Registrations)
        {
            DAl.Irepository<Registration> s = new registration_manager();

            s.update(Registrations);
            return View();


        }
        public ActionResult Delete(Registration Registrations)
        {
            DAl.Irepository<Registration> s = new registration_manager();

            s.delete(Registrations);

            return RedirectToAction("Index");
        }


        public ActionResult Create() { return View(); }
        [HttpPost]
        public ActionResult Create(Registration Registrations)
        {
            DAl.Irepository<Registration> s = new registration_manager();

            s.add(Registrations);
            return View();


        }
   
    }
}