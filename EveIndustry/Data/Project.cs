using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveIndustry.Data
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public long ProductionTime { get; set; }
        public Item ExitItem { get; set; }
        public int ItemsCount { get; set; }

        public virtual List<ItemsModernisation> ModernisationItems { get; set; }
        public virtual List<ItemsProduction> ProductionsItems { get; set; }

        public Project()
        {
            ModernisationItems = new List<ItemsModernisation>();
            ProductionsItems = new List<ItemsProduction>();
        }



        public decimal GetModernisationCost()
        {
            return 0;
        }

        public decimal GetProdustionCost()
        {
            return 0;
        }

        public decimal GetReadyItemsCost()
        {
            return 0;
        }

        public decimal GetProfit()
        {
            return 0;
        }       
    }
}
