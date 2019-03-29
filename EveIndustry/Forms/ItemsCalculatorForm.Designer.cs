namespace EveIndustry.Forms
{
    partial class ItemsCalculatorForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dropToAddButton = new System.Windows.Forms.Button();
            this.dropToRemoveButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exportButton = new System.Windows.Forms.Button();
            this.importExportRichTextBox = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.modernisationsItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.totalSummLabel = new System.Windows.Forms.Label();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemSumm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modernisationsItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dropToAddButton);
            this.panel1.Controls.Add(this.dropToRemoveButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 53);
            this.panel1.TabIndex = 0;
            // 
            // dropToAddButton
            // 
            this.dropToAddButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dropToAddButton.Location = new System.Drawing.Point(3, 3);
            this.dropToAddButton.Name = "dropToAddButton";
            this.dropToAddButton.Size = new System.Drawing.Size(199, 43);
            this.dropToAddButton.TabIndex = 3;
            this.dropToAddButton.Text = "Добавить предметы";
            this.dropToAddButton.UseVisualStyleBackColor = false;
            this.dropToAddButton.Click += new System.EventHandler(this.dropToAddButton_Click);
            // 
            // dropToRemoveButton
            // 
            this.dropToRemoveButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dropToRemoveButton.Location = new System.Drawing.Point(313, 3);
            this.dropToRemoveButton.Name = "dropToRemoveButton";
            this.dropToRemoveButton.Size = new System.Drawing.Size(199, 43);
            this.dropToRemoveButton.TabIndex = 2;
            this.dropToRemoveButton.Text = "Убрать предметы";
            this.dropToRemoveButton.UseVisualStyleBackColor = false;
            this.dropToRemoveButton.Click += new System.EventHandler(this.dropToRemoveButton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.exportButton);
            this.panel2.Controls.Add(this.importExportRichTextBox);
            this.panel2.Location = new System.Drawing.Point(12, 404);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 73);
            this.panel2.TabIndex = 1;
            // 
            // exportButton
            // 
            this.exportButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.exportButton.Location = new System.Drawing.Point(406, 3);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(106, 65);
            this.exportButton.TabIndex = 1;
            this.exportButton.Text = "Копировать результат";
            this.exportButton.UseVisualStyleBackColor = false;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // importExportRichTextBox
            // 
            this.importExportRichTextBox.Enabled = false;
            this.importExportRichTextBox.Location = new System.Drawing.Point(3, 3);
            this.importExportRichTextBox.Name = "importExportRichTextBox";
            this.importExportRichTextBox.ReadOnly = true;
            this.importExportRichTextBox.Size = new System.Drawing.Size(246, 65);
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
            this.panel3.Location = new System.Drawing.Point(12, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(513, 295);
            this.panel3.TabIndex = 2;
            // 
            // modernisationsItemsDataGridView
            // 
            this.modernisationsItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modernisationsItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemName,
            this.itemCount,
            this.itemPrice,
            this.itemSumm});
            this.modernisationsItemsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modernisationsItemsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.modernisationsItemsDataGridView.Name = "modernisationsItemsDataGridView";
            this.modernisationsItemsDataGridView.Size = new System.Drawing.Size(509, 291);
            this.modernisationsItemsDataGridView.TabIndex = 0;
            // 
            // totalSummLabel
            // 
            this.totalSummLabel.AutoSize = true;
            this.totalSummLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalSummLabel.Location = new System.Drawing.Point(13, 369);
            this.totalSummLabel.Name = "totalSummLabel";
            this.totalSummLabel.Size = new System.Drawing.Size(131, 17);
            this.totalSummLabel.TabIndex = 4;
            this.totalSummLabel.Text = "Примерная сумма:";
            // 
            // itemName
            // 
            this.itemName.HeaderText = "Название";
            this.itemName.Name = "itemName";
            this.itemName.Width = 165;
            // 
            // itemCount
            // 
            this.itemCount.HeaderText = "Количество";
            this.itemCount.Name = "itemCount";
            // 
            // itemPrice
            // 
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.itemPrice.DefaultCellStyle = dataGridViewCellStyle1;
            this.itemPrice.HeaderText = "Цена";
            this.itemPrice.Name = "itemPrice";
            // 
            // itemSumm
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.itemSumm.DefaultCellStyle = dataGridViewCellStyle2;
            this.itemSumm.HeaderText = "Сумма";
            this.itemSumm.Name = "itemSumm";
            // 
            // ItemsCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 489);
            this.Controls.Add(this.totalSummLabel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ItemsCalculatorForm";
            this.Text = "PurchasesListForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.modernisationsItemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView modernisationsItemsDataGridView;
        private System.Windows.Forms.RichTextBox importExportRichTextBox;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button dropToRemoveButton;
        private System.Windows.Forms.Button dropToAddButton;
        private System.Windows.Forms.Label totalSummLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemSumm;
    }
}