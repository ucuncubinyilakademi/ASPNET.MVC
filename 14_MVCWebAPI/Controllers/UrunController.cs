using _14_MVCWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _14_MVCWebAPI.Controllers
{
    public class UrunController : ApiController
    {
        /*
         WEB API farklı modüller(projeler) arasında haberleşmeyi sağlar. XML,Json yapılarıyla tanımlanırlar. 
        5 temel metodu vardır.
        GET:  api/Controllername yazıldığında çalışır. ve tanımlı yapıların hepsini listeler.
        GET(id) : api/Controllername/id yazıldığında çalışır. ve id ye sahip yapıyı listeler.
         
         */


        private List<Urun> urunList = new List<Urun>()
        {
            new Urun{Id=1,Ad="Masaüstü Bilgisayar",Fiyat=3000,KategoriAd="Bilgisayar",StokMiktari=100},
            new Urun{Id=2,Ad="Dizüstü Bilgisayar",Fiyat=2000,KategoriAd="Bilgisayar",StokMiktari=1004},
            new Urun{Id=3,Ad="Cep Telefonu",Fiyat=4000,KategoriAd="Telefon",StokMiktari=100},
            new Urun{Id=4,Ad="Ev Telefonu",Fiyat=5000,KategoriAd="Telefon",StokMiktari=100}
        };


        public IEnumerable<Urun> GetAllUrun()
        {
            return urunList;
        }


        public IHttpActionResult GetUrun(int id)
        {
            var urun = urunList.FirstOrDefault(i => i.Id == id);

            if (urun == null)
            {
                return NotFound();
            }

            return Ok(urun);
        }
    }
}
