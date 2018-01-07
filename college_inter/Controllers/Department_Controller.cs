using DAl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace college_inter.Controllers
{
    public class Department_Controller : Controller
    {
        // GET: Department_
      
        public ActionResult Index(string text)
        {
            DAl.Irepository<Department> s = new department_manager();
            var z = s.select();

            if (!string.IsNullOrEmpty(text))
            {




                z = from item in z
                    where (item.name.Contains(text))
                    select item;


            }
            return View(z);
        }



        public ActionResult Edit(Department Departments)
        {
            DAl.Irepository<Department> s = new department_manager();

            s.update(Departments);
            return View();


        }
        public ActionResult Delete(Department Departments)
        {
            DAl.Irepository<Department> s = new department_manager();

            s.delete(Departments);

            return RedirectToAction("Index");
        }


        public ActionResult Create() { return View(); }
        [HttpPost]
        public ActionResult Create(Department Departments)
        {
            DAl.Irepository<Department> s = new department_manager();

            s.add(Departments);
            return View();


        }
   

    }
}