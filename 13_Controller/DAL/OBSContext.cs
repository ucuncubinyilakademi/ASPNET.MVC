using _13_Controller.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace _13_Controller.DAL
{
    public class OBSContext:DbContext
    {
        public OBSContext() : base("OBSVeritabani") { }

        public DbSet<Fakulte> Fakulteler { get; set; }      

        // Tablo adında s takısı getirmemesi için yazdık.
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}