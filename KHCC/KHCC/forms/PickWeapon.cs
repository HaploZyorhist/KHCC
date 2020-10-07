using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KHCC.forms
{
    public partial class PickWeapon : Form
    {

        // sets variables for tracking story progress
        int storyTelling = 0;
        bool keepSword = false;
        bool keepArrow = false;
        bool keepWand = false;
        bool tossSword = false;
        bool tossArrow = false;
        bool tossWand = false;
        bool attack = false;
        bool shield = false;
        bool block = false;
        bool notStrong = false;
        bool notReliable = false;
        bool notFast = false;

        //imports cc variable from other forms
        public CharacterContainer cc { get; set; }

        public PickWeapon()
        {
            InitializeComponent();
        }


        private void PickWeapon_Load(object sender, EventArgs e)
        {
            // this hides the radials we dont want to see yet
            lblPlaque.Text = "";
            rbtnSword.Hide();
            rbtnArrow.Hide();
            rbtnWand.Hide();
            lblPlaque.Hide();
            btnYes.Hide();
            btnNo.Hide();
            lblStory.Text = "";
            TextUpdate();
        }
        private void btnContinue_Click(object sender, EventArgs e)
        {
            // TODO if max threshold, next becomes next form.
            if (storyTelling == 0)
            {
                if(txtCharacter.Text.Length == 0 || txtPlayer.Text.Length == 0)
                {
                    storyTelling = -1;
                }
            }
            if (storyTelling == 4)
            {
                if (rbtnSword.Checked)
                {
                    keepSword = true;
                    keepArrow = false;
                    keepWand = false;
                }
                if (rbtnArrow.Checked)
                {
                    keepArrow = true;
                    keepSword = false;
                    keepWand = false;
                }
                if (rbtnWand.Checked)
                {
                    keepWand = true;
                    keepSword = false;
                    keepArrow = false;
                }
            }
            if (storyTelling == 6)
            {
                if (rbtnSword.Checked)
                {
                    tossSword = true;
                    tossArrow = false;
                    tossWand = false;

                }
                if (rbtnArrow.Checked)
                {
                    tossArrow = true;
                    tossSword = false;
                    tossWand = false;
                }
                if (rbtnWand.Checked)
                {
                    tossWand = true;
                    tossSword = false;
                    tossArrow = false;

                }
            }
            if (storyTelling == 9)
            {
                if (rbtnSword.Checked)
                {
                    attack = true;
                    block = false;
                    shield = false;

                }
                if (rbtnArrow.Checked)
                {
                    shield = true;
                    attack = false;
                    block = false;
                }
                if (rbtnWand.Checked)
                {
                    block = true;
                    attack = false;
                    shield = false;
                }
            }
            if (storyTelling == 11)
            {
                if (rbtnSword.Checked)
                {
                    notStrong = true;
                    notFast = false;
                    notReliable = false;

                }
                if (rbtnArrow.Checked)
                {
                    notReliable = true;
                    notStrong = false;
                    notFast = false;
                }
                if (rbtnWand.Checked)
                {
                    notFast = true;
                    notStrong = false;
                    notReliable = false;
                }
            }

            storyTelling++;
            TextUpdate();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // this backs up the story, not allowing you to go before the start
            if (storyTelling > 0)
            {
                storyTelling--;
                TextUpdate();
            }
        }


        // this updates the dialogue for the story back and forth
        private void TextUpdate()
        {
            if (storyTelling == 0)
            {
                btnBack.Hide();
                btnContinue.Show();
                lblPlayer.Show();
                lblCharacter.Show();
                txtPlayer.Show();
                txtCharacter.Show();
                lblStory.Text = "Please enter the name of your character" +
                                "\n\rand your name";
            }
            if (storyTelling == 1)
            {
                lblCharacter.Hide();
                lblPlayer.Hide();
                txtCharacter.Hide();
                txtPlayer.Hide();
                btnBack.Show();
                lblStory.Text = "You find yourself somewhere between awake " +
                                "\n\rand asleep.  From the distance a voice calls " + 
                                "\n\rto you, \"Your world is in danger, you must " +
                                "\n\rstand to protect it.\"";

            }
            if (storyTelling == 2)
            {
                lblStory.Text = "As you stand up, you look around and find " +
                                "\n\ryourself standing on a circular pilliar." +
                                "\n\rOpposite you there are 3 pedestals, " +
                                "\n\reach with a weapon on top of them.";
            }
            if (storyTelling == 3)
            {
                btnContinue.Show();
                rbtnSword.Hide();
                rbtnArrow.Hide();
                rbtnWand.Hide();
                lblPlaque.Hide();
                btnNo.Hide();
                btnYes.Hide();
                btnBack.Show();
                rbtnSword.Checked = false;
                rbtnArrow.Checked = false;
                rbtnWand.Checked = false;

                lblStory.Text = "The voice returns, \"What weapon would you " +
                                "\n\rtake to save your world?\"  Each of the" +
                                "\n\rpedestals has a plaque with an inscription" +
                                "\n\ron it. The voice returns, \"Choose " +
                                "\n\rcarefully, you may very well save your " +
                                "\n\rworld, or you may doom it\"";


            }

            // make player choose weapon to keep
            // turns on radials and turns off next until a radial is picked
            if (storyTelling == 4)
            {
                rbtnSword.Checked = false;
                rbtnArrow.Checked = false;
                rbtnWand.Checked = false;
                lblStory.Text = "";
                lblStory.Hide();
                btnContinue.Hide();
                rbtnSword.Show();
                rbtnArrow.Show();
                rbtnWand.Show();
                lblPlaque.Show();
                lblPlaque.Text = "";
                btnNo.Hide();
                btnYes.Hide();
                btnBack.Show();

            }
            
            // dialogue before choosing weapon to lose.
            if (storyTelling == 5)
            {
                rbtnSword.Hide();
                rbtnArrow.Hide();
                rbtnWand.Hide();
                lblPlaque.Hide();
                lblPlaque.Text = "";
                lblStory.Show();
                btnContinue.Show();



                lblStory.Text =     "As you pick up your weapon, the voice returns, " +
                                    "\n\r\"With any gain there must be a sacrifice, " +
                                    "\n\rwhich would you sacrifice for this power?\"";
            }
            if (storyTelling == 6)
            {
                lblStory.Text = "";
                lblStory.Hide();
                btnContinue.Hide();
                lblPlaque.Show();
                lblPlaque.Text = "";

                if (keepSword)
                {
                    rbtnArrow.Show();
                    rbtnWand.Show();
                }
                if (keepArrow)
                {
                    rbtnSword.Show();
                    rbtnWand.Show();
                }
                if (keepWand)
                {
                    rbtnSword.Show();
                    rbtnArrow.Show();
                }

            }
            if (storyTelling == 7)
            {
                rbtnSword.Hide();
                rbtnArrow.Hide();
                rbtnWand.Hide();
                lblPlaque.Hide();
                lblPlaque.Text = "";
                lblStory.Show();
                btnContinue.Hide();
                btnBack.Hide();
                btnYes.Show();
                btnNo.Show();

                lblStory.Text =     "As you throw the weapon off the pilliar, the " +
                                    "\n\rvoice, calls again \"This is the path you " +
                                    "\n\rchoose?\"" +
                                    "\n\r\n\rYou have chosen to keep:";
                                        if (keepSword)
                                        {
                                            lblStory.Text = lblStory.Text + "\n\rThe sword and shield";

                                        }
                                        if (keepArrow)
                                        {
                                            lblStory.Text = lblStory.Text + "\n\rThe cloak and dagger";
                                        }
                                        if (keepWand)
                                        {
                                            lblStory.Text = lblStory.Text + "\n\rThe wand and bow";

                                        }

                lblStory.Text = lblStory.Text + "\n\rYou have chosen to sacrifice:";
                                        if (keepSword)
                                        {
                                            lblStory.Text = lblStory.Text + "\n\rThe sword and shield";

                                        }   
                                        if (keepArrow)
                                        {
                                            lblStory.Text = lblStory.Text + "\n\rThe cloak and dagger";
                                        }
                                        if (keepWand)
                                        {
                                            lblStory.Text = lblStory.Text + "\n\rThe wand and bow";

                                        }

                lblStory.Text = lblStory.Text + "\n\r\n\rIs this how you want to proceed?";
                    

            }
            if (storyTelling == 8)
            {
                btnBack.Hide();
                btnContinue.Show();
                btnYes.Hide();
                btnNo.Hide();
                lblPlaque.Hide();
                rbtnSword.Hide();
                rbtnArrow.Hide();
                rbtnWand.Hide();
                lblStory.Show();

                lblStory.Text = "You wake up in your bed, the world" +
                                "\n\raround you is familiar.  You head" +
                                "\n\routside.  There you find someone" +
                                "\n\ryou know, but you cant seem to " +
                                "\n\rremember their name. They turn to" +
                                "\n\ryou and ask, \"If I were being attacked" +
                                "\n\rwhat would you do to save me?\"";

            }
            if (storyTelling == 9)
            {
                rbtnSword.Checked = false;
                rbtnArrow.Checked = false;
                rbtnWand.Checked = false;
                btnBack.Show();
                btnContinue.Hide();
                rbtnSword.Show();
                rbtnArrow.Show();
                rbtnWand.Show();
                lblStory.Text = "";

                rbtnSword.Text = "Attack them first";
                rbtnArrow.Text = "Shield you from them";
                rbtnWand.Text = "Try to block their attack";
            }
            if (storyTelling == 10)
            {
                btnContinue.Show();
                rbtnSword.Hide();
                rbtnArrow.Hide();
                rbtnWand.Hide();
                lblStory.Text = "The world around you turns to sand " +
                                "\n\rand blows away revealing another" +
                                "\n\rplace you're familiar with and a" +
                                "\n\rperson you've never met.  This " +
                                "\n\rperson turns to you and asks, " +
                                "\n\r\"What is your greatest fear?";
            }
            if (storyTelling == 11)
            {
                rbtnSword.Checked = false;
                rbtnArrow.Checked = false;
                rbtnWand.Checked = false;
                btnBack.Show();
                btnContinue.Hide();
                rbtnSword.Show();
                rbtnArrow.Show();
                rbtnWand.Show();
                lblStory.Text = "";

                rbtnSword.Text = "I'm not strong enough";
                rbtnArrow.Text = "I'm counted on too much";
                rbtnWand.Text = "I cant keep up";
            }
            if (storyTelling == 12)
            {
                rbtnSword.Hide();
                rbtnArrow.Hide();
                rbtnWand.Hide();
                lblStory.Show();
                btnContinue.Hide();
                btnBack.Hide();
                btnYes.Show();
                btnNo.Show();

                lblStory.Text =     "The voice begins to fade, \"This is how you " +
                                    "\n\rwould live your life?\"" +
                                    "\n\r\"If a friend was attacked, you would:\"" ;
                if (keepSword)
                {
                    lblStory.Text = lblStory.Text + "\n\rAttack them first";

                }
                if (keepArrow)
                {
                    lblStory.Text = lblStory.Text + "\n\rShield you from them";
                }
                if (keepWand)
                {
                    lblStory.Text = lblStory.Text + "\n\rTry to block their attack";

                }


                lblStory.Text = lblStory.Text + "\n\r\"You fear that :\"";
                if (keepSword)
                {
                    lblStory.Text = lblStory.Text + "\n\rYou're not strong enough";

                }
                if (keepArrow)
                {
                    lblStory.Text = lblStory.Text + "\n\rYou're counted on too much";
                }
                if (keepWand)
                {
                    lblStory.Text = lblStory.Text + "\n\rYou cant keep up";

                }

                lblStory.Text = lblStory.Text + "\n\r\n\rIs this your true self?";

            }

        }


        // --------------------------------------------Radials------------------------------------------------------------
        private void rbtnSword_CheckedChanged(object sender, EventArgs e)
        {
            if (storyTelling == 4)
            {
                lblPlaque.Text = "The plaque before you reads" +
                                    "\n\r\"The sword and shield," +
                                    "\n\rprotectors of the world, " +
                                    "\n\ror warriors of destruction\"";
                btnContinue.Show();
            }
            if (storyTelling == 6)
            {
                lblPlaque.Text = "The plaque before you reads" +
                                    "\n\r\"The sword and shield, " +
                                    "\n\rthe power to protect your allies," +
                                    "\n\rand obliterate your enemies\"";

                btnContinue.Show();
            }
            if (storyTelling == 9)
            {
                btnContinue.Show();
            }
            if (storyTelling == 11)
            {
                btnContinue.Show();
            }
        }

        private void rbtnArrow_CheckedChanged(object sender, EventArgs e)
        {
            if (storyTelling == 4)
            {
                lblPlaque.Text =    "The plaque before you reads" +
                                    "\n\r\"The cloak and dagger, " +
                                    "\n\rdarkness may be your foe," +
                                    "\n\rit may also be your friend\"";
                btnContinue.Show();
            }
            if (storyTelling == 6)
            {
                lblPlaque.Text =    "The plaque before you reads" +
                                    "\n\r\"The cloak and dagger," +
                                    "\n\rthe power to eliminate anything" +
                                    "\n\rthat threatens what you hold dear\"";

                btnContinue.Show();
            }
            if (storyTelling == 9)
            {
                btnContinue.Show();
            }
            if (storyTelling == 11)
            {
                btnContinue.Show();
            }

        }

        private void rbtnWand_CheckedChanged(object sender, EventArgs e)
        {
            if (storyTelling == 4)
            {
                lblPlaque.Text =    "The plaque before you reads" +
                                    "\n\r\"The wand and bow, " +
                                    "\n\rtacticians who seek to " +
                                    "\n\rbend the flow of battle\"";
                btnContinue.Show();
            }
            if (storyTelling == 6)
            {
                lblPlaque.Text =    "The plaque before you reads" +
                                    "\n\r\"The wand and bow, " +
                                    "\n\rthe power to support " +
                                    "\n\rthose in need";

                btnContinue.Show();
            }
            if (storyTelling == 9)
            {
                btnContinue.Show();
            }
            if (storyTelling == 11)
            {
                btnContinue.Show();
            }

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (storyTelling == 7)
            {
                storyTelling = 8;
                TextUpdate();
            }
            if (storyTelling == 12)
            {
                this.Hide();

                if (keepSword && tossArrow)
                {
                    cc.bodyBase += 5;
                    cc.speedBase -= 5;

                }
                if (keepSword && tossWand)
                {
                    cc.bodyBase += 5;
                    cc.magicBase -= 5;

                }
                if (keepArrow && tossSword)
                {
                    cc.speedBase += 5;
                    cc.bodyBase -= 5;

                }
                if (keepArrow && tossWand)
                {
                    cc.speedBase += 5;
                    cc.magicBase -= 5;
                }
                if (keepWand && tossSword)
                {
                    cc.magicBase += 5;
                    cc.bodyBase -= 5;

                }
                if (keepWand && tossArrow)
                {
                    cc.magicBase += 5;
                    cc.speedBase -= 5;
                }
                if (attack)
                {
                    cc.powerBase += 5;
                }
                if (shield)
                {
                    cc.fortitudeBase += 5;
                }
                if (block)
                {
                    cc.finesseBase += 5;
                }
                if (notStrong)
                {
                    cc.powerBase -= 5;
                }
                if (notReliable)
                {
                    cc.fortitudeBase -= 5;
                }
                if (notFast)
                {
                    cc.finesseBase -= 5;
                }


                var cb = new CharacterBuilder();
                cb.cc = cc;
                cb.ShowDialog();

            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            if (storyTelling == 7)
            {
                storyTelling = 3;
                TextUpdate();
            }
            if (storyTelling == 12)
            {
                storyTelling = 8;
                TextUpdate();
            }
        }

        private void txtPlayer_TextChanged(object sender, EventArgs e)
        {
            cc.playerName = txtPlayer.Text;
        }

        private void txtCharacter_TextChanged(object sender, EventArgs e)
        {
            cc.characterName = txtCharacter.Text;

        }
    }
}
