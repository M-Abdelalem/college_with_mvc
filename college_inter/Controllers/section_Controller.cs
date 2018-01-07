using DAl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace college_inter.Controllers
{
    public class section_Controller : Controller
    {
        // GET: student_
        public ActionResult Index(string text)
        {
            DAl.Irepository<Section> s = new section_manager();
            var z = s.select();

            return View(z);
        }



        public ActionResult Edit(Section sections)
        {
            DAl.Irepository<Section> s = new section_manager();

            s.update(sections);
            return View();


        }
        public ActionResult Delete(Section sections)
        {
            DAl.Irepository<Section> s = new section_manager();

            s.delete(sections);

            return RedirectToAction("Index");
        }


        public ActionResult Create() { return View(); }
        [HttpPost]
        public ActionResult Create(Section sections)
        {
            DAl.Irepository<Section> s = new section_manager();

            s.add(sections);
            return View();


        }
   

    }
}