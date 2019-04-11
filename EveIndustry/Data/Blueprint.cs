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
        public List<CopyingItemsList> CopyingItems { get; set; }
        public List<CopyingSkillList> CopyingSkills { get; set; }

        public int InventionTime { get; set; }
        public float InventionProbability { get; set; }
        public int InventionQuantity { get; set; }
        public List<InventionItemsList> InventionItems { get; set; }
        public List<InventionSkillList> InventionSkills { get; set; }
        public virtual List<Blueprint> InventionBlueprints { get; set; }
        public string ParentBlueprintId { get; set; }
        public virtual Blueprint ParentBlueprint { get; set; }       

        public int ManufacturingTime { get; set; }
        public int ManufacturingQuantity { get; set; }
        public string ManufacturingItemId { get; set; }
        public virtual Item ManufacturingItem { get; set; }
        public List<ManufacturingItemsList> ManufacturingItems { get; set; }
        public List<ManufacturingSkillList> ManufacturingSkills { get; set; }
                     
        public int ResearchMaterialTime { get; set; }
        public List<ResearchMaterialItemsList> ResearchMaterialItems { get; set; }
        public List<ResearchMaterialSkillList> ResearchMaterialSkills { get; set; }

        public int ResearchTimeTime { get; set; }
        public List<ResearchTimeItemsList> ResearchTimeItems { get; set; }
        public List<ResearchTimeSkillList> ResearchTimeSkills { get; set; }



    }
}
