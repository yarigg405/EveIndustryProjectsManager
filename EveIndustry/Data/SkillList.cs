using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveIndustry.Data
{
    public abstract class SkillList
    {
        public string BlueprintId { get; set; }
        public virtual Blueprint Blueprint { get; set; }

        public string SkillId { get; set; }
        public virtual Skill Skill { get; set; }

        public int Level { get; set; }
    }
}
