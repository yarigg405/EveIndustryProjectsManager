using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EveIndustry.Controllers;


namespace EveIndustry.Forms
{
    public partial class MainForm : _BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void projectsAllButton_Click(object sender, EventArgs e)
        {
            var form = new ProjectsAllForm();
            Hide();
            form.ShowDialog();
            Show();
        }

        private void itemsCalulatorButton_Click(object sender, EventArgs e)
        {
            var form = new ItemsCalculatorForm();
            Hide();
            form.ShowDialog();
            Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                PriceLoader loader = new PriceLoader();
                loader.LoadPrices();                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
