using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KHCC
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

            CharacterBuilder cc = new CharacterBuilder();
            Application.Run(new StartUp());
            Application.Run(new CharacterBuilder());

            //primary
            //    50 point to gain through leveling
            //    1 every 2 levels

            //secondary
            //    25 points to gain through leveling
            //    1 every 4 levels


        }
    }
}
