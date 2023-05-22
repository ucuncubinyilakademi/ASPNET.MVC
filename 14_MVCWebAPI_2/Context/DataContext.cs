using _14_MVCWebAPI_2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _14_MVCWebAPI_2.Context
{
    public class DataContext:DbContext
    {
        public DataContext():base("Server=DESKTOP-G08N4IE\\SQLDERS;Database=ProductDB;Integrated Security=true")
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}