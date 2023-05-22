using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _14_MVCWebAPI_2.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string ImageUrl{ get; set; }
    }
}