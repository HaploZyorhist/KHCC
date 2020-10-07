using KHCC.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KHCC.forms
{
    public partial class SkillShop : Form
    {

        public CharacterContainer cc { get; set; }
        public SkillShop()
        {
            InitializeComponent();

            cc.skills = populateSkills();
            // what is in skill (1)

        }

        /// <summary>
        /// Populate all skills within the shop
        /// </summary>
        private List<Skill> populateSkills()
        {
            List<Skill> skillContainer = new List<Skill>();
            // cleave
            skillContainer.Add(new Skill()
            {
                name = "cleave",
                description = "",
                reload = 0,
                cost = 0,
                purchaseable = true

            });

            return skillContainer;
        }
    }
}
