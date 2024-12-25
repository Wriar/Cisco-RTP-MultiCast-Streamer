using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ciscoRTPStream
{
    internal static class Program
    {
        //Import the SetProcessDPIAware function from user32.dll
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Enable high DPI Scaling Support
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();
            Application.Run(new rtpStreamMain());
        }

        
    }
}
