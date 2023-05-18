using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _11_POST.Controllers
{
    public class HomeController : Controller
    {
        //GET: Home
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost] //Attribute
        public ActionResult Register(string isim, string soyisim,string email)
        {
            return View();
        }
    }
}