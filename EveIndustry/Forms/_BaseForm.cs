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
    public partial class _BaseForm : Form
    {
        public _BaseForm()
        {
            InitializeComponent();
        }

        protected void InitializeBaseForm()
        {
            Icon = base.Icon;
            StartPosition = FormStartPosition.CenterParent;
        }

    }
}
