using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EveIndustry.Data;
using System.Text.RegularExpressions;


namespace EveIndustry.Forms
{
    public partial class PurchasesListForm : _BaseForm
    {

        private List<Project> projects = new List<Project>();
        private Dictionary<string, int> itemsModernisations = new Dictionary<string, int>();
        private Dictionary<string, int> itemsProductions = new Dictionary<string, int>();


        public PurchasesListForm(List<Project> projectsList)
        {
            InitializeComponent();
            InitializeBaseForm();

            CalculateLists(projectsList);
            projects = projectsList;

            RefreshTables();
        }


        private void RefreshTables()
        {
            RefreshModernisationDG();
            RefreshProductionDG();
        }

        private void RefreshModernisationDG()
        {
            modernisationsItemsDataGridView.Rows.Clear();

            foreach (var pair in itemsModernisations)
            {
                var num = modernisationsItemsDataGridView.Rows.Add();
                var row = modernisationsItemsDataGridView.Rows[num];

                row.Cells["itemName"].Value = pair.Key;
                row.Cells["itemCount"].Value = pair.Value;
            }

        }

        private void RefreshProductionDG()
        {
            productionsItemsDataGridView.Rows.Clear();

            foreach (var pair in itemsProductions)
            {
                var num = productionsItemsDataGridView.Rows.Add();
                var row = productionsItemsDataGridView.Rows[num];

                row.Cells["itemName1"].Value = pair.Key;
                row.Cells["itemCount1"].Value = pair.Value;
            }

        }

        private void CalculateLists(List<Project> projects)
        {
            foreach (var proj in projects)
            {
                foreach (var item in proj.ModernisationItems)
                {
                    if (!itemsModernisations.ContainsKey(item.Item.Name))
                        itemsModernisations.Add(item.Item.Name, 0);
                    itemsModernisations[item.Item.Name] += item.Count;
                }

                foreach (var item in proj.ProductionsItems)
                {
                    if (!itemsProductions.ContainsKey(item.Item.Name))
                        itemsProductions.Add(item.Item.Name, 0);
                    itemsProductions[item.Item.Name] += item.Count;
                }
            }



        }

        private string[] ParseString(string str)
        {
            try
            {
                string name = Regex.Match(str, @"()(.*?)(\*)").Value.Replace("*", "");
                string count = Regex.Matches(str, @"\s[0-9]*\s")[0].Value;

                return new string[]
                     {
                        name,
                        count,
                     };
            }

            catch
            {
                return new string[]
                    {
                        "",
                        "",
                    };
            }
        }       

        private int ParseCount(string str)
        {
            while (str.Contains(" "))
                str = str.Replace(" ", "");

            try
            {
                return int.Parse(str);
            }

            catch
            {
                MessageBox.Show("ERROR\n#" + str + "#");
                return 0;
            }

        }





        private void dropToRemoveButton_Click(object sender, EventArgs e)
        {
            importExportRichTextBox.Text = Clipboard.GetText();

            var separator = new string[] { "ISK" };

              foreach (string str in importExportRichTextBox.Text.Split(separator,StringSplitOptions.RemoveEmptyEntries))
          //  foreach (string str in importExportRichTextBox.Text.Split('\n'))
            {
                var output = ParseString(str);
                var itemStr = output[0];
                var countStr = output[1];

                if (itemStr != "")
                {
                    var count = ParseCount(countStr);
                    if (itemsModernisations.ContainsKey(itemStr))
                    {
                        itemsModernisations[itemStr] -= count;
                        if (itemsModernisations[itemStr] < 0)
                            itemsModernisations.Remove(itemStr);
                    }

                    if (itemsProductions.ContainsKey(itemStr))
                    {
                        itemsProductions[itemStr] -= count;
                        if (itemsProductions[itemStr] < 0)
                            itemsProductions.Remove(itemStr);
                    }
                }
            }
            importExportRichTextBox.Clear();
            RefreshTables();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in itemsModernisations)
            {
                sb.Append(item.Key);
                sb.Append("\t");
                sb.Append(item.Value);
                sb.Append("\n");
            }

            for (int i = 0; i < 5; i++)
            {
                sb.Append(" ");
                sb.Append("\t");
                sb.Append(" ");
                sb.Append("\n");
            }

            foreach (var item in itemsProductions)
            {
                sb.Append(item.Key);
                sb.Append("\t");
                sb.Append(item.Value);
                sb.Append("\n");
            }

            importExportRichTextBox.Text = sb.ToString();
            Clipboard.SetText(importExportRichTextBox.Text);
            importExportRichTextBox.Clear();

        }

        private void exportProjectsInfoButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var proj in projects)
            {
                sb.Append(proj.Name);
                sb.Append("\t");

                foreach (var item in proj.ModernisationItems)
                {
                    sb.Append(item.Item.Name);
                    sb.Append("\t");
                }
                sb.Append("\n");
            }

            importExportRichTextBox.Text = sb.ToString();
            Clipboard.SetText(importExportRichTextBox.Text);
            importExportRichTextBox.Clear();
        }
    }
}
