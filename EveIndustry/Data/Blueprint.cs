using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveIndustry.Data
{
    public class Blueprint
    {
        public string BlueprintId { get; set; }

        public int CopyringTime { get; set; }
        public List<SkillListCopyring> CopyringSkills { get; set; }
        public List<ItemsListCopyring> CopyringItems { get; set; }





    }
}
