using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFID_SmartHealthCard
{
    public partial class Settings : DevComponents.DotNetBar.Office2007Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(SerialPort.GetPortNames());

            listBox1.SelectedIndex = listBox1.Items.IndexOf(Properties.Settings.Default.RFIDPortName);

        }

       

        private void SaveCloseBTN_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1) { Properties.Settings.Default.RFIDPortName = listBox1.SelectedItem.ToString(); }




            Properties.Settings.Default.Save();
            this.Dispose();
        }

        private void RFIDCheckBTN_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) { return; }
            Fetch f = new Fetch(100, listBox1.SelectedItem.ToString());
            f.ShowDialog();
            if (f.DataReceived == "") { MessageBox.Show("No Data Received"); }
            else { MessageBox.Show("Received Data Values = " + f.DataReceived); }
            f.Dispose();
        }
    }
}
