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
    public partial class NewLog : DevComponents.DotNetBar.Office2007Form
    {
        string PLID = "";
        string PID = "";

        public NewLog()
        {
            InitializeComponent();
        }
        public NewLog(string PID)
        {
            InitializeComponent();
            this.PID = PID;
        }
        public NewLog(string PLID,bool Edit)
        {
            InitializeComponent();
            this.PLID = PLID;
        }

        private void textBoxX3_TextChanged(object sender, EventArgs e)
        {
            labelX2.Text = "Description - " + DescriptionTB.Text.Length.ToString() + " / 1000";
        }

        private void DoneBTN_Click(object sender, EventArgs e)
        {
            if (!superValidator1.Validate()) return;
            string Title = TitleTB.Text.Trim();
            string Date = DBMySql.MySqlDate(LogDate.Value);
            string LogType = TypeCB.SelectedItem.ToString();
            string LogReport = FinalReportTypeCB.SelectedItem.ToString();

            string ExaminedBy = ExaminedByTB.Text.Trim();
            string Description = DescriptionTB.Text;
            string CMD = "INSERT INTO `logs`(`LogTitle`,`ExaminedBy`,`LogDate`,`LogType`,`Description`,`PID`,LogReport) VALUES('" + Title + "','" + ExaminedBy + "','" + Date + "','" + LogType + "','" + Description + "'," + PID + ",'" + LogReport + "')";
            if (!PLID.Equals("")) { CMD = "UPDATE `logs` set `LogTitle`='" + Title + "',`ExaminedBy`='" + ExaminedBy + "',`LogDate`='" + Date + "',`LogType`='" + LogType + "',`Description`='" + Description + "',LogReport='" + LogReport + "' where `PLID`=" + PLID; }
            new DBMySql().NonQuery(CMD);
            this.Dispose();
        }

        private void NewLog_Load(object sender, EventArgs e)
        {
           

            if (PLID.Equals("")) return;
            LogIdL.Text = "#"+PLID;
            DataRow dr = new DBMySql().ResultQuery("select * from logs where PLID="+PLID).Tables[0].Rows[0];
            TitleTB.Text = dr["LogTitle"].ToString();
            LogDate.Value = DateTime.Parse(dr["LogDate"].ToString());
            DescriptionTB.Text = dr["Description"].ToString();
            ExaminedByTB.Text = dr["ExaminedBy"].ToString();
            TypeCB.Text = dr["LogType"].ToString();
            FinalReportTypeCB.Text = dr["LogReport"].ToString();
            
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
