using _13_Controller.DAL;
using _13_Controller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _13_Controller.Controllers
{
    public class HomeController : Controller
    {
        OBSContext db = new OBSContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public RedirectResult Ekle(Fakulte kayit)
        {
            db.Fakulteler.Add(kayit);
            db.SaveChanges();

            return Redirect("https://www.google.com");
        }

        public JsonResult Listele()
        {
            var liste = db.Fakulteler.ToList();
            return Json(liste);
        }

        public ActionResult FakultelerJson()
        {
            return View();
        }
    }
}