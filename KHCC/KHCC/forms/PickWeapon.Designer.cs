namespace KHCC.forms
{
    partial class PickWeapon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStory = new System.Windows.Forms.Label();
            this.rbtnSword = new System.Windows.Forms.RadioButton();
            this.rbtnArrow = new System.Windows.Forms.RadioButton();
            this.rbtnWand = new System.Windows.Forms.RadioButton();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblPlaque = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblCharacter = new System.Windows.Forms.Label();
            this.txtPlayer = new System.Windows.Forms.TextBox();
            this.txtCharacter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblStory
            // 
            this.lblStory.AutoSize = true;
            this.lblStory.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStory.Location = new System.Drawing.Point(12, 9);
            this.lblStory.Name = "lblStory";
            this.lblStory.Size = new System.Drawing.Size(609, 132);
            this.lblStory.TabIndex = 0;
            this.lblStory.Text = "You find yourself somewhere between awake \r\nand asleep.  From the distance a voic" +
    "e calls\r\nto you, \"Your world is in danger, you must \r\nstand to protect it.\"";
            this.lblStory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbtnSword
            // 
            this.rbtnSword.AutoSize = true;
            this.rbtnSword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSword.Location = new System.Drawing.Point(188, 72);
            this.rbtnSword.Name = "rbtnSword";
            this.rbtnSword.Size = new System.Drawing.Size(243, 35);
            this.rbtnSword.TabIndex = 1;
            this.rbtnSword.TabStop = true;
            this.rbtnSword.Text = "Sword and Shield";
            this.rbtnSword.UseVisualStyleBackColor = true;
            this.rbtnSword.CheckedChanged += new System.EventHandler(this.rbtnSword_CheckedChanged);
            // 
            // rbtnArrow
            // 
            this.rbtnArrow.AutoSize = true;
            this.rbtnArrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnArrow.Location = new System.Drawing.Point(188, 132);
            this.rbtnArrow.Name = "rbtnArrow";
            this.rbtnArrow.Size = new System.Drawing.Size(250, 35);
            this.rbtnArrow.TabIndex = 2;
            this.rbtnArrow.TabStop = true;
            this.rbtnArrow.Text = "Cloak and Dagger";
            this.rbtnArrow.UseVisualStyleBackColor = true;
            this.rbtnArrow.CheckedChanged += new System.EventHandler(this.rbtnArrow_CheckedChanged);
            // 
            // rbtnWand
            // 
            this.rbtnWand.AutoSize = true;
            this.rbtnWand.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnWand.Location = new System.Drawing.Point(188, 192);
            this.rbtnWand.Name = "rbtnWand";
            this.rbtnWand.Size = new System.Drawing.Size(214, 35);
            this.rbtnWand.TabIndex = 3;
            this.rbtnWand.TabStop = true;
            this.rbtnWand.Text = "Wand and Bow";
            this.rbtnWand.UseVisualStyleBackColor = true;
            this.rbtnWand.CheckedChanged += new System.EventHandler(this.rbtnWand_CheckedChanged);
            // 
            // btnContinue
            // 
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(522, 574);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(100, 50);
            this.btnContinue.TabIndex = 4;
            this.btnContinue.Text = "Next";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 574);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 50);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblPlaque
            // 
            this.lblPlaque.AutoSize = true;
            this.lblPlaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaque.Location = new System.Drawing.Point(126, 306);
            this.lblPlaque.Name = "lblPlaque";
            this.lblPlaque.Size = new System.Drawing.Size(98, 31);
            this.lblPlaque.TabIndex = 6;
            this.lblPlaque.Text = "Plaque";
            this.lblPlaque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnYes
            // 
            this.btnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.Location = new System.Drawing.Point(244, 417);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(100, 50);
            this.btnYes.TabIndex = 7;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.Location = new System.Drawing.Point(244, 487);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(100, 50);
            this.btnNo.TabIndex = 8;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(91, 143);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(62, 24);
            this.lblPlayer.TabIndex = 9;
            this.lblPlayer.Text = "Player";
            // 
            // lblCharacter
            // 
            this.lblCharacter.AutoSize = true;
            this.lblCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacter.Location = new System.Drawing.Point(91, 180);
            this.lblCharacter.Name = "lblCharacter";
            this.lblCharacter.Size = new System.Drawing.Size(91, 24);
            this.lblCharacter.TabIndex = 10;
            this.lblCharacter.Text = "Character";
            // 
            // txtPlayer
            // 
            this.txtPlayer.Location = new System.Drawing.Point(188, 148);
            this.txtPlayer.Name = "txtPlayer";
            this.txtPlayer.Size = new System.Drawing.Size(296, 20);
            this.txtPlayer.TabIndex = 11;
            this.txtPlayer.TextChanged += new System.EventHandler(this.txtPlayer_TextChanged);
            // 
            // txtCharacter
            // 
            this.txtCharacter.Location = new System.Drawing.Point(188, 185);
            this.txtCharacter.Name = "txtCharacter";
            this.txtCharacter.Size = new System.Drawing.Size(296, 20);
            this.txtCharacter.TabIndex = 12;
            this.txtCharacter.TextChanged += new System.EventHandler(this.txtCharacter_TextChanged);
            // 
            // PickWeapon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 636);
            this.Controls.Add(this.txtCharacter);
            this.Controls.Add(this.txtPlayer);
            this.Controls.Add(this.lblCharacter);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblPlaque);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.rbtnWand);
            this.Controls.Add(this.rbtnArrow);
            this.Controls.Add(this.rbtnSword);
            this.Controls.Add(this.lblStory);
            this.Name = "PickWeapon";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PickWeapon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStory;
        private System.Windows.Forms.RadioButton rbtnSword;
        private System.Windows.Forms.RadioButton rbtnArrow;
        private System.Windows.Forms.RadioButton rbtnWand;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblPlaque;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblCharacter;
        private System.Windows.Forms.TextBox txtPlayer;
        private System.Windows.Forms.TextBox txtCharacter;
    }
}