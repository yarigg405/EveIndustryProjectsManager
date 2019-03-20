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

    }
}
