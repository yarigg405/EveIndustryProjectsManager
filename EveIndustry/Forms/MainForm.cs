using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EveIndustry.Data;
using System.Data.Entity;
using EveIndustry.Controllers;


namespace EveIndustry.Forms
{
    public partial class MainForm : _BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeBaseForm();
            RefreshTable();
        }

        private void RefreshTable()
        {
            projectsDataGridView.Rows.Clear();

            var projects = Program.dataBase.Projects;

            foreach (var proj in projects.ToList())
            {
                var num = projectsDataGridView.Rows.Add();
                var row = projectsDataGridView.Rows[num];

                row.Cells["id"].Value = proj.Id;
                row.Cells["isChecked"].Value = false;
                row.Cells["itemName"].Value = proj.Name;
                row.Cells["Profit"].Value = proj.GetProfit();

            }

        }

        private void addNewProjectButton_Click(object sender, EventArgs e)
        {
            Project project = new Project
            {
            };

            ProjectForm form = new ProjectForm(project);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
                RefreshTable();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void projectsDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = (int)projectsDataGridView.CurrentRow.Cells["id"].Value;
            var project = Program.dataBase.Projects.Where(pr => pr.Id == id)
                .Include(pr => pr.ModernisationItems)
                .Include(pr => pr.ProductionsItems)
                .Single();

            ProjectForm form = new ProjectForm(project);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
                RefreshTable();
        }

        private void reloadPricesButton_Click(object sender, EventArgs e)
        {
            try
            {
                PriceLoader loader = new PriceLoader();
                loader.LoadPrices();
                RefreshTable();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Orders = Program.dataBase.Orders
                .Include(o => o.Item).ToList();
            StringBuilder sb = new StringBuilder();

            foreach (var order in Orders)
            {
                sb.Append(order.Item.Name + "  sellMin ");
                sb.Append(order.SellMinJita);
                sb.Append(" sellMax ");
                sb.Append(order.SellMaxJita);
                sb.Append(" buyMin ");
                sb.Append(order.BuyMinJita);
                sb.Append(" buyMax ");
                sb.Append(order.BuyMaxJita);
                sb.Append("\n\n");

            }

            MessageBox.Show(sb.ToString());

        }
    }
}
