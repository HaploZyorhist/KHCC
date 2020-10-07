using KHCC.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KHCC
{
    public partial class StartUp : Form
    {

        public int bodyBase;

        public CharacterContainer cc { get; set; }

        public StartUp()
        {
            InitializeComponent();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (rbtnNewCharacter.Checked)
            {
                this.Hide();
                var pw = new PickWeapon();
                pw.cc = cc;
                pw.ShowDialog();
            }
            if (rbtnLoadCharacter.Checked)
            {

            }
        }
    }
}
