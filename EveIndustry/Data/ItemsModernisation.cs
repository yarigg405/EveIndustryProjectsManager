using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveIndustry.Data
{
    public class ItemsModernisation
    {
        [Key]
        [Column(Order = 1)]
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }

        [Key]
        [Column(Order = 2)]
        public int ItemId { get; set; }
        public virtual Item Item { get; set; }

        public int Count { get; set; }
    }
}
