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
        public DbSet<Order> Orders { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<DataBaseContext>(null);

            modelBuilder.Entity<ItemsModernisation>()
                .HasKey(i => new { i.ProjectId, i.ItemId });

            modelBuilder.Entity<Project>()
                .HasMany(m => m.ModernisationItems)
                .WithRequired()
                .HasForeignKey(i => i.ProjectId);

            modelBuilder.Entity<Item>()
                .HasMany(i => i.ItemsModernisations)
                .WithRequired()
                .HasForeignKey(i => i.ItemId);



            modelBuilder.Entity<ItemsProduction>()
                .HasKey(i => new { i.ProjectId, i.ItemId });

            modelBuilder.Entity<Project>()
                .HasMany(m => m.ProductionsItems)
                .WithRequired()
                .HasForeignKey(i => i.ProjectId);

            modelBuilder.Entity<Item>()
                .HasMany(i => i.ItemsProductions)
                .WithRequired()
                .HasForeignKey(i => i.ItemId);


            modelBuilder.Entity<Item>()
                .HasOptional(i => i.Order)
                .WithRequired(or => or.Item);


        }

    }
}
