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
        private List<Project> projectsList = new List<Project>();

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

        private void RefreshProjectsList()
        {
            projectsListDataGridView.Rows.Clear();
            decimal fullCost = 0;
            decimal fullProfit = 0;


            for (int i = 0; i < projectsList.Count; i++)
            {
                var proj = projectsList[i];
                var num = projectsListDataGridView.Rows.Add();
                var row = projectsListDataGridView.Rows[num];

                row.Cells["num"].Value = i;
                row.Cells["projectChecked"].Value = false;
                row.Cells["ProjectName"].Value = proj.Name;
                row.Cells["ProjectCost"].Value = proj.GetModernisationCost() + proj.GetProdustionCost();
                row.Cells["ProjectProfit"].Value = proj.GetProfit();

                fullCost += proj.GetModernisationCost() + proj.GetProdustionCost();
                fullProfit += proj.GetProfit();
            }

            fullCostLabel.Text = "Общая стоимость: " + fullCost;
            fullProfitLabel.Text = "Общий профит: " + fullProfit;
           
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
                RefreshProjectsList();
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





        private void addInProjectListButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in projectsDataGridView.Rows)
            {
                if ((bool)row.Cells["isChecked"].Value == true)
                {
                    var id = (int)row.Cells["id"].Value;

                    var proj = Program.dataBase.Projects
                        .Where(p => p.Id == id).FirstOrDefault();

                    projectsList.Add(proj);
                }

            }
            RefreshProjectsList();

        }

        private void removeFromProjectsListButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in projectsListDataGridView.Rows)
            {
                if ((bool)row.Cells["projectChecked"].Value == true)
                {
                    projectsList.RemoveAt((int)row.Cells["num"].Value);
                }
            }
            RefreshProjectsList();

        }

        private void clearProjectsListButton_Click(object sender, EventArgs e)
        {
            projectsList.Clear();
            RefreshProjectsList();
        }

        private void projectsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (projectsDataGridView.CurrentCell.GetType() == typeof(DataGridViewCheckBoxCell))
            {
                projectsDataGridView.CurrentCell.Value = true;
            }


        }

        private void projectsListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (projectsListDataGridView.CurrentCell.GetType() == typeof(DataGridViewCheckBoxCell))
            {
                projectsListDataGridView.CurrentCell.Value = true;
            }
        }

        private void goToPurchasesListButton_Click(object sender, EventArgs e)
        {
            PurchasesListForm form = new PurchasesListForm(projectsList);
            var result = form.ShowDialog();

        }
    }
}
