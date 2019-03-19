using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveIndustry.Data
{
    public class ItemsProduction
    {
        public virtual Project Project { get; set; }
        public Item Item { get; set; }
        public int Count { get; set; }
    }
}
