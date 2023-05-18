using _12_Models.Context;
using _12_Models.Entities;
using _12_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _12_Models.Controllers
{
    public class HomeController : Controller
    {
        private ProjectContext db = new ProjectContext();
       
        public ActionResult Index()
        {
            /*List<User> liste*/
            var liste = db.Users.ToList();
            return View(liste);
        }

        public ActionResult Register()
        {
            //RegisterViewModel m = new RegisterViewModel();
            //var m = new RegisterViewModel();

            //return View(m);

            return View(new RegisterViewModel());
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = new User();
                user.Surname = model.Surname;
                user.Username = model.Username;
                user.Password = model.Password;
                user.Name = model.Name;
                user.Email = model.Email;
                user.Address = model.Address;

                db.Users.Add(user);
                db.SaveChanges();

                return View("login");
            }
            return View(model);
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
               var user= db.Users.Where(u => u.Email == model.Email && u.Password == model.Password).FirstOrDefault();

                if (user == null)
                {
                    if (db.Users.Any(i => i.Email == model.Email)==false)
                    {
                        ModelState.AddModelError("", "Email Hatalı");
                    }
                    if(db.Users.Any(i => i.Password == model.Password) == false)
                    {
                        ModelState.AddModelError("", "Şifreniz Hatalı");
                    }                  
                   
                    return View(model);
                }
                return View("Index");
            }

            return View();
        }
    }
}