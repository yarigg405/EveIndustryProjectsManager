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
            if (proj.Name == "") Text = "Новый проект";
            else Text = proj.Name;
        }


    }
}
