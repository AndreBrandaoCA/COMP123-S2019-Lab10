using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lab10
{
    static class Program
    {
        static public MainForm MainForm;
        static public StartForm StartForm;
        static public EndForm EndForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm = new MainForm();
            StartForm = new StartForm();
            EndForm = new EndForm();
            Application.Run(StartForm);
        }
        
    }
}
