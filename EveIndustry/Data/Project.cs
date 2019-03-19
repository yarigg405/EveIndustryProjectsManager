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

        public virtual IEnumerable<ItemsResearch> ResearchesItems { get; set; }
        public virtual IEnumerable<ItemsProduction> ProductionsItems { get; set; }


    }
}
