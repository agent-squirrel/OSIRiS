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
            using (Mutex mutex = new Mutex(false, "Global\\" + appGuid))
            {
                if (!mutex.WaitOne(0, false))
                {
                    MessageBox.Show("OSIRiS is already running." + Environment.NewLine + "Only one copy of OSIRiS can run at once.","Already Running");
                    return;
                }
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
        private static string appGuid = "c0a76b5a-12ab-45c5-b9d9-d693faa6e7b7";

    }
}

