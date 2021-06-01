using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Net.NetworkInformation;
using System.Net.Sockets;
namespace RFID_SmartHealthCard
{
    class AppData
    {
        public static string Server = "";
        public static string PatientID = "1";
        public static bool ConnectionState = false;
        public static Login ObjLogin;
        public static Home ObjHome = new Home();
        //SMS command ------------ AT+CMGS="9044580971"\n \r <Message>     CTRL+Z or 26 
        
        public static string[] Classes = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
        public static string[] Nationalities = { "Indian", "Others", };
        public static string[] Religion = { "Hindu", "Muslim", "Christian", "Sikh", "Parsi", "Jain", "Boddh" };
        public string[] Stations = { "Airport", "TransportNagar", "KrishnaNagar", "Awadh", "RajajiPuram", "Alambagh", "Charbagh" };


        public static int ChargePerStation = 10;

 

        public enum MessageMode { Manual, Automatic, GSM };
        public static string DefaultMessageMode = MessageMode.Manual.ToString();

        public static int ChargesPerDay = 10;
        public static string MySqlDate(DateTime dt)
        {
            string Month = dt.Month.ToString();
            if (dt.Month < 10) { Month = "0" + Month; }
            string day = dt.Day.ToString();
            if (dt.Day < 10) { day = "0" + day; }
            return dt.Year.ToString() + "-" + Month + "-" + day;

        }
        public string GetGsmMessage(SerialPort SP)
        {

            try
            {
                if (!SP.IsOpen) { SP.Open(); }
                Thread.Sleep(200);
                SP.Write("AT+CMGR=1" + "\r");
                Thread.Sleep(500);
                string msg = SP.ReadExisting();
                SP.Close();
                msg = GetMsg(msg);
                return msg;
            }

            catch (Exception ex) { return ex.Message; }
        }
        private string GetMsg(string Msg)
        {
            int count = 0;
            foreach (char c in Msg) { if (c.Equals('$')) { count++; continue; } if (c.Equals('#')) { count++; continue; } }
            if (count != 2) { return "OK"; }
            Msg = Msg.Substring(Msg.IndexOf('#') + 1);
            Msg = Msg.Substring(0, Msg.LastIndexOf('$'));
            return Msg;
        }
        public string GetAutomaticMessage(SerialPort SP)
        {
            bool state = SP.IsOpen;
            if (!state) { SP.Open(); }
            System.Threading.Thread.Sleep(500);
            string Data = SP.ReadExisting();
            if (!state) { SP.Close(); }
            return Data;
        }
        public bool SendMsgOnPort(string Msg)
        {
            return SendMsgOnPort(Msg,Properties.Settings.Default.RFIDPortName);

        }

        public static string FilterSMS(string Msg)
        {
            int count1 = 0, count2 = 0;
            foreach (char c in Msg) { if (c.Equals('$')) { count1++; continue; } }

            foreach (char c in Msg) { if (c.Equals('#')) { count2++; continue; } }
            if (count1 != 1 || count2 != 1) { return "Invalid Message"; }
            Msg = Msg.Substring(Msg.IndexOf('#') + 1);
            Msg = Msg.Substring(0, Msg.LastIndexOf('$'));
            return Msg;
        }
        public bool SendMsgOnPort(string Msg, string PortName)
        {
            return SendMsgOnPort(Msg, new SerialPort(PortName));

        }
        public bool SendMsgOnPort(string Msg, SerialPort sp)
        {
            try
            {
                if (!sp.IsOpen) { sp.Open(); }
                sp.Write(Msg);
                sp.Close();
                sp.Dispose();
                return true;

            }
            catch { MessageBox.Show("Card Scanner Comunication Failed"); return false; }
        }
       
        public void SendSms(string Msg, string MobileNo, string GSMPortName)
        {
            SendSms(Msg, MobileNo, new SerialPort(GSMPortName));

        }
        public void SendSms(string Msg, string MobileNo, SerialPort SP)
        {

            SerialPort serialPort1 = SP;
            bool State = serialPort1.IsOpen;
            try
            {
                if (!serialPort1.IsOpen) { serialPort1.Open(); }
            }
            catch (Exception ex) { MessageBox.Show("GSM Module Communication Error !!!"); return; }
            Thread.Sleep(1000);
            //serialPort1.Write("ATE0");


            serialPort1.Write("AT+CMGF=1\r\n"); Thread.Sleep(500);

            //string n = "7525902910";
            serialPort1.Write("AT+CMGS=\"" + MobileNo + "\"\r\n"); Thread.Sleep(500);

            //serialPort1.Write("AT+CMGS=" + char.ConvertFromUtf32(34) + n + char.ConvertFromUtf32(34) ); 

            //Msg = "Test Message ";
            serialPort1.Write(Msg); Thread.Sleep(500);


            serialPort1.Write(((char)(26)).ToString());
            //serialPort1.Write("\x1A");


            System.Threading.Thread.Sleep(1000);
            //serialPort1.Write("ATE1");
            if (!State) { serialPort1.Close(); }

        }
        public void Ping() { Ping(AppData.Server); }
        public bool Ping(string ServerHost)
        {
            Ping pp = new Ping();

            PingReply pr = pp.Send(System.Net.IPAddress.Parse(ServerHost));
            pp.Dispose();
            ConnectionState = pr.Status == IPStatus.Success;
            return ConnectionState;
        }
        public bool PingHost(string hostUri, int portNumber)
        {
            try
            {
                using (var client = new TcpClient(hostUri, portNumber))
                    return true;
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Error pinging host:'" + hostUri + ":" + portNumber.ToString() + "'");
                return false;
            }
        }



    }
}
