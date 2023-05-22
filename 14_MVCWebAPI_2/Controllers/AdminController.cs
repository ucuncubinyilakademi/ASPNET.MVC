using _14_MVCWebAPI_2.Context;
using _14_MVCWebAPI_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Permissions;
using System.Web.Http;

namespace _14_MVCWebAPI_2.Controllers
{
    public class AdminController : ApiController
    {
        DataContext context = new DataContext();

        public List<Product> GetProducts()
        {
            return context.Products.ToList();
        }

        public IHttpActionResult GetProduct(int id)
        {
            return Ok(context.Products.Find(id));
        }

        [HttpPost]
        public IHttpActionResult PostProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            return Ok();
        }


        [HttpPut]
        public IHttpActionResult PutProduct(int id,Product model)
        {
            var product = context.Products.Find(id);

            product.ImageUrl = model.ImageUrl;
            product.Price = model.Price;
            product.Stock = model.Stock;
            product.Name = model.Name;

            context.SaveChanges();
            return Ok();
        }


        [HttpDelete]
        public IHttpActionResult DeleteProduct(int id)
        {
            var product = context.Products.Find(id);
            context.Products.Remove(product);
            context.SaveChanges();

            return Ok();
        }
    }
}
