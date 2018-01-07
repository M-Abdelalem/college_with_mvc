using DAl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace college_inter.Controllers
{
    public class professor_Controller : Controller
    {
        // GET: student_
        public ActionResult Index(string text)
        {
            DAl.Irepository<professor> s = new professor_manager();
            var z = s.select();
       
            if(!string.IsNullOrEmpty(text))
            {
               


           
           z= from item in z
                   where (item.Name.Contains(text))
                   select item;

                
            }
            return View(z);
        }



        public ActionResult Edit(professor professors)
        {
            DAl.Irepository<professor> s = new professor_manager();

            s.update(professors);
             return View();

            
        }
        public ActionResult Delete(professor professors)
        {
            DAl.Irepository<professor> s = new professor_manager();

            s.delete(professors);

            return RedirectToAction("Index");
        }


        public ActionResult Create() { return View(); }
        [HttpPost]
        public ActionResult Create(professor professors)
        {
            DAl.Irepository<professor> s = new professor_manager();

            s.add(professors);
            return View();


        }
   

    }
}
