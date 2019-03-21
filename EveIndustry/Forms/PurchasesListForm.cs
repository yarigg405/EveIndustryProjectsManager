using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EveIndustry.Forms
{
    public partial class PurchasesListForm :_BaseForm
    {
        private List<string> projectIdsList;

        public PurchasesListForm(List<string> projectIdsList)
        {
            InitializeComponent();
            InitializeBaseForm();

            this.projectIdsList = projectIdsList;

            RefreshTable();
        }


        private void RefreshTable()
        {

        }

    }
}
