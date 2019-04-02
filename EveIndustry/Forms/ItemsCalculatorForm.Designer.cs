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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearCurrentListButton = new System.Windows.Forms.Button();
            this.clearNeededListButton = new System.Windows.Forms.Button();
            this.dropToAddButton = new System.Windows.Forms.Button();
            this.dropToCurrentButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exportButton = new System.Windows.Forms.Button();
            this.importExportRichTextBox = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.neededDataGrdV = new System.Windows.Forms.DataGridView();
            this.neededItemNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.neededItemCountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.neededItemPriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.neededItemSummCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalNeedSummLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.currentDataGrdV = new System.Windows.Forms.DataGridView();
            this.currentItemNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentItemCountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentItemPriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentItemSummCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.resultDataGrdV = new System.Windows.Forms.DataGridView();
            this.resultItemNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultItemCountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultItemPriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultItemSummCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCurrentSummLabel = new System.Windows.Forms.Label();
            this.totalResultSummLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neededDataGrdV)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentDataGrdV)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGrdV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.clearCurrentListButton);
            this.panel1.Controls.Add(this.clearNeededListButton);
            this.panel1.Controls.Add(this.dropToAddButton);
            this.panel1.Controls.Add(this.dropToCurrentButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 53);
            this.panel1.TabIndex = 0;
            // 
            // clearCurrentListButton
            // 
            this.clearCurrentListButton.BackColor = System.Drawing.Color.PaleVioletRed;
            this.clearCurrentListButton.Location = new System.Drawing.Point(475, 3);
            this.clearCurrentListButton.Name = "clearCurrentListButton";
            this.clearCurrentListButton.Size = new System.Drawing.Size(50, 43);
            this.clearCurrentListButton.TabIndex = 5;
            this.clearCurrentListButton.Text = "Х";
            this.clearCurrentListButton.UseVisualStyleBackColor = false;
            this.clearCurrentListButton.Click += new System.EventHandler(this.clearCurrentListButton_Click);
            // 
            // clearNeededListButton
            // 
            this.clearNeededListButton.BackColor = System.Drawing.Color.PaleVioletRed;
            this.clearNeededListButton.Location = new System.Drawing.Point(210, 3);
            this.clearNeededListButton.Name = "clearNeededListButton";
            this.clearNeededListButton.Size = new System.Drawing.Size(50, 43);
            this.clearNeededListButton.TabIndex = 4;
            this.clearNeededListButton.Text = "Х";
            this.clearNeededListButton.UseVisualStyleBackColor = false;
            this.clearNeededListButton.Click += new System.EventHandler(this.clearNeededListButton_Click);
            // 
            // dropToAddButton
            // 
            this.dropToAddButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dropToAddButton.Location = new System.Drawing.Point(3, 3);
            this.dropToAddButton.Name = "dropToAddButton";
            this.dropToAddButton.Size = new System.Drawing.Size(199, 43);
            this.dropToAddButton.TabIndex = 3;
            this.dropToAddButton.Text = "Добавить в список необходимого";
            this.dropToAddButton.UseVisualStyleBackColor = false;
            this.dropToAddButton.Click += new System.EventHandler(this.dropToAddButton_Click);
            // 
            // dropToCurrentButton
            // 
            this.dropToCurrentButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dropToCurrentButton.Location = new System.Drawing.Point(266, 3);
            this.dropToCurrentButton.Name = "dropToCurrentButton";
            this.dropToCurrentButton.Size = new System.Drawing.Size(205, 43);
            this.dropToCurrentButton.TabIndex = 2;
            this.dropToCurrentButton.Text = "Добавить в список имеющегося";
            this.dropToCurrentButton.UseVisualStyleBackColor = false;
            this.dropToCurrentButton.Click += new System.EventHandler(this.dropToRemoveButton_Click);
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
            this.panel2.Size = new System.Drawing.Size(795, 73);
            this.panel2.TabIndex = 1;
            // 
            // exportButton
            // 
            this.exportButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.exportButton.Location = new System.Drawing.Point(684, 3);
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
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.neededDataGrdV);
            this.panel3.Location = new System.Drawing.Point(12, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(261, 295);
            this.panel3.TabIndex = 2;
            // 
            // neededDataGrdV
            // 
            this.neededDataGrdV.AllowUserToAddRows = false;
            this.neededDataGrdV.AllowUserToDeleteRows = false;
            this.neededDataGrdV.AllowUserToOrderColumns = true;
            this.neededDataGrdV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.neededDataGrdV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.neededItemNameCol,
            this.neededItemCountCol,
            this.neededItemPriceCol,
            this.neededItemSummCol});
            this.neededDataGrdV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.neededDataGrdV.Location = new System.Drawing.Point(0, 0);
            this.neededDataGrdV.Name = "neededDataGrdV";
            this.neededDataGrdV.Size = new System.Drawing.Size(257, 291);
            this.neededDataGrdV.TabIndex = 0;
            // 
            // neededItemNameCol
            // 
            this.neededItemNameCol.HeaderText = "Name";
            this.neededItemNameCol.Name = "neededItemNameCol";
            this.neededItemNameCol.Width = 130;
            // 
            // neededItemCountCol
            // 
            this.neededItemCountCol.HeaderText = "Count";
            this.neededItemCountCol.Name = "neededItemCountCol";
            this.neededItemCountCol.Width = 70;
            // 
            // neededItemPriceCol
            // 
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.neededItemPriceCol.DefaultCellStyle = dataGridViewCellStyle7;
            this.neededItemPriceCol.HeaderText = "Price";
            this.neededItemPriceCol.Name = "neededItemPriceCol";
            // 
            // neededItemSummCol
            // 
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.neededItemSummCol.DefaultCellStyle = dataGridViewCellStyle8;
            this.neededItemSummCol.HeaderText = "Summ";
            this.neededItemSummCol.Name = "neededItemSummCol";
            // 
            // totalNeedSummLabel
            // 
            this.totalNeedSummLabel.AutoSize = true;
            this.totalNeedSummLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalNeedSummLabel.Location = new System.Drawing.Point(13, 369);
            this.totalNeedSummLabel.Name = "totalNeedSummLabel";
            this.totalNeedSummLabel.Size = new System.Drawing.Size(108, 17);
            this.totalNeedSummLabel.TabIndex = 4;
            this.totalNeedSummLabel.Text = "999 999 999,99";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.currentDataGrdV);
            this.panel4.Location = new System.Drawing.Point(279, 71);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(261, 295);
            this.panel4.TabIndex = 5;
            // 
            // currentDataGrdV
            // 
            this.currentDataGrdV.AllowUserToAddRows = false;
            this.currentDataGrdV.AllowUserToDeleteRows = false;
            this.currentDataGrdV.AllowUserToOrderColumns = true;
            this.currentDataGrdV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentDataGrdV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.currentItemNameCol,
            this.currentItemCountCol,
            this.currentItemPriceCol,
            this.currentItemSummCol});
            this.currentDataGrdV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentDataGrdV.Location = new System.Drawing.Point(0, 0);
            this.currentDataGrdV.Name = "currentDataGrdV";
            this.currentDataGrdV.Size = new System.Drawing.Size(257, 291);
            this.currentDataGrdV.TabIndex = 1;
            // 
            // currentItemNameCol
            // 
            this.currentItemNameCol.HeaderText = "Name";
            this.currentItemNameCol.Name = "currentItemNameCol";
            this.currentItemNameCol.Width = 130;
            // 
            // currentItemCountCol
            // 
            this.currentItemCountCol.HeaderText = "Count";
            this.currentItemCountCol.Name = "currentItemCountCol";
            this.currentItemCountCol.Width = 70;
            // 
            // currentItemPriceCol
            // 
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            this.currentItemPriceCol.DefaultCellStyle = dataGridViewCellStyle9;
            this.currentItemPriceCol.HeaderText = "Price";
            this.currentItemPriceCol.Name = "currentItemPriceCol";
            // 
            // currentItemSummCol
            // 
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = null;
            this.currentItemSummCol.DefaultCellStyle = dataGridViewCellStyle10;
            this.currentItemSummCol.HeaderText = "Summ";
            this.currentItemSummCol.Name = "currentItemSummCol";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.resultDataGrdV);
            this.panel5.Location = new System.Drawing.Point(546, 71);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(261, 295);
            this.panel5.TabIndex = 6;
            // 
            // resultDataGrdV
            // 
            this.resultDataGrdV.AllowUserToAddRows = false;
            this.resultDataGrdV.AllowUserToDeleteRows = false;
            this.resultDataGrdV.AllowUserToOrderColumns = true;
            this.resultDataGrdV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGrdV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.resultItemNameCol,
            this.resultItemCountCol,
            this.resultItemPriceCol,
            this.resultItemSummCol});
            this.resultDataGrdV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultDataGrdV.Location = new System.Drawing.Point(0, 0);
            this.resultDataGrdV.Name = "resultDataGrdV";
            this.resultDataGrdV.Size = new System.Drawing.Size(257, 291);
            this.resultDataGrdV.TabIndex = 1;
            // 
            // resultItemNameCol
            // 
            this.resultItemNameCol.HeaderText = "Name";
            this.resultItemNameCol.Name = "resultItemNameCol";
            this.resultItemNameCol.Width = 130;
            // 
            // resultItemCountCol
            // 
            this.resultItemCountCol.HeaderText = "Count";
            this.resultItemCountCol.Name = "resultItemCountCol";
            this.resultItemCountCol.Width = 70;
            // 
            // resultItemPriceCol
            // 
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = null;
            this.resultItemPriceCol.DefaultCellStyle = dataGridViewCellStyle11;
            this.resultItemPriceCol.HeaderText = "Price";
            this.resultItemPriceCol.Name = "resultItemPriceCol";
            // 
            // resultItemSummCol
            // 
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = null;
            this.resultItemSummCol.DefaultCellStyle = dataGridViewCellStyle12;
            this.resultItemSummCol.HeaderText = "Summ";
            this.resultItemSummCol.Name = "resultItemSummCol";
            // 
            // totalCurrentSummLabel
            // 
            this.totalCurrentSummLabel.AutoSize = true;
            this.totalCurrentSummLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalCurrentSummLabel.Location = new System.Drawing.Point(280, 369);
            this.totalCurrentSummLabel.Name = "totalCurrentSummLabel";
            this.totalCurrentSummLabel.Size = new System.Drawing.Size(108, 17);
            this.totalCurrentSummLabel.TabIndex = 7;
            this.totalCurrentSummLabel.Text = "999 999 999,99";
            // 
            // totalResultSummLabel
            // 
            this.totalResultSummLabel.AutoSize = true;
            this.totalResultSummLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalResultSummLabel.Location = new System.Drawing.Point(547, 369);
            this.totalResultSummLabel.Name = "totalResultSummLabel";
            this.totalResultSummLabel.Size = new System.Drawing.Size(108, 17);
            this.totalResultSummLabel.TabIndex = 8;
            this.totalResultSummLabel.Text = "999 999 999,99";
            // 
            // ItemsCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 489);
            this.Controls.Add(this.totalResultSummLabel);
            this.Controls.Add(this.totalCurrentSummLabel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.totalNeedSummLabel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ItemsCalculatorForm";
            this.Text = "PurchasesListForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.neededDataGrdV)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.currentDataGrdV)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGrdV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox importExportRichTextBox;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button dropToCurrentButton;
        private System.Windows.Forms.Button dropToAddButton;
        private System.Windows.Forms.Label totalNeedSummLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label totalCurrentSummLabel;
        private System.Windows.Forms.Label totalResultSummLabel;
        private System.Windows.Forms.DataGridView neededDataGrdV;
        private System.Windows.Forms.DataGridView currentDataGrdV;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentItemNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentItemCountCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentItemPriceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentItemSummCol;
        private System.Windows.Forms.DataGridView resultDataGrdV;
        private System.Windows.Forms.DataGridViewTextBoxColumn neededItemNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn neededItemCountCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn neededItemPriceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn neededItemSummCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultItemNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultItemCountCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultItemPriceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultItemSummCol;
        private System.Windows.Forms.Button clearCurrentListButton;
        private System.Windows.Forms.Button clearNeededListButton;
    }
}