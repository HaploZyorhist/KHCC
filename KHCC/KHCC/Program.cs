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

            //sets up cc variable on this form
            CharacterContainer cc = new CharacterContainer();

            // sets up forms variables
            var su = new StartUp();

            // sets up cc variable for passing across forms
            su.cc = cc;


            su.ShowDialog();


            //primary
            //    50 point to gain through leveling
            //    1 every 2 levels

            //secondary
            //    25 points to gain through leveling
            //    1 every 4 levels


            // get the quizz section finished
            // get some leveling up logic done
            // come up with a plan for handling lux and skills
            // ideas for talents

            // setup framework for saving and loading characters

        }
    }
}
