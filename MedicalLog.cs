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
    public partial class MedicalLog : DevComponents.DotNetBar.Office2007Form
    {
        string PatientID = "";
        public MedicalLog()
        {
            InitializeComponent();
        }
        public MedicalLog(string PID)
        {
            InitializeComponent();
            PatientID = PID;
        }

        private void MedicalLog_Load(object sender, EventArgs e)
        {

        }

    
       

        private void AddNewLogBTN_Click(object sender, EventArgs e)
        {
            new NewLog(PatientID).ShowDialog();
            Search();
        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {

            Search();

        }
        private void Search()
        {
            string StartDate = DBMySql.MySqlDate(StartdateTimePicker.Value);
            string EndDate = DBMySql.MySqlDate(EnddateTimePicker.Value);
            dataGridViewX1.DataSource = null;
            DataTable t = new DBMySql().ResultQuery("select * from logs where PID=" + PatientID + " AND LogDate between '" + StartDate + "' and '" + EndDate + "'").Tables[0];
            if (t.Rows.Count == 0) return;
            dataGridViewX1.DataSource = t;
            dataGridViewX1.Columns["Description"].Visible = false;
            dataGridViewX1.Columns["PID"].Visible = false;
            dataGridViewX1.Columns["PLID"].Visible = false;

            DisplayRowData(0);
        }

        private void PrevLog_Click(object sender, EventArgs e)
        {
            int index=dataGridViewX1.SelectedRows[0].Index;
            if (index == 0) return;
            DisplayRowData(index - 1);dataGridViewX1.Rows[index - 1].Selected=true;

        }

        private void NextLog_Click(object sender, EventArgs e)
        {
            int index = dataGridViewX1.SelectedRows[0].Index;
            if (index == dataGridViewX1.Rows.Count - 1) return;
            DisplayRowData(index + 1);dataGridViewX1.Rows[index + 1].Selected = true;
        }
        private void DisplayRowData(int Index)
        {
            LogDateL.Text = "Date - " + dataGridViewX1.Rows[Index].Cells["LogDate"].Value.ToString();
            DescriptionTB.Text=  dataGridViewX1.Rows[Index].Cells["Description"].Value.ToString();
            LogTitleL.Text =  dataGridViewX1.Rows[Index].Cells["LogTitle"].Value.ToString();
            DoctorL.Text = "Examined By - " + dataGridViewX1.Rows[Index].Cells["ExaminedBy"].Value.ToString();
        }

      

        private void dataGridViewX1_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.SelectedRows.Count == 0) return;
            int index = dataGridViewX1.SelectedRows[0].Index;
         
            DisplayRowData(index);
        }

        private void dataGridViewX1_DoubleClick(object sender, EventArgs e)
        {
            new NewLog(dataGridViewX1.SelectedRows[0].Cells["PLID"].Value.ToString(),true).ShowDialog();
        }

       

        private void dataGridViewX1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.SelectedRows.Count == 0) return;
           
            if (MessageBox.Show("Are you sure want to delete Log Record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No) return;
            string PLID = dataGridViewX1.SelectedRows[0].Cells["PLID"].Value.ToString();
            new DBMySql().NonQuery("delete from logs where PLID=" + PLID);
            Search();
        }

     
    }
}
