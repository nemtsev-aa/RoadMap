using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ExcelDataReader;

namespace RoadMap
{
    public partial class frm_Settings : Form
    {
        public string ExcelFileName;

        public frm_Settings()
        {
            InitializeComponent();
        }
        public frm_Settings(frm_FindVariant f)
        {
            InitializeComponent();
        }

        private void b_FindTable_Click(object sender, EventArgs e)
        {
            this.txt_FlightsTablPath.Text = "";
            this.ofd_OpenExcel.Filter = "Excel files(*.xlsx)|*.xlsx|Excel files(*.xls)|*.xls";

            if (this.ofd_OpenExcel.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            ExcelFileName = this.ofd_OpenExcel.FileName.ToString();
            // читаем файл в строку
            this.txt_FlightsTablPath.Text = ExcelFileName;

        }
        private void b_FindVariant_Click(object sender, EventArgs e)
        {
            if (this.txt_FlightsTablPath.Text != "")
            {
                FindOptions.ExcelFilePath = ExcelFileName;
                FindOptions.FilterParametr = PValue();
                this.Hide();
                frm_FindVariant frm_FindVariant = new frm_FindVariant(this);
                frm_FindVariant.Show();
            }
            else
            {
                MessageBox.Show("Таблица рейсов не выбрана!");
            }
        }

        private string PValue()
        {
            if(this.rb_AllVariants.Checked == true)
            {
                return "AllVariants";
            }
            else if(this.rb_MinCost.Checked == true)
            {
                return "MinCost";
            }
            else
            {
                return "MinTansfer";
            }
        }
    }
}
