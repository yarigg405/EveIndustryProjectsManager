using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;


namespace EveIndustry.Data
{
   public class DataBaseContext:DbContext
    {
        public DataBaseContext()
            : base("DbConnection")
        {
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Project> Projects { get; set; }
        

    }
}
