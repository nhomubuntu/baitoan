using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Windows.Forms;
//using System.Data;
//using System.Data.SqlClient;

namespace baitaplon
{
     static class Program
    {
         public static string strConn = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=QLCHMT;Integrated Security=True";
        /// <summary>
        /// The main entry point for the application
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

