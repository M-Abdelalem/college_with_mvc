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
        public ActionResult Index()
        {
            DAl.Irepository<Student> s = new student_manager ();

        var z =s.select();

            return View(z);
        }
    }
}