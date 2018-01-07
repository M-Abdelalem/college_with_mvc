using DAl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace college_inter.Controllers
{
    public class course_Controller : Controller
    {
        // GET: course_
        public ActionResult Index(string text)
        {
            DAl.Irepository<Course> s = new course_manager();
            var z = s.select();

            if (!string.IsNullOrEmpty(text))
            {
                z = from item in z
                    where (item.Name.Contains(text))
                    select item;


            }
            return View(z);
        }

        public ActionResult Edit(Course Courses)
        {
            DAl.Irepository<Course> s = new course_manager();

            s.update(Courses);
            return View();


        }
        public ActionResult Delete(Course Courses)
        {
            DAl.Irepository<Course> s = new course_manager();

            s.delete(Courses);

            return RedirectToAction("Index");
        }


        public ActionResult Create() { return View(); }
        [HttpPost]
        public ActionResult Create(Course Courses)
        {
            DAl.Irepository<Course> s = new course_manager();

            s.add(Courses);
            return View();


        }
   

    }
}