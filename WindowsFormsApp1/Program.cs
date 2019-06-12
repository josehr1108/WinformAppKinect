using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 mainWindow = new Form1();
            KinnectController kinect = new KinnectController(mainWindow);
            Thread kinnectThread = new Thread(kinect.startThread);
            kinnectThread.Start();
            Application.Run(mainWindow);
            Console.Write("Paso el bucle");
            //MessageBox.Show("Oh noes!", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
