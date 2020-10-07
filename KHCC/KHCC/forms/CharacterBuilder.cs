using KHCC.forms;
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

namespace KHCC
{
    public partial class CharacterBuilder : Form
    {
        public CharacterContainer cc { get; set; }
        public StartUp su { get; set; }

        // initialize handlers for text boxes
        int magTotal;
        int spdTotal;
        int bodTotal;

        int powTotal;
        int finTotal;
        int frtTotal;

        int primRemaining;
        int secoRemaining;

        int strength;
        int vitality;
        int dexterity;

        int agility;
        int stamina;
        int reflex;

        int spirit;
        int aura;
        int sorcery;

        // end of handler initialization

        public CharacterBuilder()
        {
            InitializeComponent();

            //var ss = new SkillShop();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblPlayer.Text = cc.playerName;
            lblCharacter.Text = cc.characterName;

            // attempt to set races
            cmbRace.Items.Add("Human");
            cmbRace.Items.Add("Moogle");
            cmbRace.Items.Add("Yordle");

            // set default race
            cmbRace.SelectedIndex = 0;

            UpdateDisplay();
        }

        // --------------------------------------------------------------------------------------------------------------------------
        // ------------------------------------ (+) Buttons -------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------------------------------
        private void btnBodP_Click(object sender, EventArgs e)
        {
            if (primRemaining > 0)
            {

                if (bodTotal < 30)
                {
                    cc.body++;
                    primRemaining--;

                    UpdateDisplay();
                }
            }
        }

        private void btnSpdP_Click(object sender, EventArgs e)
        {
            if (primRemaining > 0)
            {

                if (spdTotal < 30)
                {
                    cc.speed++;
                    primRemaining--;

                    UpdateDisplay();
                }
            }

        }

        private void btnMagP_Click(object sender, EventArgs e)
        {
            if (primRemaining > 0)
            {

                if (magTotal < 30)
                {
                    cc.magic++;
                    primRemaining--;

                    UpdateDisplay();
                }
            }
        }

        private void btnPowP_Click(object sender, EventArgs e)
        {
            if (secoRemaining > 0)
            {

                if (powTotal < 25)
                {
                    cc.power++;
                    secoRemaining--;

                    UpdateDisplay();

                }
            }

        }

        private void btnFrtP_Click(object sender, EventArgs e)
        {
            if (secoRemaining > 0)
            {

                if (frtTotal < 25)
                {
                    cc.fortitude++;
                    secoRemaining--;

                    UpdateDisplay();

                }
            }
        }

        private void btnFinP_Click(object sender, EventArgs e)
        {
            if (secoRemaining > 0)
            {

                if (finTotal < 25)
                {
                    cc.finesse++;
                    secoRemaining--;

                    UpdateDisplay();

                }
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------
        // ------------------------------------ (+) Buttons End----------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------------------------------
        // ------------------------------------ (-) Buttons -------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------------------------------

        private void btnBodM_Click(object sender, EventArgs e)
        {
            if (cc.body > 0)
            {

                cc.body--;
                primRemaining++;

                UpdateDisplay();

            }

        }

        private void btnSpdM_Click(object sender, EventArgs e)
        {
            if (cc.speed > 0)
            {
                cc.speed--;
                primRemaining++;

                UpdateDisplay();
            }
        }

        private void btnMagM_Click(object sender, EventArgs e)
        {
            if (cc.magic > 0)
            {
                cc.magic--;
                primRemaining++;

                UpdateDisplay();
            }
        }

        private void btnPowM_Click(object sender, EventArgs e)
        {
            if (cc.power > 0)
            {
                cc.power--;
                secoRemaining++;

                UpdateDisplay();

            }

        }

        private void btnFrtM_Click(object sender, EventArgs e)
        {
            if (cc.fortitude > 0)
            {
                cc.fortitude--;
                secoRemaining++;

                UpdateDisplay();

            }
        }

        private void btnFinM_Click(object sender, EventArgs e)
        {
            if (cc.finesse > 0)
            {
                cc.finesse--;
                secoRemaining++;

                UpdateDisplay();

            }

        }

        private void cmbRace_SelectedIndexChanged(object sender, EventArgs e)
        {

            // races get a net 7 gain to primaries and net 3 gain to secondaries
            // give humans a bonus starting skill
            if (cmbRace.Text == "Human")
            {
                cc.race = cmbRace.Text;
                cc.bodyRace = 0;
                cc.speedRace = 0;
                cc.magicRace = 0;
                cc.powerRace = 0;
                cc.fortitudeRace = 0;
                cc.finesseRace = 0;
                // bonus starting lux equal to the cost of a starting skill
            }

            if(cmbRace.Text == "Moogle")
            {
                cc.race = cmbRace.Text;
                cc.bodyRace = -3;
                cc.speedRace = 0;
                cc.magicRace = 10;
                cc.powerRace = 0;
                cc.fortitudeRace = -2;
                cc.finesseRace = 5;

                UpdateDisplay();
                CheckPointOverMax();
            }

            if(cmbRace.Text == "Yordle")
            {
                cc.race = cmbRace.Text;
                cc.bodyRace = -3;
                cc.speedRace = 5;
                cc.magicRace = 5;
                cc.powerRace = -2;
                cc.fortitudeRace = 0;
                cc.finesseRace = 5;

                UpdateDisplay();
                CheckPointOverMax();

            }

            UpdateDisplay();

        }

        private void UpdateDisplay()
        {
            // setting all text to default values

            bodTotal = cc.body + cc.bodyRace + cc.bodyBase;
            spdTotal = cc.speed + cc.speedRace + cc.speedBase;
            magTotal = cc.magic + cc.magicRace + cc.magicBase;
            lblBody.Text = bodTotal.ToString();
            lblSpeed.Text = spdTotal.ToString();
            lblMagic.Text = magTotal.ToString();

            powTotal = cc.power + cc.powerBase + cc.powerRace;
            finTotal = cc.finesse + cc.finesseBase + cc.finesseRace;
            frtTotal = cc.fortitude + cc.fortitudeBase + cc.fortitudeRace;
            lblPower.Text = powTotal.ToString();
            lblFinesse.Text = finTotal.ToString();
            lblFortitude.Text = frtTotal.ToString();

            primRemaining = 30 - (cc.body + cc.speed + cc.magic);
            secoRemaining = 20 - (cc.power + cc.finesse + cc.fortitude);

            lblPrimaryRemaining.Text = primRemaining.ToString();
            lblSecondaryRemaining.Text = secoRemaining.ToString();

            strength = bodTotal + powTotal;
            vitality = bodTotal + frtTotal;
            dexterity = bodTotal + finTotal;

            agility = spdTotal + powTotal;
            stamina = spdTotal + frtTotal;
            reflex = spdTotal + finTotal;

            spirit = magTotal + powTotal;
            aura = magTotal + frtTotal;
            sorcery = magTotal + finTotal;

            lblStrength.Text = strength.ToString();
            lblVitality.Text = vitality.ToString();
            lblDexterity.Text = dexterity.ToString();

            lblAgility.Text = agility.ToString();
            lblStamina.Text = stamina.ToString();
            lblReflex.Text = reflex.ToString();

            lblSpirit.Text = spirit.ToString();
            lblAura.Text = aura.ToString();
            lblSorcery.Text = sorcery.ToString();

            // End of setting text to default values
        }
        private void CheckPointOverMax()
        {
            int primCorrection;
            int secoCorrection;

            if (bodTotal > 30)
            {
                primCorrection = bodTotal - 30;
                cc.body = 30 - (cc.bodyRace + cc.bodyBase);
                primRemaining += primCorrection;
            }

            if (spdTotal > 30)
            {
                primCorrection = spdTotal - 30;
                cc.speed = 30 - (cc.speedRace + cc.speedBase);
                primRemaining += primCorrection;
            }

            if (magTotal > 30)
            {
                primCorrection = magTotal - 30;
                cc.magic = 30 - (cc.magicRace + cc.magicBase);
                primRemaining += primCorrection;
            }

            if (powTotal > 25)
            {
                secoCorrection = powTotal - 25;
                cc.power = 25 - (cc.powerRace + cc.powerBase);
                secoRemaining += secoCorrection;
            }

            if (frtTotal > 25)
            {
                secoCorrection = frtTotal - 25;
                cc.fortitude = 25 - (cc.fortitudeRace + cc.fortitudeBase);
                secoRemaining += secoCorrection;
            }

            if (finTotal > 25)
            {
                secoCorrection = finTotal - 25;
                cc.finesse = 25 - (cc.finesseRace + cc.finesseBase);
                secoRemaining += secoCorrection;
            }
        }
    }
}
