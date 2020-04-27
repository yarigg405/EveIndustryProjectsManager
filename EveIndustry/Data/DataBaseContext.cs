using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;


namespace EveIndustry.Data
{
    public class DataBaseContext : DbContext
    {
#if DEBUG
        public DataBaseContext()
            : base("DBTestConnection")
        {
        }
#else
        public DataBaseContext()
            : base("DBConnection")
        {
        }
#endif




        public DbSet<Item> Items { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Blueprint> Blueprints { get; set; }


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
                .HasForeignKey(i => i.ItemId)
                .WillCascadeOnDelete(false);



            modelBuilder.Entity<ItemsProduction>()
                .HasKey(i => new { i.ProjectId, i.ItemId });

            modelBuilder.Entity<Project>()
                .HasMany(m => m.ProductionsItems)
                .WithRequired()
                .HasForeignKey(i => i.ProjectId);

            modelBuilder.Entity<Item>()
                .HasMany(i => i.ItemsProductions)
                .WithRequired()
                .HasForeignKey(i => i.ItemId)
                .WillCascadeOnDelete(false);


            modelBuilder.Entity<Item>()
                .HasOptional(i => i.Order)
                .WithRequired(or => or.Item)
                .WillCascadeOnDelete(false);



            modelBuilder.Entity<CopyingItemsList>()
                .HasKey(x => new { x.BlueprintId, x.ItemId });
            modelBuilder.Entity<InventionItemsList>()
                .HasKey(x => new { x.BlueprintId, x.ItemId });
            modelBuilder.Entity<ManufacturingItemsList>()
                .HasKey(x => new { x.BlueprintId, x.ItemId });
            modelBuilder.Entity<ResearchMaterialItemsList>()
                .HasKey(x => new { x.BlueprintId, x.ItemId });
            modelBuilder.Entity<ResearchTimeItemsList>()
                .HasKey(x => new { x.BlueprintId, x.ItemId });

            modelBuilder.Entity<CopyingSkillList>()
                .HasKey(x => new { x.BlueprintId, x.SkillId });
            modelBuilder.Entity<InventionSkillList>()
                .HasKey(x => new { x.BlueprintId, x.SkillId });
            modelBuilder.Entity<ManufacturingSkillList>()
                .HasKey(x => new { x.BlueprintId, x.SkillId });
            modelBuilder.Entity<ResearchMaterialSkillList>()
                .HasKey(x => new { x.BlueprintId, x.SkillId });
            modelBuilder.Entity<ResearchTimeSkillList>()
                .HasKey(x => new { x.BlueprintId, x.SkillId });



            modelBuilder.Entity<Blueprint>()
                .HasMany(x => x.CopyingItems)
                .WithRequired()
                .HasForeignKey(x => x.BlueprintId);
            modelBuilder.Entity<Item>()
                .HasMany(x => x.CopyingItems)
                .WithRequired()
                .HasForeignKey(x => x.ItemId);

            modelBuilder.Entity<Blueprint>()
                .HasMany(x => x.InventionItems)
                .WithRequired()
                .HasForeignKey(x => x.BlueprintId);
            modelBuilder.Entity<Item>()
                .HasMany(x => x.InventionItems)
                .WithRequired()
                .HasForeignKey(x => x.ItemId);

            modelBuilder.Entity<Blueprint>()
                .HasMany(x => x.ManufacturingItems)
                .WithRequired()
                .HasForeignKey(x => x.BlueprintId);
            modelBuilder.Entity<Item>()
                .HasMany(x => x.ManufacturingItems)
                .WithRequired()
                .HasForeignKey(x => x.ItemId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Blueprint>()
                .HasMany(x => x.ResearchMaterialItems)
                .WithRequired()
                .HasForeignKey(x => x.BlueprintId);
            modelBuilder.Entity<Item>()
                .HasMany(x => x.ResearchMaterialItems)
                .WithRequired()
                .HasForeignKey(x => x.ItemId);

            modelBuilder.Entity<Blueprint>()
                .HasMany(x => x.ResearchTimeItems)
                .WithRequired()
                .HasForeignKey(x => x.BlueprintId);
            modelBuilder.Entity<Item>()
                .HasMany(x => x.ResearchTimeItems)
                .WithRequired()
                .HasForeignKey(x => x.ItemId)
                .WillCascadeOnDelete(false);




            modelBuilder.Entity<Blueprint>()
                .HasMany(x => x.CopyingSkills)
                .WithRequired()
                .HasForeignKey(x => x.SkillId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Skill>()
                .HasMany(x => x.CopyingSkills)
                .WithRequired()
                .HasForeignKey(x => x.BlueprintId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Blueprint>()
                .HasMany(x => x.InventionSkills)
                .WithRequired()
                .HasForeignKey(x => x.SkillId);
            modelBuilder.Entity<Skill>()
                .HasMany(x => x.InventionSkills)
                .WithRequired()
                .HasForeignKey(x => x.BlueprintId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Blueprint>()
               .HasMany(x => x.ManufacturingSkills)
               .WithRequired()
               .HasForeignKey(x => x.SkillId);
            modelBuilder.Entity<Skill>()
                .HasMany(x => x.ManufacturingSkills)
                .WithRequired()
                .HasForeignKey(x => x.BlueprintId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Blueprint>()
               .HasMany(x => x.ResearchMaterialSkills)
               .WithRequired()
               .HasForeignKey(x => x.SkillId);
            modelBuilder.Entity<Skill>()
                .HasMany(x => x.ResearchMaterialSkills)
                .WithRequired()
                .HasForeignKey(x => x.BlueprintId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Blueprint>()
               .HasMany(x => x.ResearchTimeSkills)
               .WithRequired()
               .HasForeignKey(x => x.SkillId);
            modelBuilder.Entity<Skill>()
                .HasMany(x => x.ResearchTimeSkills)
                .WithRequired()
                .HasForeignKey(x => x.BlueprintId)
                .WillCascadeOnDelete(false);



        }

    }
}
