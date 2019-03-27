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
        public int ItemId { get; set; }
        public virtual Item Item { get; set; }
        public int BlueprintsCount { get; set; }
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
            decimal result = 0;
            foreach (var item in ModernisationItems)
            {
                result += (item.Count * item.Item.GetSellPrice());
            }

            return result;

        }

        public decimal GetProdustionCost()
        {
            decimal result = 0;
            foreach (var item in ProductionsItems)
            {
                result += (item.Count * item.Item.GetSellPrice());
            }

            return result;
        }

        public decimal GetReadyItemsCost()
        {
            if (Item == null) return 0;
            return
                Item.GetSellPrice()
                * BlueprintsCount
                * ItemsCount;
        }

        public decimal GetProfit()
        {
            return
                GetReadyItemsCost()
                - GetProdustionCost()
                - GetModernisationCost();
        }   
        

    }
}
