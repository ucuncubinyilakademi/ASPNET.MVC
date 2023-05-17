using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01_Empty_MVC.Controllers
{
    public class HomeController : Controller
    {
        /*
         * Asp.net MVC projelerinde ilk olarak varsa eğer entity(class) yapıları tanımlanır.
         * Controller oluşturulur ve anasayfa ve bağlantıda olduğu bütün Html tasarımları için genelde HOME adında HomeController açılır. Default olarak anasayfayı temsil eden INDEX adında bir method gelir. Bu method ActionResult tipinde değer döndüren bir metottur. ActionResult = Html kodlarına sahipi bir sayfa. Controller altındaki ActionResult döndüren her metot bir sayfayı açar. Açılan her CONTROLLER yapısı için VIEWS altında controller ile aynı isimde bir klasör açılır bu klasçr o controller a ait sayfaları tutar.
         * 
         
         */
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
    }
}