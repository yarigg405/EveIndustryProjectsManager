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
        private Dictionary<Item, int> neededItems = new Dictionary<Item, int>();
        private Dictionary<Item, int> currentItems = new Dictionary<Item, int>();
        private Dictionary<Item, int> resultItems;

        public ItemsCalculatorForm()
        {
            InitializeComponent();
            InitializeBaseForm();

            RefreshDataGrids();
        }

        public void RefreshDataGrids()
        {
            RefreshNeededDataGrid();
            RefreshCurrentDataGrid();
            RefreshResultDataGrid();
        }

        public void RefreshNeededDataGrid()
        {
            RefreshDataGrid(neededItems, neededDataGrdV, totalNeedSummLabel);

        }

        public void RefreshCurrentDataGrid()
        {
            RefreshDataGrid(currentItems, currentDataGrdV, totalCurrentSummLabel);
        }

        public void RefreshResultDataGrid()
        {
            resultItems = new Dictionary<Item, int>();
            foreach (var needed in neededItems)
            {
                var item = needed.Key;
                var count = needed.Value;

                if (currentItems.ContainsKey(item))
                    count -= currentItems[item];

                if (count > 0)
                    resultItems.Add(item, count);
            }

            RefreshDataGrid(resultItems, resultDataGrdV, totalResultSummLabel);

        }


        private void RefreshDataGrid(Dictionary<Item, int> items,
            DataGridView dataGrid, Label summLabel)
        {
            dataGrid.Rows.Clear();
            decimal totalSumm = 0;

            foreach (var pair in items)
            {
                var num = dataGrid.Rows.Add();
                var row = dataGrid.Rows[num];

                row.Cells[0].Value = pair.Key.Name;
                row.Cells[1].Value = pair.Value;
                row.Cells[2].Value = pair.Key.GetSellPrice();
                var summ = pair.Key.GetSellPrice() * pair.Value;
                row.Cells[3].Value = summ;

                totalSumm += summ;
            }

            summLabel.Text = totalSumm.ToMoney();
        }





        //private string[] ParseString(string str)
        //{
        //    try
        //    {
        //        string name = Regex.Match(str, @"()(.*?)(\*)").Value.Replace("*", "");
        //        string count = Regex.Matches(str, @"\s[0-9]*\s")[0].Value;

        //        return new string[]
        //             {
        //                name,
        //                count,
        //             };
        //    }

        //    catch
        //    {
        //        return new string[]
        //            {
        //                "",
        //                "",
        //            };
        //    }
        //}

        //private string[] ParseString1(string str)
        //{
        //    try
        //    {
        //        string name = Regex.Match(str, @".*\*").Value.Replace("*", "");
        //        string count = Regex.Matches(str, @"\s[0-9]*\s")[0].Value;

        //        return new string[]
        //             {
        //                name,
        //                count,
        //             };
        //    }

        //    catch
        //    {
        //        return new string[]
        //            {
        //                "",
        //                "",
        //            };
        //    }

        //}


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

        private Dictionary<Item, int> GetItemsFromStrings(List<string[]> input)
        {
            var result = new Dictionary<Item, int>();
            foreach (var str in input)
            {
                var name = str[0];
                Item item = Program.DataBase.Items.FirstOrDefault(x => x.Name == name);
                if (item != null)
                {
                    int count = ParseCount(str[1]);

                    if (!result.ContainsKey(item))
                        result.Add(item, count);
                    else
                        result[item] += count;
                }
            }

            return result;

        }




        private void dropToAddButton_Click(object sender, EventArgs e)
        {
            importExportRichTextBox.Text = Clipboard.GetText();
            var strings = Extensions.ParseText(importExportRichTextBox.Text);
            var items = GetItemsFromStrings(strings);

            foreach (var item in items)
            {
                if (!neededItems.ContainsKey(item.Key))
                    neededItems.Add(item.Key, 0);

                neededItems[item.Key] += item.Value;
            }
            RefreshNeededDataGrid();
            RefreshResultDataGrid();
            importExportRichTextBox.Clear();

        }



        //        foreach (string str in importExportRichTextBox.Text.Split('\n'))
        //        {
        //            var output = ParseString1(str);
        //            var itemStr = output[0];
        //            var countStr = output[1];

        //            if (itemStr != "")
        //            {
        //                var count = ParseCount(countStr);
        //                var item = Program.dataBase.Items.Where(i => i.Name == itemStr).FirstOrDefault();

        //                if (!items.ContainsKey(item))
        //                    items.Add(item, 0);

        //                items[item] += count;
        //            }
        //        }
        //        importExportRichTextBox.Clear();
        //        RefreshDataGrid();
        //    }
        //}

        private void dropToRemoveButton_Click(object sender, EventArgs e)
        {
            importExportRichTextBox.Text = Clipboard.GetText();
            var strings = Extensions.ParseText(importExportRichTextBox.Text);
            var items = GetItemsFromStrings(strings);

            foreach (var item in items)
            {
                if (!currentItems.ContainsKey(item.Key))
                    currentItems.Add(item.Key, 0);

                currentItems[item.Key] += item.Value;
            }
            RefreshCurrentDataGrid();
            RefreshResultDataGrid();
            importExportRichTextBox.Clear();

        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in resultItems)
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

        private void clearNeededListButton_Click(object sender, EventArgs e)
        {
            neededItems.Clear();
            RefreshNeededDataGrid();
            RefreshResultDataGrid();
        }

        private void clearCurrentListButton_Click(object sender, EventArgs e)
        {
            currentItems.Clear();
            RefreshCurrentDataGrid();
            RefreshResultDataGrid();
        }
    }
}
