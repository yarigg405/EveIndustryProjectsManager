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
            this.projectsAllButton = new System.Windows.Forms.Button();
            this.Blueprints = new System.Windows.Forms.Button();
            this.itemsCalulatorButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // projectsAllButton
            // 
            this.projectsAllButton.Location = new System.Drawing.Point(147, 92);
            this.projectsAllButton.Name = "projectsAllButton";
            this.projectsAllButton.Size = new System.Drawing.Size(114, 45);
            this.projectsAllButton.TabIndex = 0;
            this.projectsAllButton.Text = "Проекты";
            this.projectsAllButton.UseVisualStyleBackColor = true;
            this.projectsAllButton.Click += new System.EventHandler(this.projectsAllButton_Click);
            // 
            // Blueprints
            // 
            this.Blueprints.Location = new System.Drawing.Point(12, 12);
            this.Blueprints.Name = "Blueprints";
            this.Blueprints.Size = new System.Drawing.Size(114, 45);
            this.Blueprints.TabIndex = 1;
            this.Blueprints.Text = "Чертежи";
            this.Blueprints.UseVisualStyleBackColor = true;
            // 
            // itemsCalulatorButton
            // 
            this.itemsCalulatorButton.Location = new System.Drawing.Point(147, 143);
            this.itemsCalulatorButton.Name = "itemsCalulatorButton";
            this.itemsCalulatorButton.Size = new System.Drawing.Size(114, 45);
            this.itemsCalulatorButton.TabIndex = 2;
            this.itemsCalulatorButton.Text = "Калькулятор предметов";
            this.itemsCalulatorButton.UseVisualStyleBackColor = true;
            this.itemsCalulatorButton.Click += new System.EventHandler(this.itemsCalulatorButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Обновить цены";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 206);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.itemsCalulatorButton);
            this.Controls.Add(this.Blueprints);
            this.Controls.Add(this.projectsAllButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button projectsAllButton;
        private System.Windows.Forms.Button Blueprints;
        private System.Windows.Forms.Button itemsCalulatorButton;
        private System.Windows.Forms.Button button1;
    }
}