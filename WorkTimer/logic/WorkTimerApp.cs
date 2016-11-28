using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace WorkTimer
{
    public class WorkTimerApp
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length > 0 && args[0].Equals("-a")) {
                LoginTimeFile loginTimeFile = new LoginTimeFile();
                loginTimeFile.UpdateFile(new WorkDayInterval(), true);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WorkTimerApplicationContext());
        }
    }
}
