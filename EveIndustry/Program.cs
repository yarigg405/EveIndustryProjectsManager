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

        }

    }
}
