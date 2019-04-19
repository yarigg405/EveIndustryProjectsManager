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
using EveIndustry.Controllers;


namespace EveIndustry.Forms
{
    public partial class ProjectForm : _BaseForm
    {
        private Project project;

        public ProjectForm(Project proj)
        {
            InitializeComponent();
            InitializeBaseForm();

            project = proj;
            if (proj.Name == string.Empty) Text = "Новый проект";
            else Text = proj.Name;

            Fill(project);
        }

        private void Fill(Project proj)
        {
            projectNameTextBox.Text = proj.Name;
            if (proj.Item != null)
            {
                itemNameTextBox.Text = proj.Item.Name;
                itemIdTextBox.Text = proj.Item.Id;
            }

            readyItemsCountUpDown.Value = proj.ItemsCount;
            blueprintsCountUpDown.Value = proj.BlueprintsCount;
            RefreshReadyItemsCost();
            RefreshModernisationItems();
            RefreshProductionItems();

        }

        private void RefreshModernisationItems()
        {
            modernMaterialsDataGridView.Rows.Clear();
            foreach (var item in project.ModernisationItems)
            {
                var num = modernMaterialsDataGridView.Rows.Add();
                var row = modernMaterialsDataGridView.Rows[num];
                row.Cells["ItemName"].Value = item.Item.Name;
                row.Cells["count"].Value = item.Count;
                row.Cells["price"].Value = item.Item.GetSellPrice();
                row.Cells["summ"].Value = item.Count * item.Item.GetSellPrice();
            }

            var summ = project.GetModernisationCost().ToMoney();

            modernSummLabel.Text = $"ИТОГО: {summ}";
            RefreshProfit();

        }

        private void RefreshProductionItems()
        {
            productMaterialsDataGridView.Rows.Clear();
            foreach (var item in project.ProductionsItems)
            {
                var num = productMaterialsDataGridView.Rows.Add();
                var row = productMaterialsDataGridView.Rows[num];
                row.Cells["itemName2"].Value = item.Item.Name;
                row.Cells["count2"].Value = item.Count;
                row.Cells["price1"].Value = item.Item.GetSellPrice();
                row.Cells["summ1"].Value = item.Count * item.Item.GetSellPrice();
            }

            var summ = project.GetProdustionCost().ToMoney();

            productSummLabel.Text = $"ИТОГО: {summ}";
            RefreshProfit();

        }

        private void RefreshReadyItemsCost()
        {
            var summ = project.GetReadyItemsCost().ToMoney();

            readyItemsPriceLabel.Text =
                $"Готовое изделие, цена: {project.Item.GetSellPrice().ToMoney()}";
            readyItemsCostLabel.Text =
               $"Готовое изделие, сумма: {summ}";
        }

        private void RefreshProfit()
        {
            var summ = project.GetProfit().ToMoney();
            profitLabel.Text =
                $"Профит: {summ}";
        }


        private string[] ParseString(string str)
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



        private void projectNameTextBox_Leave(object sender, EventArgs e)
        {
            project.Name = projectNameTextBox.Text;
        }

        private void itemIdTextBox_Leave(object sender, EventArgs e)
        {
            var item = Program.DataBase.Items.Where(i => i.Id == itemIdTextBox.Text).FirstOrDefault();
            if (item != null)
                itemNameTextBox.Text = item.Name;
            else
                itemNameTextBox.Text = "error";

            project.Item = item;
            RefreshReadyItemsCost();

        }

        private void readyItemsCountUpDown_Leave(object sender, EventArgs e)
        {
            project.ItemsCount = (int)readyItemsCountUpDown.Value;
            RefreshReadyItemsCost();
        }

        private void blueprintsCountUpDown_Leave(object sender, EventArgs e)
        {
            project.BlueprintsCount = (int)blueprintsCountUpDown.Value;
            RefreshReadyItemsCost();
        }



        private void modernItemsAddButton_Click(object sender, EventArgs e)
        {
            addingItemsRichTextBox.Text = Clipboard.GetText();

            foreach (string str in addingItemsRichTextBox.Text.Split('\n'))
            {
                var output = ParseString(str);
                var itemStr = output[0];
                var countStr = output[1];

                if (itemStr != "")
                {
                    var item = Program.DataBase.Items
                        .Where(i => i.Name == itemStr).Single();
                    var items = project.ModernisationItems
                        .Where(i => i.Item == item).SingleOrDefault();
                    var count = ParseCount(countStr);


                    if (items == null)
                    {
                        items = new ItemsModernisation
                        {
                            Project = project,
                            Item = item,
                            Count = count,
                        };
                        project.ModernisationItems.Add(items);
                    }

                    else
                    {
                        items.Count += count;
                    }


                }
            }
            addingItemsRichTextBox.Clear();

            RefreshModernisationItems();
        }

        private void productItemsAddButton_Click(object sender, EventArgs e)
        {
            addingItemsRichTextBox.Text = Clipboard.GetText();

            foreach (string str in addingItemsRichTextBox.Text.Split('\n'))
            {
                var output = ParseString(str);
                var itemStr = output[0];
                var countStr = output[1];

                if (itemStr != "")
                {
                    var item = Program.DataBase.Items
                        .Where(i => i.Name == itemStr).Single();
                    var items = project.ProductionsItems
                        .Where(i => i.Item == item).SingleOrDefault();
                    var count = ParseCount(countStr)
                        * project.BlueprintsCount;


                    if (items == null)
                    {
                        items = new ItemsProduction
                        {
                            Project = project,
                            Item = item,
                            Count = count,
                        };
                        project.ProductionsItems.Add(items);
                    }

                    else
                    {
                        items.Count += count;
                    }


                }
            }
            addingItemsRichTextBox.Clear();

            RefreshProductionItems();
        }

        private void modernItemsClrButton_Click(object sender, EventArgs e)
        {
            project.ModernisationItems.Clear();
            RefreshModernisationItems();
        }

        private void productItemsClrButton_Click(object sender, EventArgs e)
        {
            project.ProductionsItems.Clear();
            RefreshProductionItems();
        }




        private void okButton_Click(object sender, EventArgs e)
        {
            if (project.Id < 1)
                Program.DataBase.Projects.Add(project);

            Program.DataBase.SaveChanges();
            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (project.Id > 0)
            {
                Program.DataBase.Entry(project).Reload();
            }
            DialogResult = DialogResult.Cancel;
        }

        private void MenuItemOnClick(object sender, EventArgs eventArgs)
        {
            var target = (ToolStripMenuItem)sender;
            var item = Program.DataBase.Items.Where(it => it.Id == target.Name).FirstOrDefault();
            project.Item = item;

            itemIdTextBox.Text = item.Id;
            itemNameTextBox.Text = item.Name;
        }

        private void searchItemButton_Click(object sender, EventArgs e)
        {
            if (itemNameTextBox.Text.Length > 2)
            {
                var items = (from t in Program.DataBase.Items
                             where t.Name.Contains(itemNameTextBox.Text)
                             select t).Take(10).ToList();

                searchItemContextMenuStrip.Items.Clear();
                for (int i = 0; i < items.Count; i++)
                {
                    var item = items[i];
                    var contextItem = new ToolStripMenuItem();

                    if (i < 9)
                    {
                        contextItem.Text = item.Name;
                        contextItem.Name = item.Id;
                        contextItem.Click += new EventHandler(MenuItemOnClick);
                    }

                    else
                    {
                        contextItem.Text = "... и еще";
                        contextItem.Name = "0";
                    }
                    searchItemContextMenuStrip.Items.Add(contextItem);
                }

                searchItemContextMenuStrip.Show(Cursor.Position);
            }
        }
    }
}
