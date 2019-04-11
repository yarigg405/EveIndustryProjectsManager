using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveIndustry.Data
{
    public class Item
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ItemsModernisation> ItemsModernisations { get; set; }
        public virtual ICollection<ItemsProduction> ItemsProductions { get; set; }

        public virtual ICollection<CopyingItemsList> CopyingItems { get; set; }
        public virtual ICollection<InventionItemsList> InventionItems { get; set; }
        public virtual ICollection<ManufacturingItemsList> ManufacturingItems { get; set; }
        public virtual ICollection<ResearchMaterialItemsList> ResearchMaterialItems { get; set; }
        public virtual ICollection<ResearchTimeItemsList> ResearchTimeItems { get; set; }

        public Order Order { get; set; }

        public decimal GetBuyPrice()
        {
            if (Order == null) return 0;

            switch (Program.regionId)
            {
                case "10000002":
                    {
                        return Order.BuyMaxJita;
                    }
                default:
                    throw new Exception("Region with id "
             + Program.regionId
             + " not found");
            }           
        }
        public decimal GetSellPrice()
        {
            if (Order == null) return 0;
            switch (Program.regionId)
            {
                case "10000002":
                    {
                        return Order.SellMinJita;
                    }
                default:
                    throw new Exception("Region with id "
             + Program.regionId
             + " not found");
            }
        }
    }
}
