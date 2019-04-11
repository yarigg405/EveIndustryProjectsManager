using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveIndustry.Data
{
   public class Skill
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CopyingSkillList> CopyingSkills { get; set; }
        public virtual ICollection<InventionSkillList> InventionSkills { get; set; }
        public virtual ICollection<ManufacturingSkillList> ManufacturingSkills { get; set; }
        public virtual ICollection<ResearchMaterialSkillList> ResearchMaterialSkills { get; set; }
        public virtual ICollection<ResearchTimeSkillList> ResearchTimeSkills { get; set; }
    }
}
