using DB_finalproject.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_finalproject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new CustomerUI());
=======
            Application.Run(new SupplierUI());
>>>>>>> d7929333b4f50c8b3729bcb6ddc0f68062817435
        }
    }
}
