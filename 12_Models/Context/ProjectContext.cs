using _12_Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _12_Models.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext():base("Server=DESKTOP-G08N4IE\\SQLDERS;Database=LoginRegister;uid=sa;pwd=1")
        {
            
        }

        public DbSet<User> Users { get; set; } 
    }
}