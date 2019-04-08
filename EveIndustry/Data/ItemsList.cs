using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveIndustry.Data
{
    public abstract class ItemsList
    {
        public string BlueprintId { get; set; }
        public virtual Blueprint Blueprint { get; set; }

        public string ItemId { get; set; }
        public virtual Item Item { get; set; }

        public int Count { get; set; }
    }

}
