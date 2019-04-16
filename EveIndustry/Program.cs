using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EveIndustry.Data;
using EveIndustry.Forms;
using System.IO;
using YamlDotNet.Serialization;
using YamlDotNet;
using YamlDotNet.RepresentationModel;
using yamldotnet;




namespace EveIndustry
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static DataBaseContext DataBase;
        public static string regionId = "10000002"; //id региона для загрузки цен (Jita)

        [STAThread]
        static void Main()
        {
            Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }


        private static void Initialize()
        {
            DataBase = new DataBaseContext();
            // LoadItemsDataBase();
            LoadBlueprints();
        }

        private static void LoadBlueprints()
        {
            var filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                + "\\blueprints.yaml";

            var deserializer = new Deserializer();

            string text = System.IO.File.ReadAllText(filePath);
            var input = new StringReader(text);

            var blueprintsById = deserializer.Deserialize
                <Dictionary<int, YamlBlueprint>>(input);


            //LoadBlueprintsToDataBase(blueprintsById);

        }

        //private static void LoadBlueprintsToDataBase
        //    (Dictionary<int, YamlBlueprint> blueprints)
        //{
        //    foreach (var pair in blueprints)
        //    {
        //        Blueprint bp = new Blueprint();
        //        bp.BlueprintId = pair.Key.ToString();

        //        if (pair.Value.activities.copying != null)
        //        {
        //            bp.CopyingTime = pair.Value.activities.copying.time;
        //            if (pair.Value.activities.copying.materials != null)
        //                foreach (var item in pair.Value.activities.copying.materials)
        //                {
        //                    bp.CopyingItems.Add(new CopyingItemsList
        //                    {
        //                        ItemId = item.typeID.ToString(),
        //                        Count = item.quantity,
        //                    });
        //                }
        //            if (pair.Value.activities.copying.skills != null)
        //                foreach (var item in pair.Value.activities.copying.skills)
        //                {
        //                    bp.CopyingSkills.Add(new CopyingSkillList
        //                    {
        //                        SkillId = item.typeID.ToString(),
        //                        Level = item.level,
        //                    });
        //                }
        //        }

        //        if (pair.Value.activities.invention != null)
        //        {
        //            if (pair.Value.activities.invention.products != null)
        //            {
        //                bp.InventionTime = pair.Value.activities.invention.time;
        //                bp.InventionProbability = pair.Value.activities
        //                    .invention.products[0].probability;
        //                bp.InventionQuantity = pair.Value.activities
        //                    .invention.products[0].quantity;
        //            }

        //            if (pair.Value.activities.invention.materials != null)
        //                foreach (var item in pair.Value.activities.invention.materials)
        //                {
        //                    bp.InventionItems.Add(new InventionItemsList
        //                    {
        //                        ItemId = item.typeID.ToString(),
        //                        Count = item.quantity,
        //                    });
        //                }
        //            if (pair.Value.activities.invention.skills != null)
        //                foreach (var item in pair.Value.activities.invention.skills)
        //                {
        //                    bp.InventionSkills.Add(new InventionSkillList
        //                    {
        //                        SkillId = item.typeID.ToString(),
        //                        Level = item.level,
        //                    });
        //                }
        //        }


        //        if (pair.Value.activities.manufacturing != null &&
        //            pair.Value.activities.manufacturing.products != null)
        //        {
        //            bp.ManufacturingTime = pair.Value.activities.manufacturing.time;
        //            bp.ManufacturingQuantity = pair.Value.activities
        //                .manufacturing.products[0].quantity;
        //            bp.ManufacturingItemId = pair.Value.activities
        //                .manufacturing.products[0].typeID.ToString();
        //            if (pair.Value.activities.manufacturing.materials != null)
        //                foreach (var item in pair.Value.activities.manufacturing.materials)
        //                {
        //                    bp.ManufacturingItems.Add(new ManufacturingItemsList
        //                    {
        //                        ItemId = item.typeID.ToString(),
        //                        Count = item.quantity,
        //                    });
        //                }
        //            if (pair.Value.activities.manufacturing.skills != null)
        //                foreach (var item in pair.Value.activities.manufacturing.skills)
        //                {
        //                    bp.ManufacturingSkills.Add(new ManufacturingSkillList
        //                    {
        //                        SkillId = item.typeID.ToString(),
        //                        Level = item.level,
        //                    });
        //                }
        //        }

        //        if (pair.Value.activities.research_material != null)
        //        {
        //            bp.ResearchMaterialTime = pair.Value.activities.research_material.time;
        //            if (pair.Value.activities.research_material.materials != null)
        //                foreach (var item in pair.Value.activities.research_material.materials)
        //                {
        //                    bp.ResearchMaterialItems.Add(new ResearchMaterialItemsList
        //                    {
        //                        ItemId = item.typeID.ToString(),
        //                        Count = item.quantity,
        //                    });
        //                }
        //            if (pair.Value.activities.research_material.skills != null)
        //                foreach (var item in pair.Value.activities.research_material.skills)
        //                {
        //                    bp.ResearchMaterialSkills.Add(new ResearchMaterialSkillList
        //                    {
        //                        SkillId = item.typeID.ToString(),
        //                        Level = item.level,
        //                    });
        //                }
        //        }

        //        if (pair.Value.activities.research_time != null)
        //        {
        //            bp.ResearchTimeTime = pair.Value.activities.research_time.time;
        //            if (pair.Value.activities.research_time.materials != null)
        //                foreach (var item in pair.Value.activities.research_time.materials)
        //                {
        //                    bp.ResearchTimeItems.Add(new ResearchTimeItemsList
        //                    {
        //                        ItemId = item.typeID.ToString(),
        //                        Count = item.quantity,
        //                    });
        //                }
        //            if (pair.Value.activities.research_time.skills != null)
        //                foreach (var item in pair.Value.activities.research_time.skills)
        //                {
        //                    bp.ResearchTimeSkills.Add(new ResearchTimeSkillList
        //                    {
        //                        SkillId = item.typeID.ToString(),
        //                        Level = item.level,
        //                    });
        //                }
        //        }
        //        DataBase.Blueprints.Add(bp);
        //    }
        //    DataBase.SaveChanges();

        //    foreach (var pair in blueprints)
        //    {
        //        Blueprint bp = DataBase.Blueprints
        //            .FirstOrDefault(x => x.BlueprintId == pair.Key.ToString());

        //        if (pair.Value.activities.invention.products != null)
        //            foreach (var child in pair.Value.activities.invention.products)
        //            {
        //                Blueprint childBp = DataBase.Blueprints
        //                    .FirstOrDefault(x => x.BlueprintId == child.typeID.ToString());
        //                bp.InventionBlueprints.Add(childBp);
        //                childBp.ParentBlueprintId = bp.ParentBlueprintId;

        //            }

        //    }
        //    DataBase.SaveChanges();

        //}

        //private static void LoadItemsDataBase()
        //{
        //    var filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        //        + "\\AllItemsId.txt";

        //    using (StreamReader sr = new StreamReader(filePath))
        //    {
        //        while (!sr.EndOfStream)
        //        {
        //            var input = sr.ReadLine().Split('|');
        //            Item item = new Item
        //            {
        //                Id = input[0],
        //                Name = input[1],
        //            };

        //            DataBase.Items.Add(item);
        //        }

        //        DataBase.SaveChanges();
        //    }
        //}


    }
}
