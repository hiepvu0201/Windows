using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace testProject
{
    static class Program
    {
        public static Pen myPen;
        public static Color myColor;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            myColor = Color.Blue;
            myPen = new Pen(myColor, 1);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmWelcome());
        }
    }
}
