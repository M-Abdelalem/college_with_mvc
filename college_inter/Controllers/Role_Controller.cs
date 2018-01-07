using DAl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace college_inter.Controllers
{
    public class Role_Controller : Controller
    {
        // GET: Role_
        public ActionResult Index(string text)
        {
            DAl.Irepository<Role> s = new Role_manager();
            var z = s.select();

            if (!string.IsNullOrEmpty(text))
            {

                z = from item in z
                    where (item.Email.Contains(text))
                    select item;


            }
            return View(z);
        }



        public ActionResult Edit(Role Roles)
        {
            DAl.Irepository<Role> s = new Role_manager();

            s.update(Roles);
            return View();


        }
        public ActionResult Delete(Role Roles)
        {

            DAl.Irepository<Role> s = new Role_manager();


            s.delete(Roles);

            return RedirectToAction("Index");
        }


        public ActionResult Create() { return View(); }
        [HttpPost]
        public ActionResult Create(Role Roles)
        {
            DAl.Irepository<Role> s = new Role_manager();

            s.add(Roles);
            return View();


        }
   

    }
}