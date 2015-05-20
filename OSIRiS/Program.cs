using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace OSIRiS
{
    static class Program
    {
        public static splash splash = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //show splash
            Thread splashThread = new Thread(new ThreadStart(
                delegate
                {
                    splash = new splash();
                    Application.Run(splash);
                }
                ));

            splashThread.SetApartmentState(ApartmentState.STA);
            splashThread.Start();

            //run form - time taking operation
            OSIRiSmainwindow OSIRiSmainwindow = new OSIRiSmainwindow();
            OSIRiSmainwindow.Load += new EventHandler(OSIRiSmainwindow_Load);
            Application.Run(OSIRiSmainwindow);
        }

        static void OSIRiSmainwindow_Load(object sender, EventArgs e)
        {
            //close splash
            if (splash == null)
            {
                return;
            }

            splash.Invoke(new Action(splash.Close));
            splash.Dispose();
            splash = null;
        }
    }
}

