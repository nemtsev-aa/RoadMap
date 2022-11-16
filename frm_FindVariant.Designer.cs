
namespace RoadMap
{
    partial class frm_FindVariant
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_StartPoint = new System.Windows.Forms.ComboBox();
            this.cb_EndPoint = new System.Windows.Forms.ComboBox();
            this.lab_StartPoint = new System.Windows.Forms.Label();
            this.lab_EndPoint = new System.Windows.Forms.Label();
            this.b_Run = new System.Windows.Forms.Button();
            this.lab_RoadVariant = new System.Windows.Forms.Label();
            this.dgv_FlightsTabl = new System.Windows.Forms.DataGridView();
            this.lb_RoadVariant = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FlightsTabl)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_StartPoint
            // 
            this.cb_StartPoint.FormattingEnabled = true;
            this.cb_StartPoint.Location = new System.Drawing.Point(35, 36);
            this.cb_StartPoint.Name = "cb_StartPoint";
            this.cb_StartPoint.Size = new System.Drawing.Size(260, 21);
            this.cb_StartPoint.TabIndex = 0;
            this.cb_StartPoint.SelectedValueChanged += new System.EventHandler(this.cb_StartPoint_SelectedValueChanged);
            // 
            // cb_EndPoint
            // 
            this.cb_EndPoint.FormattingEnabled = true;
            this.cb_EndPoint.Location = new System.Drawing.Point(35, 101);
            this.cb_EndPoint.Name = "cb_EndPoint";
            this.cb_EndPoint.Size = new System.Drawing.Size(260, 21);
            this.cb_EndPoint.TabIndex = 1;
            this.cb_EndPoint.SelectedValueChanged += new System.EventHandler(this.cb_EndPoint_SelectedValueChanged);
            // 
            // lab_StartPoint
            // 
            this.lab_StartPoint.AutoSize = true;
            this.lab_StartPoint.Location = new System.Drawing.Point(32, 20);
            this.lab_StartPoint.Name = "lab_StartPoint";
            this.lab_StartPoint.Size = new System.Drawing.Size(105, 13);
            this.lab_StartPoint.TabIndex = 2;
            this.lab_StartPoint.Text = "Пункт отправления";
            // 
            // lab_EndPoint
            // 
            this.lab_EndPoint.AutoSize = true;
            this.lab_EndPoint.Location = new System.Drawing.Point(32, 85);
            this.lab_EndPoint.Name = "lab_EndPoint";
            this.lab_EndPoint.Size = new System.Drawing.Size(99, 13);
            this.lab_EndPoint.TabIndex = 3;
            this.lab_EndPoint.Text = "Пункт назначения";
            // 
            // b_Run
            // 
            this.b_Run.Location = new System.Drawing.Point(35, 321);
            this.b_Run.Name = "b_Run";
            this.b_Run.Size = new System.Drawing.Size(260, 38);
            this.b_Run.TabIndex = 5;
            this.b_Run.Text = "В путь";
            this.b_Run.UseVisualStyleBackColor = true;
            // 
            // lab_RoadVariant
            // 
            this.lab_RoadVariant.AutoSize = true;
            this.lab_RoadVariant.Location = new System.Drawing.Point(32, 144);
            this.lab_RoadVariant.Name = "lab_RoadVariant";
            this.lab_RoadVariant.Size = new System.Drawing.Size(110, 13);
            this.lab_RoadVariant.TabIndex = 6;
            this.lab_RoadVariant.Text = "Варианты маршрута";
            // 
            // dgv_FlightsTabl
            // 
            this.dgv_FlightsTabl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_FlightsTabl.Location = new System.Drawing.Point(328, 20);
            this.dgv_FlightsTabl.Name = "dgv_FlightsTabl";
            this.dgv_FlightsTabl.Size = new System.Drawing.Size(383, 339);
            this.dgv_FlightsTabl.TabIndex = 9;
            // 
            // lb_RoadVariant
            // 
            this.lb_RoadVariant.FormattingEnabled = true;
            this.lb_RoadVariant.Location = new System.Drawing.Point(35, 169);
            this.lb_RoadVariant.Name = "lb_RoadVariant";
            this.lb_RoadVariant.Size = new System.Drawing.Size(260, 134);
            this.lb_RoadVariant.TabIndex = 10;
            // 
            // frm_FindVariant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 314);
            this.Controls.Add(this.lb_RoadVariant);
            this.Controls.Add(this.dgv_FlightsTabl);
            this.Controls.Add(this.lab_RoadVariant);
            this.Controls.Add(this.b_Run);
            this.Controls.Add(this.lab_EndPoint);
            this.Controls.Add(this.lab_StartPoint);
            this.Controls.Add(this.cb_EndPoint);
            this.Controls.Add(this.cb_StartPoint);
            this.Name = "frm_FindVariant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор маршрута";
            this.Load += new System.EventHandler(this.frm_FindVariant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FlightsTabl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_StartPoint;
        private System.Windows.Forms.ComboBox cb_EndPoint;
        private System.Windows.Forms.Label lab_StartPoint;
        private System.Windows.Forms.Label lab_EndPoint;
        private System.Windows.Forms.Button b_Run;
        private System.Windows.Forms.Label lab_RoadVariant;
        private System.Windows.Forms.DataGridView dgv_FlightsTabl;
        private System.Windows.Forms.ListBox lb_RoadVariant;
    }
}

