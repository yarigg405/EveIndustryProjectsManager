using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;


namespace EveIndustry.Data
{
   public class AppContext:DbContext
    {
        public AppContext()
            : base("DbConnection")
        {
        }

        public DbSet<Item> Items { get; set; }

    }
}
