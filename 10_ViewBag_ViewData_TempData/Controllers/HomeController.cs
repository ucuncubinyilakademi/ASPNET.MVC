using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _10_ViewBag_ViewData_TempData.Controllers
{
    public class HomeController : Controller
    {
        //Controller dan View e Data Gönderme : ViewBag,ViewData - TempData 
        /*
         ViewBag,ViewData bir yükleme süresince datayı sayfaya taşır.
         TempData iki yükleme süresince datayı taşıyabilir.
         */
        public ActionResult Index()
        {
            ViewBag.ad = "Altan Emre";
            ViewBag.yas = 33;
            ViewData["soyad"] = "Demirci";
            TempData["brans"] = "YAZILIM";
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}