namespace EveIndustry.Forms
{
    partial class ProjectsAllForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addNewMediumProjectButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.reloadPricesButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.addNewSmallProjectButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.projectsDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.deleteProjectButton = new System.Windows.Forms.Button();
            this.addInProjectListButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.projectsListDataGridView = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.removeFromProjectsListButton = new System.Windows.Forms.Button();
            this.clearProjectsListButton = new System.Windows.Forms.Button();
            this.goToPurchasesListButton = new System.Windows.Forms.Button();
            this.fullProfitLabel = new System.Windows.Forms.Label();
            this.fullCostLabel = new System.Windows.Forms.Label();
            this.nameFilterTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsListDataGridView)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nameFilterTextBox);
            this.panel1.Controls.Add(this.addNewMediumProjectButton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.reloadPricesButton);
            this.panel1.Controls.Add(this.refreshButton);
            this.panel1.Controls.Add(this.addNewSmallProjectButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 78);
            this.panel1.TabIndex = 0;
            // 
            // addNewMediumProjectButton
            // 
            this.addNewMediumProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewMediumProjectButton.Location = new System.Drawing.Point(45, 3);
            this.addNewMediumProjectButton.Name = "addNewMediumProjectButton";
            this.addNewMediumProjectButton.Size = new System.Drawing.Size(36, 36);
            this.addNewMediumProjectButton.TabIndex = 4;
            this.addNewMediumProjectButton.Text = "+";
            this.addNewMediumProjectButton.UseVisualStyleBackColor = true;
            this.addNewMediumProjectButton.Click += new System.EventHandler(this.addNewMediumProjectButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(366, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Показать цены";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reloadPricesButton
            // 
            this.reloadPricesButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.reloadPricesButton.Location = new System.Drawing.Point(366, 3);
            this.reloadPricesButton.Name = "reloadPricesButton";
            this.reloadPricesButton.Size = new System.Drawing.Size(93, 36);
            this.reloadPricesButton.TabIndex = 2;
            this.reloadPricesButton.Text = "Обновить цены";
            this.reloadPricesButton.UseVisualStyleBackColor = true;
            this.reloadPricesButton.Click += new System.EventHandler(this.reloadPricesButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(324, 3);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(36, 36);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "O";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // addNewSmallProjectButton
            // 
            this.addNewSmallProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewSmallProjectButton.Location = new System.Drawing.Point(3, 3);
            this.addNewSmallProjectButton.Name = "addNewSmallProjectButton";
            this.addNewSmallProjectButton.Size = new System.Drawing.Size(36, 36);
            this.addNewSmallProjectButton.TabIndex = 0;
            this.addNewSmallProjectButton.Text = "+";
            this.addNewSmallProjectButton.UseVisualStyleBackColor = true;
            this.addNewSmallProjectButton.Click += new System.EventHandler(this.addNewProjectButton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.projectsDataGridView);
            this.panel2.Location = new System.Drawing.Point(12, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(469, 353);
            this.panel2.TabIndex = 1;
            // 
            // projectsDataGridView
            // 
            this.projectsDataGridView.AllowUserToAddRows = false;
            this.projectsDataGridView.AllowUserToDeleteRows = false;
            this.projectsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.isChecked,
            this.itemName,
            this.profit,
            this.time});
            this.projectsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.projectsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.projectsDataGridView.Name = "projectsDataGridView";
            this.projectsDataGridView.Size = new System.Drawing.Size(465, 349);
            this.projectsDataGridView.TabIndex = 0;
            this.projectsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projectsDataGridView_CellContentClick);
            this.projectsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projectsDataGridView_CellContentDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // isChecked
            // 
            this.isChecked.HeaderText = "";
            this.isChecked.Name = "isChecked";
            this.isChecked.Width = 20;
            // 
            // itemName
            // 
            this.itemName.HeaderText = "Наименование";
            this.itemName.Name = "itemName";
            this.itemName.Width = 300;
            // 
            // profit
            // 
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.profit.DefaultCellStyle = dataGridViewCellStyle1;
            this.profit.HeaderText = "Profit";
            this.profit.Name = "profit";
            // 
            // time
            // 
            this.time.HeaderText = "время выполнения";
            this.time.Name = "time";
            this.time.Visible = false;
            this.time.Width = 75;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.deleteProjectButton);
            this.panel3.Controls.Add(this.addInProjectListButton);
            this.panel3.Location = new System.Drawing.Point(12, 457);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(469, 44);
            this.panel3.TabIndex = 2;
            // 
            // deleteProjectButton
            // 
            this.deleteProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteProjectButton.Location = new System.Drawing.Point(3, 3);
            this.deleteProjectButton.Name = "deleteProjectButton";
            this.deleteProjectButton.Size = new System.Drawing.Size(148, 36);
            this.deleteProjectButton.TabIndex = 5;
            this.deleteProjectButton.Text = "Удалить выбранное";
            this.deleteProjectButton.UseVisualStyleBackColor = true;
            this.deleteProjectButton.Click += new System.EventHandler(this.deleteProjectButton_Click);
            // 
            // addInProjectListButton
            // 
            this.addInProjectListButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addInProjectListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addInProjectListButton.Location = new System.Drawing.Point(284, 3);
            this.addInProjectListButton.Name = "addInProjectListButton";
            this.addInProjectListButton.Size = new System.Drawing.Size(175, 36);
            this.addInProjectListButton.TabIndex = 0;
            this.addInProjectListButton.Text = "=>";
            this.addInProjectListButton.UseVisualStyleBackColor = true;
            this.addInProjectListButton.Click += new System.EventHandler(this.addInProjectListButton_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.projectsListDataGridView);
            this.panel4.Location = new System.Drawing.Point(487, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(345, 437);
            this.panel4.TabIndex = 3;
            // 
            // projectsListDataGridView
            // 
            this.projectsListDataGridView.AllowUserToAddRows = false;
            this.projectsListDataGridView.AllowUserToDeleteRows = false;
            this.projectsListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectsListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.projectChecked,
            this.ProjectName,
            this.ProjectCost,
            this.ProjectProfit});
            this.projectsListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectsListDataGridView.Location = new System.Drawing.Point(0, 0);
            this.projectsListDataGridView.Name = "projectsListDataGridView";
            this.projectsListDataGridView.Size = new System.Drawing.Size(341, 433);
            this.projectsListDataGridView.TabIndex = 0;
            this.projectsListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projectsListDataGridView_CellContentClick);
            // 
            // num
            // 
            this.num.HeaderText = "#";
            this.num.Name = "num";
            this.num.Visible = false;
            // 
            // projectChecked
            // 
            this.projectChecked.HeaderText = "";
            this.projectChecked.Name = "projectChecked";
            this.projectChecked.Width = 20;
            // 
            // ProjectName
            // 
            this.ProjectName.HeaderText = "Наименование";
            this.ProjectName.Name = "ProjectName";
            // 
            // ProjectCost
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.ProjectCost.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProjectCost.HeaderText = "Затраты";
            this.ProjectCost.Name = "ProjectCost";
            this.ProjectCost.Width = 90;
            // 
            // ProjectProfit
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.ProjectProfit.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProjectProfit.HeaderText = "Профит";
            this.ProjectProfit.Name = "ProjectProfit";
            this.ProjectProfit.Width = 90;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.removeFromProjectsListButton);
            this.panel5.Controls.Add(this.clearProjectsListButton);
            this.panel5.Controls.Add(this.goToPurchasesListButton);
            this.panel5.Controls.Add(this.fullProfitLabel);
            this.panel5.Controls.Add(this.fullCostLabel);
            this.panel5.Location = new System.Drawing.Point(487, 455);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(345, 46);
            this.panel5.TabIndex = 4;
            // 
            // removeFromProjectsListButton
            // 
            this.removeFromProjectsListButton.Location = new System.Drawing.Point(214, 3);
            this.removeFromProjectsListButton.Name = "removeFromProjectsListButton";
            this.removeFromProjectsListButton.Size = new System.Drawing.Size(38, 38);
            this.removeFromProjectsListButton.TabIndex = 4;
            this.removeFromProjectsListButton.Text = "<=";
            this.removeFromProjectsListButton.UseVisualStyleBackColor = true;
            this.removeFromProjectsListButton.Click += new System.EventHandler(this.removeFromProjectsListButton_Click);
            // 
            // clearProjectsListButton
            // 
            this.clearProjectsListButton.Location = new System.Drawing.Point(258, 3);
            this.clearProjectsListButton.Name = "clearProjectsListButton";
            this.clearProjectsListButton.Size = new System.Drawing.Size(38, 38);
            this.clearProjectsListButton.TabIndex = 3;
            this.clearProjectsListButton.Text = "X";
            this.clearProjectsListButton.UseVisualStyleBackColor = true;
            this.clearProjectsListButton.Click += new System.EventHandler(this.clearProjectsListButton_Click);
            // 
            // goToPurchasesListButton
            // 
            this.goToPurchasesListButton.Location = new System.Drawing.Point(302, 3);
            this.goToPurchasesListButton.Name = "goToPurchasesListButton";
            this.goToPurchasesListButton.Size = new System.Drawing.Size(38, 38);
            this.goToPurchasesListButton.TabIndex = 2;
            this.goToPurchasesListButton.Text = "=>";
            this.goToPurchasesListButton.UseVisualStyleBackColor = true;
            this.goToPurchasesListButton.Click += new System.EventHandler(this.goToPurchasesListButton_Click);
            // 
            // fullProfitLabel
            // 
            this.fullProfitLabel.AutoSize = true;
            this.fullProfitLabel.Location = new System.Drawing.Point(3, 28);
            this.fullProfitLabel.Name = "fullProfitLabel";
            this.fullProfitLabel.Size = new System.Drawing.Size(88, 13);
            this.fullProfitLabel.TabIndex = 1;
            this.fullProfitLabel.Text = "Общий профит: ";
            // 
            // fullCostLabel
            // 
            this.fullCostLabel.AutoSize = true;
            this.fullCostLabel.Location = new System.Drawing.Point(3, 5);
            this.fullCostLabel.Name = "fullCostLabel";
            this.fullCostLabel.Size = new System.Drawing.Size(105, 13);
            this.fullCostLabel.TabIndex = 0;
            this.fullCostLabel.Text = "Общая стоимость: ";
            // 
            // nameFilterTextBox
            // 
            this.nameFilterTextBox.Location = new System.Drawing.Point(3, 50);
            this.nameFilterTextBox.Name = "nameFilterTextBox";
            this.nameFilterTextBox.Size = new System.Drawing.Size(174, 20);
            this.nameFilterTextBox.TabIndex = 5;
            this.nameFilterTextBox.TextChanged += new System.EventHandler(this.nameFilterTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "фильтр по имени";
            // 
            // ProjectsAllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 513);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ProjectsAllForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectsListDataGridView)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView projectsDataGridView;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button addNewSmallProjectButton;
        private System.Windows.Forms.Button reloadPricesButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addInProjectListButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isChecked;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridView projectsListDataGridView;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button goToPurchasesListButton;
        private System.Windows.Forms.Label fullProfitLabel;
        private System.Windows.Forms.Label fullCostLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewCheckBoxColumn projectChecked;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectProfit;
        private System.Windows.Forms.Button removeFromProjectsListButton;
        private System.Windows.Forms.Button clearProjectsListButton;
        private System.Windows.Forms.Button addNewMediumProjectButton;
        private System.Windows.Forms.Button deleteProjectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameFilterTextBox;
    }
}