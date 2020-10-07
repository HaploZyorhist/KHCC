namespace KHCC
{
    partial class StartUp
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
            this.btnNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnNewCharacter = new System.Windows.Forms.RadioButton();
            this.rbtnLoadCharacter = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(522, 574);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 50);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 132);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to the Kingdom Hearts\r\nCharacter Creator, will you be making\r\na new chara" +
    "cter or will you be loading \r\none in?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbtnNewCharacter
            // 
            this.rbtnNewCharacter.AutoSize = true;
            this.rbtnNewCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNewCharacter.Location = new System.Drawing.Point(218, 191);
            this.rbtnNewCharacter.Name = "rbtnNewCharacter";
            this.rbtnNewCharacter.Size = new System.Drawing.Size(172, 29);
            this.rbtnNewCharacter.TabIndex = 2;
            this.rbtnNewCharacter.TabStop = true;
            this.rbtnNewCharacter.Text = "New Character";
            this.rbtnNewCharacter.UseVisualStyleBackColor = true;
            // 
            // rbtnLoadCharacter
            // 
            this.rbtnLoadCharacter.AutoSize = true;
            this.rbtnLoadCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnLoadCharacter.Location = new System.Drawing.Point(218, 226);
            this.rbtnLoadCharacter.Name = "rbtnLoadCharacter";
            this.rbtnLoadCharacter.Size = new System.Drawing.Size(178, 29);
            this.rbtnLoadCharacter.TabIndex = 3;
            this.rbtnLoadCharacter.TabStop = true;
            this.rbtnLoadCharacter.Text = "Load Character";
            this.rbtnLoadCharacter.UseVisualStyleBackColor = true;
            // 
            // StartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 636);
            this.Controls.Add(this.rbtnLoadCharacter);
            this.Controls.Add(this.rbtnNewCharacter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNext);
            this.Name = "StartUp";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnNewCharacter;
        private System.Windows.Forms.RadioButton rbtnLoadCharacter;
    }
}