using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EveIndustry.Data;
using EveIndustry.Controllers;
using System.Text.RegularExpressions;


namespace EveIndustry.Forms
{
    public partial class ItemsCalculatorForm : _BaseForm
    {
        private Dictionary<Item, int> items = new Dictionary<Item, int>();
        private decimal totalSumm;


        public ItemsCalculatorForm()
        {
            InitializeComponent();
            InitializeBaseForm();

            RefreshDataGrid();
        }


        private void RefreshDataGrid()
        {
            modernisationsItemsDataGridView.Rows.Clear();
            totalSumm = 0;

            foreach (var pair in items)
            {
                var num = modernisationsItemsDataGridView.Rows.Add();
                var row = modernisationsItemsDataGridView.Rows[num];

                row.Cells["itemName"].Value = pair.Key.Name;
                row.Cells["itemCount"].Value = pair.Value;
                row.Cells["itemPrice"].Value = pair.Key.GetSellPrice();
                var summ = pair.Key.GetSellPrice() * pair.Value;
                row.Cells["itemSumm"].Value = summ;
                totalSumm += summ;

            }

            totalSummLabel.Text= "Примерная сумма: " + totalSumm.ToMoney();

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

        private string[] ParseString1(string str)
        {
            try
            {
                string name = Regex.Match(str, @".*\*").Value.Replace("*", "");
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




        private void dropToAddButton_Click(object sender, EventArgs e)
        {
            {
                importExportRichTextBox.Text = Clipboard.GetText();
                              

                foreach (string str in importExportRichTextBox.Text.Split('\n'))
                {
                    var output = ParseString1(str);
                    var itemStr = output[0];
                    var countStr = output[1];

                    if (itemStr != "")
                    {
                        var count = ParseCount(countStr);
                        var item = Program.dataBase.Items.Where(i => i.Name == itemStr).FirstOrDefault();

                        if (!items.ContainsKey(item))
                            items.Add(item, 0);

                        items[item] += count;
                    }
                }
                importExportRichTextBox.Clear();
                RefreshDataGrid();
            }
        }

        private void dropToRemoveButton_Click(object sender, EventArgs e)
        {
            importExportRichTextBox.Text = Clipboard.GetText();

            var separator = new string[] { "ISK" };

            foreach (string str in importExportRichTextBox.Text.Split(separator, StringSplitOptions.RemoveEmptyEntries))
            {
                var output = ParseString(str);
                var itemStr = output[0];
                var countStr = output[1];

                if (itemStr != "")
                {
                    var count = ParseCount(countStr);
                    var item = Program.dataBase.Items.Where(i => i.Name == itemStr).FirstOrDefault();
                    if (items.ContainsKey(item))
                    {
                        items[item] -= count;
                        if (items[item] <= 0)
                            items.Remove(item);
                    }
                }
            }
            importExportRichTextBox.Clear();
            RefreshDataGrid();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in items)
            {
                sb.Append(item.Key.Name);
                sb.Append("\t");
                sb.Append(item.Value);
                sb.Append("\n");
            }

           
            importExportRichTextBox.Text = sb.ToString();
            Clipboard.SetText(importExportRichTextBox.Text);
            importExportRichTextBox.Clear();

        }

    }
}
