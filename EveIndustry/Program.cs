using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EveIndustry.Data;
using EveIndustry.Forms;
using System.IO;


namespace EveIndustry
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static DataBaseContext dataBase;
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
            dataBase = new DataBaseContext();
            // LoadItemsDataBase();
        }

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

        //            dataBase.Items.Add(item);
        //        }

        //        dataBase.SaveChanges();
        //    }
        //}


    }
}
