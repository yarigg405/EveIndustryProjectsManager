using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveIndustry.Data
{
    public class Blueprint
    {
        public string BlueprintId { get; set; }

        public int CopyingTime { get; set; }
        public virtual List<CopyingItemsList> CopyingItems { get; set; }
        public virtual List<CopyingSkillList> CopyingSkills { get; set; }

        public int InventionTime { get; set; }
        public float InventionProbability { get; set; }
        public int InventionQuantity { get; set; }
        public virtual List<InventionItemsList> InventionItems { get; set; }
        public virtual List<InventionSkillList> InventionSkills { get; set; }
        public virtual List<Blueprint> InventionBlueprints { get; set; }
        public string ParentBlueprintId { get; set; }
        public virtual Blueprint ParentBlueprint { get; set; }

        public int ManufacturingTime { get; set; }
        public int ManufacturingQuantity { get; set; }
        public string ManufacturingItemId { get; set; }
        public virtual Item ManufacturingItem { get; set; }
        public virtual List<ManufacturingItemsList> ManufacturingItems { get; set; }
        public virtual List<ManufacturingSkillList> ManufacturingSkills { get; set; }

        public int ResearchMaterialTime { get; set; }
        public virtual List<ResearchMaterialItemsList> ResearchMaterialItems { get; set; }
        public virtual List<ResearchMaterialSkillList> ResearchMaterialSkills { get; set; }

        public int ResearchTimeTime { get; set; }
        public virtual List<ResearchTimeItemsList> ResearchTimeItems { get; set; }
        public virtual List<ResearchTimeSkillList> ResearchTimeSkills { get; set; }

        public Blueprint()
        {
            CopyingItems = new List<CopyingItemsList>();
            CopyingSkills = new List<CopyingSkillList>();
            InventionItems = new List<InventionItemsList>();
            InventionSkills = new List<InventionSkillList>();
            InventionBlueprints = new List<Blueprint>();
            ManufacturingItems = new List<ManufacturingItemsList>();
            ManufacturingSkills = new List<ManufacturingSkillList>();
            ResearchMaterialItems = new List<ResearchMaterialItemsList>();
            ResearchMaterialSkills = new List<ResearchMaterialSkillList>();
            ResearchTimeItems = new List<ResearchTimeItemsList>();
            ResearchTimeSkills = new List<ResearchTimeSkillList>();

        }

    }
}
