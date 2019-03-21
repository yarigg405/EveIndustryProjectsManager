namespace EveIndustry.Forms
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.reloadPricesButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.addNewProjectButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.projectsDataGridView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addInPurchasesListButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.reloadPricesButton);
            this.panel1.Controls.Add(this.refreshButton);
            this.panel1.Controls.Add(this.addNewProjectButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 78);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(448, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Показать цены";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reloadPricesButton
            // 
            this.reloadPricesButton.Location = new System.Drawing.Point(448, 3);
            this.reloadPricesButton.Name = "reloadPricesButton";
            this.reloadPricesButton.Size = new System.Drawing.Size(93, 36);
            this.reloadPricesButton.TabIndex = 2;
            this.reloadPricesButton.Text = "Обновить цены";
            this.reloadPricesButton.UseVisualStyleBackColor = true;
            this.reloadPricesButton.Click += new System.EventHandler(this.reloadPricesButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(45, 3);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(36, 36);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "O";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // addNewProjectButton
            // 
            this.addNewProjectButton.Location = new System.Drawing.Point(3, 3);
            this.addNewProjectButton.Name = "addNewProjectButton";
            this.addNewProjectButton.Size = new System.Drawing.Size(36, 36);
            this.addNewProjectButton.TabIndex = 0;
            this.addNewProjectButton.Text = "+";
            this.addNewProjectButton.UseVisualStyleBackColor = true;
            this.addNewProjectButton.Click += new System.EventHandler(this.addNewProjectButton_Click);
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
            this.panel2.Size = new System.Drawing.Size(542, 451);
            this.panel2.TabIndex = 1;
            // 
            // projectsDataGridView
            // 
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
            this.projectsDataGridView.Size = new System.Drawing.Size(538, 447);
            this.projectsDataGridView.TabIndex = 0;
            this.projectsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projectsDataGridView_CellContentDoubleClick);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.addInPurchasesListButton);
            this.panel3.Location = new System.Drawing.Point(12, 553);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(542, 44);
            this.panel3.TabIndex = 2;
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
            this.time.Width = 75;
            // 
            // addInPurchasesListButton
            // 
            this.addInPurchasesListButton.Location = new System.Drawing.Point(362, 3);
            this.addInPurchasesListButton.Name = "addInPurchasesListButton";
            this.addInPurchasesListButton.Size = new System.Drawing.Size(175, 36);
            this.addInPurchasesListButton.TabIndex = 0;
            this.addInPurchasesListButton.Text = "В список покупок    =>";
            this.addInPurchasesListButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 609);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView projectsDataGridView;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button addNewProjectButton;
        private System.Windows.Forms.Button reloadPricesButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isChecked;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.Button addInPurchasesListButton;
    }
}