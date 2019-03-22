namespace EveIndustry.Forms
{
    partial class PurchasesListForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dropToRemoveButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exportButton = new System.Windows.Forms.Button();
            this.importExportRichTextBox = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.modernisationsItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.productionsItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.itemName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCount1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exportProjectsInfoButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modernisationsItemsDataGridView)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productionsItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dropToRemoveButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 79);
            this.panel1.TabIndex = 0;
            // 
            // dropToRemoveButton
            // 
            this.dropToRemoveButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dropToRemoveButton.Location = new System.Drawing.Point(163, 3);
            this.dropToRemoveButton.Name = "dropToRemoveButton";
            this.dropToRemoveButton.Size = new System.Drawing.Size(199, 71);
            this.dropToRemoveButton.TabIndex = 2;
            this.dropToRemoveButton.Text = "Сбросить сюда список уже имеющихся предметов";
            this.dropToRemoveButton.UseVisualStyleBackColor = false;
            this.dropToRemoveButton.Click += new System.EventHandler(this.dropToRemoveButton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.exportProjectsInfoButton);
            this.panel2.Controls.Add(this.exportButton);
            this.panel2.Controls.Add(this.importExportRichTextBox);
            this.panel2.Location = new System.Drawing.Point(12, 398);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 79);
            this.panel2.TabIndex = 1;
            // 
            // exportButton
            // 
            this.exportButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.exportButton.Location = new System.Drawing.Point(406, 3);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(106, 71);
            this.exportButton.TabIndex = 1;
            this.exportButton.Text = "Экспорт данных по материалам";
            this.exportButton.UseVisualStyleBackColor = false;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // importExportRichTextBox
            // 
            this.importExportRichTextBox.Enabled = false;
            this.importExportRichTextBox.Location = new System.Drawing.Point(3, 3);
            this.importExportRichTextBox.Name = "importExportRichTextBox";
            this.importExportRichTextBox.ReadOnly = true;
            this.importExportRichTextBox.Size = new System.Drawing.Size(246, 71);
            this.importExportRichTextBox.TabIndex = 0;
            this.importExportRichTextBox.Text = "";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.modernisationsItemsDataGridView);
            this.panel3.Location = new System.Drawing.Point(12, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 295);
            this.panel3.TabIndex = 2;
            // 
            // modernisationsItemsDataGridView
            // 
            this.modernisationsItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modernisationsItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemName,
            this.itemCount});
            this.modernisationsItemsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modernisationsItemsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.modernisationsItemsDataGridView.Name = "modernisationsItemsDataGridView";
            this.modernisationsItemsDataGridView.Size = new System.Drawing.Size(246, 291);
            this.modernisationsItemsDataGridView.TabIndex = 0;
            // 
            // itemName
            // 
            this.itemName.HeaderText = "Название";
            this.itemName.Name = "itemName";
            // 
            // itemCount
            // 
            this.itemCount.HeaderText = "Количество";
            this.itemCount.Name = "itemCount";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.productionsItemsDataGridView);
            this.panel4.Location = new System.Drawing.Point(279, 97);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 295);
            this.panel4.TabIndex = 3;
            // 
            // productionsItemsDataGridView
            // 
            this.productionsItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productionsItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemName1,
            this.itemCount1});
            this.productionsItemsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productionsItemsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.productionsItemsDataGridView.Name = "productionsItemsDataGridView";
            this.productionsItemsDataGridView.Size = new System.Drawing.Size(246, 291);
            this.productionsItemsDataGridView.TabIndex = 1;
            // 
            // itemName1
            // 
            this.itemName1.HeaderText = "Название";
            this.itemName1.Name = "itemName1";
            // 
            // itemCount1
            // 
            this.itemCount1.HeaderText = "Количество";
            this.itemCount1.Name = "itemCount1";
            // 
            // exportProjectsInfoButton
            // 
            this.exportProjectsInfoButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.exportProjectsInfoButton.Location = new System.Drawing.Point(294, 3);
            this.exportProjectsInfoButton.Name = "exportProjectsInfoButton";
            this.exportProjectsInfoButton.Size = new System.Drawing.Size(106, 71);
            this.exportProjectsInfoButton.TabIndex = 2;
            this.exportProjectsInfoButton.Text = "Экспорт информации о проектах";
            this.exportProjectsInfoButton.UseVisualStyleBackColor = false;
            this.exportProjectsInfoButton.Click += new System.EventHandler(this.exportProjectsInfoButton_Click);
            // 
            // PurchasesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 489);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PurchasesListForm";
            this.Text = "PurchasesListForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.modernisationsItemsDataGridView)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productionsItemsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView modernisationsItemsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCount;
        private System.Windows.Forms.DataGridView productionsItemsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCount1;
        private System.Windows.Forms.RichTextBox importExportRichTextBox;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button dropToRemoveButton;
        private System.Windows.Forms.Button exportProjectsInfoButton;
    }
}