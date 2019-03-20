using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EveIndustry.Data;


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
            if (proj.ExitItem != null)
            {
                itemNameTextBox.Text = proj.ExitItem.Name;
                itemIdTextBox.Text = proj.ExitItem.Id;
            }

            readyItemsCountUpDown.Value = proj.ItemsCount;
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
            }

            modernSummLabel.Text = $"ИТОГО: {project.GetModernisationCost()}";

        }

        private void RefreshProductionItems()
        {
            productMaterialsDataGridView.Rows.Clear();
            foreach (var item in project.ProductionsItems)
            {
                var num = productMaterialsDataGridView.Rows.Add();
                var row = productMaterialsDataGridView.Rows[num];
                row.Cells["ItemName"].Value = item.Item.Name;
                row.Cells["count"].Value = item.Count;
            }

            productSummLabel.Text = $"ИТОГО: {project.GetProdustionCost()}";

        }



        private void projectNameTextBox_Leave(object sender, EventArgs e)
        {
            project.Name = projectNameTextBox.Text;
        }

        private void itemNameTextBox_Leave(object sender, EventArgs e)
        {
            var item = Program.dataBase.Items.Where(i => i.Name.Contains(itemNameTextBox.Text)).FirstOrDefault();
            if (item != null)
                itemIdTextBox.Text = item.Id;
            else
                itemIdTextBox.Text = "error";

            project.ExitItem = item;

        }

        private void itemIdTextBox_Leave(object sender, EventArgs e)
        {
            var item = Program.dataBase.Items.Where(i => i.Id == itemIdTextBox.Text).FirstOrDefault();
            if (item != null)
                itemNameTextBox.Text = item.Name;
            else
                itemNameTextBox.Text = "error";

            project.ExitItem = item;

        }

        private void readyItemsCountUpDown_Leave(object sender, EventArgs e)
        {
            project.ItemsCount = (int)readyItemsCountUpDown.Value;
        }



        private void modernItemsAddButton_Click(object sender, EventArgs e)
        {
            string input = Clipboard.GetText();
            MessageBox.Show(input);
        }

        private void productItemsAddButton_Click(object sender, EventArgs e)
        {
            string input = Clipboard.GetText();
            MessageBox.Show(input);
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
                Program.dataBase.Projects.Add(project);
            else
            {
                var currentProject = Program.dataBase.Projects.Where(pr => pr.Id == project.Id).Single();
                Program.dataBase.Projects.Remove(currentProject);
                Program.dataBase.Projects.Add(project);
            }

            Program.dataBase.SaveChanges();
            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

       

    }
}
