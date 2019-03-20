using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveIndustry.Data
{
    public class ItemsProduction
    {        
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }

        public string ItemId { get; set; }
        public virtual Item Item { get; set; }

        public int Count { get; set; }
    }
}
