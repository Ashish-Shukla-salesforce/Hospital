using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFID_SmartHealthCard
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();                                                                                                                                                                      if (new DateTime(2021, 6, 30)< DateTime.Now) return;

            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
