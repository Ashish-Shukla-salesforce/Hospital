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
    public partial class Fetch : DevComponents.DotNetBar.Office2007Form
    {
        int StartTime = 0;
        int TimeOut = 0;
        public string temp = "", DataReceived = "";
        public Fetch()
        {
            InitializeComponent();
        }
        public Fetch(int TimeOut)
        {
            InitializeComponent();
            this.TimeOut = TimeOut;
            serialPort1.PortName = Properties.Settings.Default.RFIDPortName;
        }
        public Fetch(int TimeOut, string PortName)
        {
            InitializeComponent();
            serialPort1.PortName = PortName;
            this.TimeOut = TimeOut;
        }
        private void Fetch_Load(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen) { serialPort1.Open(); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            System.Threading.Thread.Sleep(500);
            string s = serialPort1.ReadExisting();
            DataReceived = DataReceived + s;
            if (DataReceived.Length == 12)
            {

            }
        }

        public void SetControlText(Control control, string text)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<Control, string>(SetControlText), new object[] { control, text });
            }
            else
            {
                control.Text = text.Trim();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (DataReceived.Length == 12) { this.Hide(); }
            if (StartTime >= TimeOut) { this.Hide(); serialPort1.Close(); DataReceived = ""; }
            StartTime++;
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen) { serialPort1.Close(); }
            this.Hide();
        }
    }
}
