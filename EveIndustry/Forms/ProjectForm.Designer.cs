namespace EveIndustry.Forms
{
    partial class ProjectForm
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
            this.projectNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.readyItemsCountUpDown = new System.Windows.Forms.NumericUpDown();
            this.modernMaterialsDataGridView = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productMaterialsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.modernItemsAddButton = new System.Windows.Forms.Button();
            this.productItemsAddButton = new System.Windows.Forms.Button();
            this.modernSummLabel = new System.Windows.Forms.Label();
            this.productSummLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.modernItemsClrButton = new System.Windows.Forms.Button();
            this.productItemsClrButton = new System.Windows.Forms.Button();
            this.itemIdTextBox = new System.Windows.Forms.TextBox();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.readyItemsCostLabel = new System.Windows.Forms.Label();
            this.profitLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.readyItemsCountUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modernMaterialsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productMaterialsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // projectNameTextBox
            // 
            this.projectNameTextBox.Location = new System.Drawing.Point(12, 29);
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.Size = new System.Drawing.Size(316, 20);
            this.projectNameTextBox.TabIndex = 0;
            this.projectNameTextBox.Leave += new System.EventHandler(this.projectNameTextBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название проекта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Количество готовых изделий";
            // 
            // readyItemsCountUpDown
            // 
            this.readyItemsCountUpDown.Location = new System.Drawing.Point(334, 83);
            this.readyItemsCountUpDown.Name = "readyItemsCountUpDown";
            this.readyItemsCountUpDown.Size = new System.Drawing.Size(113, 20);
            this.readyItemsCountUpDown.TabIndex = 7;
            this.readyItemsCountUpDown.Leave += new System.EventHandler(this.readyItemsCountUpDown_Leave);
            // 
            // modernMaterialsDataGridView
            // 
            this.modernMaterialsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modernMaterialsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.count});
            this.modernMaterialsDataGridView.Location = new System.Drawing.Point(12, 172);
            this.modernMaterialsDataGridView.Name = "modernMaterialsDataGridView";
            this.modernMaterialsDataGridView.Size = new System.Drawing.Size(250, 232);
            this.modernMaterialsDataGridView.TabIndex = 14;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Наименование";
            this.ItemName.Name = "ItemName";
            this.ItemName.Width = 150;
            // 
            // count
            // 
            this.count.HeaderText = "Количество";
            this.count.Name = "count";
            this.count.Width = 55;
            // 
            // productMaterialsDataGridView
            // 
            this.productMaterialsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productMaterialsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.productMaterialsDataGridView.Location = new System.Drawing.Point(276, 172);
            this.productMaterialsDataGridView.Name = "productMaterialsDataGridView";
            this.productMaterialsDataGridView.Size = new System.Drawing.Size(250, 232);
            this.productMaterialsDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Материалы для модернизации";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(313, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Материалы для производства";
            // 
            // modernItemsAddButton
            // 
            this.modernItemsAddButton.Location = new System.Drawing.Point(12, 132);
            this.modernItemsAddButton.Name = "modernItemsAddButton";
            this.modernItemsAddButton.Size = new System.Drawing.Size(192, 34);
            this.modernItemsAddButton.TabIndex = 19;
            this.modernItemsAddButton.Text = "Add";
            this.modernItemsAddButton.UseVisualStyleBackColor = true;
            this.modernItemsAddButton.Click += new System.EventHandler(this.modernItemsAddButton_Click);
            // 
            // productItemsAddButton
            // 
            this.productItemsAddButton.Location = new System.Drawing.Point(276, 132);
            this.productItemsAddButton.Name = "productItemsAddButton";
            this.productItemsAddButton.Size = new System.Drawing.Size(192, 34);
            this.productItemsAddButton.TabIndex = 20;
            this.productItemsAddButton.Text = "Add";
            this.productItemsAddButton.UseVisualStyleBackColor = true;
            this.productItemsAddButton.Click += new System.EventHandler(this.productItemsAddButton_Click);
            // 
            // modernSummLabel
            // 
            this.modernSummLabel.AutoSize = true;
            this.modernSummLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modernSummLabel.Location = new System.Drawing.Point(9, 407);
            this.modernSummLabel.Name = "modernSummLabel";
            this.modernSummLabel.Size = new System.Drawing.Size(65, 17);
            this.modernSummLabel.TabIndex = 21;
            this.modernSummLabel.Text = "ИТОГО: ";
            // 
            // productSummLabel
            // 
            this.productSummLabel.AutoSize = true;
            this.productSummLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productSummLabel.Location = new System.Drawing.Point(273, 407);
            this.productSummLabel.Name = "productSummLabel";
            this.productSummLabel.Size = new System.Drawing.Size(65, 17);
            this.productSummLabel.TabIndex = 22;
            this.productSummLabel.Text = "ИТОГО: ";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(162, 473);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 35);
            this.okButton.TabIndex = 23;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(276, 473);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 35);
            this.cancelButton.TabIndex = 24;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // modernItemsClrButton
            // 
            this.modernItemsClrButton.Location = new System.Drawing.Point(210, 132);
            this.modernItemsClrButton.Name = "modernItemsClrButton";
            this.modernItemsClrButton.Size = new System.Drawing.Size(52, 34);
            this.modernItemsClrButton.TabIndex = 25;
            this.modernItemsClrButton.Text = "Clear";
            this.modernItemsClrButton.UseVisualStyleBackColor = true;
            this.modernItemsClrButton.Click += new System.EventHandler(this.modernItemsClrButton_Click);
            // 
            // productItemsClrButton
            // 
            this.productItemsClrButton.Location = new System.Drawing.Point(474, 132);
            this.productItemsClrButton.Name = "productItemsClrButton";
            this.productItemsClrButton.Size = new System.Drawing.Size(52, 34);
            this.productItemsClrButton.TabIndex = 26;
            this.productItemsClrButton.Text = "Clear";
            this.productItemsClrButton.UseVisualStyleBackColor = true;
            this.productItemsClrButton.Click += new System.EventHandler(this.productItemsClrButton_Click);
            // 
            // itemIdTextBox
            // 
            this.itemIdTextBox.Location = new System.Drawing.Point(228, 83);
            this.itemIdTextBox.Name = "itemIdTextBox";
            this.itemIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemIdTextBox.TabIndex = 27;
            this.itemIdTextBox.Leave += new System.EventHandler(this.itemIdTextBox_Leave);
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Location = new System.Drawing.Point(12, 83);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(210, 20);
            this.itemNameTextBox.TabIndex = 28;
            this.itemNameTextBox.Leave += new System.EventHandler(this.itemNameTextBox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Название предмета";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "ID";
            // 
            // readyItemsCostLabel
            // 
            this.readyItemsCostLabel.AutoSize = true;
            this.readyItemsCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readyItemsCostLabel.Location = new System.Drawing.Point(9, 434);
            this.readyItemsCostLabel.Name = "readyItemsCostLabel";
            this.readyItemsCostLabel.Size = new System.Drawing.Size(131, 17);
            this.readyItemsCostLabel.TabIndex = 31;
            this.readyItemsCostLabel.Text = "Готовые изделия: ";
            // 
            // profitLabel
            // 
            this.profitLabel.AutoSize = true;
            this.profitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profitLabel.Location = new System.Drawing.Point(273, 434);
            this.profitLabel.Name = "profitLabel";
            this.profitLabel.Size = new System.Drawing.Size(68, 17);
            this.profitLabel.TabIndex = 32;
            this.profitLabel.Text = "Профит: ";
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 511);
            this.Controls.Add(this.profitLabel);
            this.Controls.Add(this.readyItemsCostLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(this.itemIdTextBox);
            this.Controls.Add(this.productItemsClrButton);
            this.Controls.Add(this.modernItemsClrButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.productSummLabel);
            this.Controls.Add(this.modernSummLabel);
            this.Controls.Add(this.productItemsAddButton);
            this.Controls.Add(this.modernItemsAddButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.productMaterialsDataGridView);
            this.Controls.Add(this.modernMaterialsDataGridView);
            this.Controls.Add(this.readyItemsCountUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.projectNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ProjectForm";
            this.Text = "ProjectForm";
            ((System.ComponentModel.ISupportInitialize)(this.readyItemsCountUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modernMaterialsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productMaterialsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox projectNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown readyItemsCountUpDown;
        private System.Windows.Forms.DataGridView modernMaterialsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridView productMaterialsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button modernItemsAddButton;
        private System.Windows.Forms.Button productItemsAddButton;
        private System.Windows.Forms.Label modernSummLabel;
        private System.Windows.Forms.Label productSummLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button modernItemsClrButton;
        private System.Windows.Forms.Button productItemsClrButton;
        private System.Windows.Forms.TextBox itemIdTextBox;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label readyItemsCostLabel;
        private System.Windows.Forms.Label profitLabel;
    }
}