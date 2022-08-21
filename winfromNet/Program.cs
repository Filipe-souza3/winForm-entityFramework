using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using winfromNet.models;

namespace winfromNet
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (var context = new CarroContext())
            {
                // Creates the database if not exists
                context.Database.EnsureCreated();
            }
            Application.Run(new Form1());

        }
    }
}
