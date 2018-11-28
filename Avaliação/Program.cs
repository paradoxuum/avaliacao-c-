using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace insert_csharp
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
            Application.Run(new Login());
        }

        public static string nomeConexao = "Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=EtecBanco;Data Source=LAB-06-05";
    }
}
