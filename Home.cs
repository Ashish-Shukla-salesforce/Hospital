using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFID_SmartHealthCard
{
           
    public partial class Home : DevComponents.DotNetBar.Office2007Form
    {   
        string DataRecieved = "";
   
        string ID = "";
        string PID = "";
        public Home()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

            //List<string> Patients = new DBMySql().ColumnQuery("SELECT CONCAT('#',PID,'# - ',`PatientName`,'[',`Age`,'] - ',`BloodGroup`,'    #',`RFID`) FROM `patients`");
            //foreach(string s in Patients) PatientCB.Items.Add(s);
            Reset();
        }
        void Reset()
        {
            InfoL.Text = "Name" + Environment.NewLine + Environment.NewLine + "Age" + Environment.NewLine + Environment.NewLine + "Blood Group" + Environment.NewLine + Environment.NewLine
                + "Mobile" + Environment.NewLine + Environment.NewLine + "Email" + Environment.NewLine + Environment.NewLine + "Address";
                //+ "Mobile" + Environment.NewLine + Environment.NewLine + "Email" + Environment.NewLine + Environment.NewLine + "Address";

            pictureBox1.Image = Properties.Resources.Patient;
            InValidCardL.Text = "";
            LogBTN.Enabled = false;
        }
        private void LoadPatientinfo(string PID)
        {
            Reset();
            DataRecieved = "";
            DataTable t = new DBMySql().ResultQuery("select * from patients where RFID='" + PID + "' or PID='" + PID + "'").Tables[0];
            if (t.Rows.Count == 0) { InValidCardL.Text = "Invalid Card Punch"; return; }//RFIDSerialPort.Write("D");
            LogBTN.Enabled = true;
            DataRow r = t.Rows[0];
            InfoL.Text = "Name = " + r["PatientName"].ToString() + Environment.NewLine + Environment.NewLine + "Mobile = " + r["Mobile"].ToString() + Environment.NewLine + Environment.NewLine
                + "Age = " + r["Age"].ToString() + Environment.NewLine + Environment.NewLine + "Blood Group = " + r["BloodGroup"].ToString() + Environment.NewLine + Environment.NewLine
                + "Address = " + r["Address"].ToString();// +Environment.NewLine + Environment.NewLine + "Vehicle Type = " + r["VehicleType"].ToString();

            ID = r["PID"].ToString();
            
            if (File.Exists("Images\\" + ID + ".jpg")) { pictureBox1.ImageLocation = "Images\\" + ID + ".jpg"; }


           
        }

        

        private void buttonX5_Click(object sender, EventArgs e)
        {
          
        }

        private void PatientBTN_Click(object sender, EventArgs e)
        {
            new Patients().ShowDialog();
        }

        private void LogOutBTN_Click(object sender, EventArgs e)
        {
            this.Dispose();
            AppData.ObjLogin.Show();
        }

        private void SettingBTN_Click(object sender, EventArgs e)
        {
            new Settings().ShowDialog();
        }

        private void ScanCardBTN_Click(object sender, EventArgs e)
        {
            //LoadCardinfo("ABCD1234EFGH5678"); return;
           
            Fetch f = new Fetch(100, Properties.Settings.Default.RFIDPortName);
            f.ShowDialog();
            if (f.DataReceived == "") { MessageBox.Show("No Data Received"); }
            else { MessageBox.Show("Received Data Values = " + f.DataReceived); }
            DataRecieved = f.DataReceived;
            f.Dispose();
            LoadPatientinfo(DataRecieved);
        }

        private void LogBTN_Click(object sender, EventArgs e)
        {
            //string PID = PatientCB.SelectedItem.ToString().Substring(1);
            //PID =PID.Substring(0, PID.IndexOf("#"));
            if (!ID.Equals("")) new MedicalLog(ID).ShowDialog();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            AppData.ObjLogin.Show();
        }

       

        private void SearchPatientBTN_Click(object sender, EventArgs e)
        {
            SearchPatients ob = new SearchPatients();
            ob.ShowDialog();
            
            PID = ob.PID;
            ob.Dispose();
            LoadPatientinfo(PID);
           
        }
    }
}
