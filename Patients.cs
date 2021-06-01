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
    public partial class Patients : DevComponents.DotNetBar.Office2007Form
    {
      
        public Patients()
        {
            InitializeComponent();
            BloodGroupCB.SelectedIndex = 0;
            if (!Directory.Exists("Images")) { Directory.CreateDirectory("Images"); }
        }


        bool EditMode = false;
        string ID = "";

        private void LoadUser(string RFID)
        {

            DataTable t = new DBMySql().ResultQuery("Select * from patients where RFID='" + RFID + "'").Tables[0];
            if (t.Rows.Count == 0) { return; }
            EditMode = true;
            this.ID = t.Rows[0]["PID"].ToString();
            NameTB.Text = t.Rows[0]["UserName"].ToString();
            //GenderCB.Text = t.Rows[0]["gender"].ToString();

            MobileTB.Text = t.Rows[0]["Mobile"].ToString();

            RfidTb.Text = t.Rows[0]["RFID"].ToString();


            AgeTB.Text = t.Rows[0]["Age"].ToString();
            if (File.Exists("Images/" + ID + ".jpg"))
            { pictureBox1.ImageLocation = "Images/" + ID + ".jpg"; }
        }



        private void FetchBTN_Click(object sender, EventArgs e)
        {
            Fetch f = new Fetch(100,Properties.Settings.Default.RFIDPortName);
            f.ShowDialog();
            if (f.DataReceived.Equals("")) { MessageBox.Show("No Data Recieved"); f.Dispose(); return; }
            RfidTb.Text = f.DataReceived;
            f.Dispose();
            LoadUser(RfidTb.Text);

        }

        private void CancleBTN_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void Reset()
        {
            BloodGroupCB.SelectedIndex = 0;
            NameTB.Text = MobileTB.Text = AgeTB.Text = RfidTb.Text = "";
            EditMode = false;
            AddressTB.Text = EmailTB.Text= "";

        }
        private void DoneBTN_Click(object sender, EventArgs e)
        {
            string cmd = "";
            if (!superValidator1.Validate()) { return; }
            string name = NameTB.Text.Trim();
            string Address = AddressTB.Text;



            string Mobile = MobileTB.Text;

            // string Aadhar = AadharTB.Text.Trim();

            string RFID = RfidTb.Text.Trim();
            string Email = EmailTB.Text.Trim();
            string BloodGroup = BloodGroupCB.SelectedItem.ToString();
            string Age = AgeTB.Text;
            if (EditMode)
            {
                cmd = "update patients set PatientName='" + name + "',Mobile='" + Mobile + "',RFID='" + RFID + "',Email='" + Email + "',Age=" + Age + ",Address='"+Address+"',BloodGroup='" + BloodGroup + "' where PID=" + ID;
                new DBMySql().NonQuery(cmd);
            }
            else
            {
                cmd = "insert  into `patients`(`PatientName`,`Mobile`,`RFID`,Email,BloodGroup,Age,Address,CardIssueDate) values ('" + name + "','" + Mobile + "','" + RFID + "','" + Email + "','" + BloodGroup.ToUpper() + "'," + Age + ",'" + Address + "',NOW());";
                new DBMySql().NonQuery(cmd);
                //string ID = new DBMySql().ScalarQuery("Select pid from Passengers where rfidno='" + RFID + "'");
                if (pictureBox1.Image != null) { pictureBox1.Image.Save("Images/" + ID + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg); }
            }
            if (pictureBox1.Image != null && !pictureBox1.ImageLocation.Equals("Images/" + ID + ".jpg"))
            {
                File.Delete("Images/" + ID + ".jpg");
                pictureBox1.Image.Save("Images/" + ID + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            //new AppData().SendMsgOnPort("A");
            MessageBox.Show("Information Updated", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Reset();
            Search(SearchTB.Text.Trim());
        }

        private void BrowseBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "*.JPG|*.JPG";
            op.ShowDialog();
            if (op.FileName.Equals("")) { return; }
            pictureBox1.ImageLocation = op.FileName;
        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {
            if (!superValidator1.Validate(SearchTB)) { return; }
            Search(SearchTB.Text.Trim());
        }
        private void Search(string RFIDorIDorName)
        {

            string cmd = "select * from patients where PatientName like '%" + RFIDorIDorName + "%' or Mobile like '%" + RFIDorIDorName + "%'";
            DataTable t = new DBMySql().ResultQuery(cmd).Tables[0];
            if (t.Rows.Count == 0) { return; }
            dataGridViewX1.DataSource = t;
            dataGridViewX1.Columns[0].Visible = false;
            
        }

        private void dataGridViewX1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewX1.SelectedRows.Count == 0) { return; }
            NameTB.Text = MobileTB.Text = RfidTb.Text = this.ID = ""; pictureBox1.Image = null;
            DataGridViewRow r = dataGridViewX1.SelectedRows[0];
            NameTB.Text = r.Cells["PatientName"].Value.ToString();
            MobileTB.Text = r.Cells["Mobile"].Value.ToString();
            RfidTb.Text = r.Cells["RFID"].Value.ToString();
            AgeTB.Text = r.Cells["Age"].Value.ToString();
            //AadharTB.Text = r.Cells["Aadharno"].Value.ToString();
            AddressTB.Text = r.Cells["Address"].Value.ToString();
            EmailTB.Text = r.Cells["Email"].Value.ToString();

            //VTypeCB.Text = r.Cells["VehicleType"].Value.ToString();


            ID = r.Cells["PID"].Value.ToString();
            if (File.Exists("Images/" + ID + ".jpg"))
            { pictureBox1.ImageLocation = "Images/" + ID + ".jpg"; }
            EditMode = true;
        }

      
      

        private void Patients_Load(object sender, EventArgs e)
        {
            BloodGroupCB.SelectedIndex = 0;
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.SelectedRows.Count == 0) { return; }
            if (MessageBox.Show("Confirm Delete ?", "Confirmation !", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No) return;
            string PID = dataGridViewX1.SelectedRows[0].Cells["PID"].Value.ToString();
            new DBMySql().NonQuery("delete from patients where PID=" + PID);

        }


    }
}
