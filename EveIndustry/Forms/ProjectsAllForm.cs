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
    public partial class ProjectsAllForm : _BaseForm
    {
        private List<Project> projectsList = new List<Project>();

        public ProjectsAllForm()
        {
            InitializeComponent();
            InitializeBaseForm();
            RefreshTable();
        }

        private void RefreshTable(string filterName ="")
        {
            projectsDataGridView.Rows.Clear();

            var projects = Program.dataBase.Projects.Where(pr=>pr.Name.Contains(nameFilterTextBox.Text));

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

            fullCostLabel.Text = "Общая стоимость: " + fullCost.ToMoney();
            fullProfitLabel.Text = "Общий профит: " + fullProfit.ToMoney();
           
        }

        private void OpenProject(Project project)
        {
            ProjectForm form = new ProjectForm(project);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
                RefreshTable();
        }



        private void addNewProjectButton_Click(object sender, EventArgs e)
        {
            Project project = new Project
            {
                BlueprintsCount = 3,
                ItemsCount = 10,
            };
            OpenProject(project);
        }

        private void addNewMediumProjectButton_Click(object sender, EventArgs e)
        {
            Project project = new Project
            {
                BlueprintsCount = 1,
                ItemsCount = 10,
            };
            OpenProject(project);
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
                projectsDataGridView.CurrentCell.Value =
                    !(bool)projectsDataGridView.CurrentCell.Value;
            }


        }

        private void projectsListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (projectsListDataGridView.CurrentCell.GetType() == typeof(DataGridViewCheckBoxCell))
            {
                projectsListDataGridView.CurrentCell.Value =
                    !(bool)projectsListDataGridView.CurrentCell.Value;
            }
        }

        private void goToPurchasesListButton_Click(object sender, EventArgs e)
        {
            PurchasesListForm form = new PurchasesListForm(projectsList);
            var result = form.ShowDialog();

        }

        private void deleteProjectButton_Click(object sender, EventArgs e)
        {
            List<Project> forDeleting = new List<Project>();           

            foreach (DataGridViewRow row in projectsDataGridView.Rows)
            {
                if ((bool)row.Cells["isChecked"].Value == true)
                {
                    var id = (int)row.Cells["id"].Value;

                    var proj = Program.dataBase.Projects
                        .Where(p => p.Id == id).FirstOrDefault();

                    forDeleting.Add(proj);
                }
            }

            var result =
            MessageBox.Show(
               $"Действительно удалить {forDeleting.Count} проектов?",
               "Подтвердите удаление",
               MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                Program.dataBase.Projects.RemoveRange(forDeleting);
                Program.dataBase.SaveChanges();

                RefreshTable();
            }


        }

        private void nameFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            RefreshTable();
        }
    }
}
