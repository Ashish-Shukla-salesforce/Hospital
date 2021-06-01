using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFID_SmartHealthCard
{
    public partial class SearchPatients : DevComponents.DotNetBar.Office2007Form 
    {
        public string PID = "";
        public string RFID = "";

        public SearchPatients()
        {
            InitializeComponent();
        }

        private void Searchcs_Load(object sender, EventArgs e)
        {

        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {
            string Keyword = textBoxX1.Text;
            Search(Keyword);
        }
        private void Search(string Keyword)
        {

            string cmd = "select * from patients where PatientName like '%" + Keyword + "%' or Mobile like '%" + Keyword + "%'";
            DataTable t = new DBMySql().ResultQuery(cmd).Tables[0];
            if (t.Rows.Count == 0) { return; }
            dataGridViewX1.DataSource = t;
            dataGridViewX1.Columns[0].Visible = false;
            dataGridViewX1.Columns["RFID"].Visible = false;

        }

        private void dataGridViewX1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewX1.SelectedRows.Count != 1) return;
            this.PID = dataGridViewX1.SelectedRows[0].Cells["PID"].Value.ToString();
            this.RFID = dataGridViewX1.SelectedRows[0].Cells["RFID"].Value.ToString();

            this.Hide();
        }
    }
}
