using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFID_SmartHealthCard
{
    public partial class Login : DevComponents.DotNetBar.Office2007Form
    {
        public Login()
        {
            InitializeComponent();
            AppData.ObjLogin = this;
        }


        private void LoginBTN_Click(object sender, EventArgs e)
        {
            new Home().Show(); return;
            string UserName = EmailTB.Text;
            string Password = PasswordTB.Text;

            if (new DBMySql().ScalarQuery("select Count(username) from users where email='" + UserName + "' and pwd='" + Password + "'").Equals("1"))
            {
                this.Hide();
                AppData.ObjLogin = this;
                new Home().Show();
            }
            else { MessageBox.Show("Invalid Id Password"); }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //switchButton2.Value = Properties.Settings.Default.WorkOnline;
            if (Properties.Settings.Default.WorkOnline && !new DBMySql().TestMySqlConnection()) { MessageBox.Show("Database Server Not Found"); return; }
        }
        private void switchButton2_ValueChanged(object sender, EventArgs e)
        {
           // Properties.Settings.Default.WorkOnline = switchButton2.Value;
           // Properties.Settings.Default.Save();
        }

        //private void switchButton2_ValueChanged_1(object sender, EventArgs e)
        //{
        //    Properties.Settings.Default.WorkOnline = switchButton2.Value;
        //    Properties.Settings.Default.Save();
        //}

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
