using _14_MVCWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _14_MVCWebAPI.Controllers
{
    public class NorthwindController : ApiController
    {
        NorthwindEntities db = new NorthwindEntities();

        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            List<Product> liste = new List<Product>();

            foreach (var item in db.Products.ToList())
            {
                Product p = new Product();
                p.Id = item.ProductID;
                p.Price = (int)item.UnitPrice;
                p.Name = item.ProductName;

                liste.Add(p);
            }

            return liste;
        }

        public IHttpActionResult GetProducts(int id)
        {
            var p = db.Products.FirstOrDefault(i => i.ProductID == id);

            return Ok(new Product() { Id = p.ProductID, Name = p.ProductName, Price = p.UnitPrice });
        }

        [HttpPost]
        public IHttpActionResult PostProducts(Product p)
        {
            Products products = new Products() { ProductID = p.Id, ProductName = p.Name, UnitPrice = p.Price };
            db.Products.Add(products);
            db.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult DeleteProducts(int id)
        {
            var product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();

            return Ok();
        }

    }
}

