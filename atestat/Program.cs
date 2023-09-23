using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace atestat
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
            try
            {
                db.con = db.getConnection();
                db.con.Open();
                Application.Run(new baza());
            }
            catch (Exception e)
            {
                Application.Run(new eroareBazaDate(e.Message));
            }

        }
    }
}
