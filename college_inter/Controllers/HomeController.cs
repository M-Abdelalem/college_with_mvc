using DAl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace college_inter.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        
        }

   [HttpPost]
        public ActionResult Indexs(Role role)
        {
            DAl.Irepository<Role> s = new Role_manager();

            foreach (var z in s.select())
            {

                //string email;
                //string password;

                //HttpCookie local = Request.Cookies["server"];
                // local.Values["name"];
                // local.Values["password"];
                if(z.Email== role.Email && z.Password== role.Password)
                {
                return RedirectToAction("index", "student_");
                }

                
            }




            return View();
        }
       
        
    }
}