
namespace RoadMap
{
    partial class frm_Settings
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
            this.lab_FlightsTabl = new System.Windows.Forms.Label();
            this.txt_FlightsTablPath = new System.Windows.Forms.TextBox();
            this.b_FindTable = new System.Windows.Forms.Button();
            this.rb_MinCost = new System.Windows.Forms.RadioButton();
            this.rb_MinTansfer = new System.Windows.Forms.RadioButton();
            this.rb_AllVariants = new System.Windows.Forms.RadioButton();
            this.ofd_OpenExcel = new System.Windows.Forms.OpenFileDialog();
            this.b_FindVariant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_FlightsTabl
            // 
            this.lab_FlightsTabl.AutoSize = true;
            this.lab_FlightsTabl.Location = new System.Drawing.Point(31, 23);
            this.lab_FlightsTabl.Name = "lab_FlightsTabl";
            this.lab_FlightsTabl.Size = new System.Drawing.Size(89, 13);
            this.lab_FlightsTabl.TabIndex = 0;
            this.lab_FlightsTabl.Text = "Таблица рейсов";
            // 
            // txt_FlightsTablPath
            // 
            this.txt_FlightsTablPath.Location = new System.Drawing.Point(31, 47);
            this.txt_FlightsTablPath.Name = "txt_FlightsTablPath";
            this.txt_FlightsTablPath.Size = new System.Drawing.Size(276, 20);
            this.txt_FlightsTablPath.TabIndex = 1;
            // 
            // b_FindTable
            // 
            this.b_FindTable.Location = new System.Drawing.Point(310, 46);
            this.b_FindTable.Name = "b_FindTable";
            this.b_FindTable.Size = new System.Drawing.Size(75, 23);
            this.b_FindTable.TabIndex = 2;
            this.b_FindTable.Text = "...";
            this.b_FindTable.UseVisualStyleBackColor = true;
            this.b_FindTable.Click += new System.EventHandler(this.b_FindTable_Click);
            // 
            // rb_MinCost
            // 
            this.rb_MinCost.AutoSize = true;
            this.rb_MinCost.Checked = true;
            this.rb_MinCost.Location = new System.Drawing.Point(34, 82);
            this.rb_MinCost.Name = "rb_MinCost";
            this.rb_MinCost.Size = new System.Drawing.Size(96, 17);
            this.rb_MinCost.TabIndex = 4;
            this.rb_MinCost.TabStop = true;
            this.rb_MinCost.Text = "По стоимости";
            this.rb_MinCost.UseVisualStyleBackColor = true;
            // 
            // rb_MinTansfer
            // 
            this.rb_MinTansfer.AutoSize = true;
            this.rb_MinTansfer.Location = new System.Drawing.Point(34, 105);
            this.rb_MinTansfer.Name = "rb_MinTansfer";
            this.rb_MinTansfer.Size = new System.Drawing.Size(156, 17);
            this.rb_MinTansfer.TabIndex = 5;
            this.rb_MinTansfer.Text = "По количеству пересадок";
            this.rb_MinTansfer.UseVisualStyleBackColor = true;
            // 
            // rb_AllVariants
            // 
            this.rb_AllVariants.AutoSize = true;
            this.rb_AllVariants.Location = new System.Drawing.Point(34, 128);
            this.rb_AllVariants.Name = "rb_AllVariants";
            this.rb_AllVariants.Size = new System.Drawing.Size(96, 17);
            this.rb_AllVariants.TabIndex = 6;
            this.rb_AllVariants.Text = "Все варианты";
            this.rb_AllVariants.UseVisualStyleBackColor = true;
            // 
            // ofd_OpenExcel
            // 
            this.ofd_OpenExcel.FileName = "ExcelFile";
            // 
            // b_FindVariant
            // 
            this.b_FindVariant.Location = new System.Drawing.Point(232, 82);
            this.b_FindVariant.Name = "b_FindVariant";
            this.b_FindVariant.Size = new System.Drawing.Size(153, 63);
            this.b_FindVariant.TabIndex = 7;
            this.b_FindVariant.Text = "Поиск рейсов";
            this.b_FindVariant.UseVisualStyleBackColor = true;
            this.b_FindVariant.Click += new System.EventHandler(this.b_FindVariant_Click);
            // 
            // frm_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 160);
            this.Controls.Add(this.b_FindVariant);
            this.Controls.Add(this.rb_AllVariants);
            this.Controls.Add(this.rb_MinTansfer);
            this.Controls.Add(this.rb_MinCost);
            this.Controls.Add(this.b_FindTable);
            this.Controls.Add(this.txt_FlightsTablPath);
            this.Controls.Add(this.lab_FlightsTabl);
            this.Name = "frm_Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_FlightsTabl;
        private System.Windows.Forms.TextBox txt_FlightsTablPath;
        private System.Windows.Forms.Button b_FindTable;
        private System.Windows.Forms.RadioButton rb_MinCost;
        private System.Windows.Forms.RadioButton rb_MinTansfer;
        private System.Windows.Forms.RadioButton rb_AllVariants;
        private System.Windows.Forms.OpenFileDialog ofd_OpenExcel;
        private System.Windows.Forms.Button b_FindVariant;
    }
}