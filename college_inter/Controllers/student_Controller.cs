using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAl;
namespace coullege_interface.Controllers
{
    public class student_Controller : Controller
    {
        // GET: student_
        public ActionResult Index(string text)
        {
            DAl.Irepository<Student> s = new student_manager();
            var z = s.select();
       
            if(!string.IsNullOrEmpty(text))
            {
           z= from item in z
                   where (item.Name.Contains(text))
                   select item;

                
            }
            return View(z);
        }
        public ActionResult Edit(Student student)
        {
            DAl.Irepository<Student> s = new student_manager();

             s.update(student);
             return View();

            
        }
        public ActionResult Delete(Student student)
        {
            DAl.Irepository<Student> s = new student_manager();

             s.delete(student);

            return RedirectToAction("Index");
        }


        public ActionResult Create() { return View(); }
        [HttpPost]
        public ActionResult Create(Student student)
        {
            DAl.Irepository<Student> s = new student_manager();

            s.add(student);
            return View();


        }
   

    }
}