using System.Windows.Forms;

namespace DSED_Project3_Races
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.rbJane = new System.Windows.Forms.RadioButton();
            this.rbJohn = new System.Windows.Forms.RadioButton();
            this.rbJim = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txbJohnBet = new System.Windows.Forms.TextBox();
            this.txbJimBet = new System.Windows.Forms.TextBox();
            this.txbJaneBet = new System.Windows.Forms.TextBox();
            this.updownBetAmount = new System.Windows.Forms.NumericUpDown();
            this.btnBet = new System.Windows.Forms.Button();
            this.StartTheRace = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pboxSnail1 = new System.Windows.Forms.PictureBox();
            this.pboxSnail2 = new System.Windows.Forms.PictureBox();
            this.pboxSnail4 = new System.Windows.Forms.PictureBox();
            this.pboxSnail3 = new System.Windows.Forms.PictureBox();
            this.raceTrack = new System.Windows.Forms.PictureBox();
            this.lblname = new System.Windows.Forms.Label();
            this.updownSnailNumber = new System.Windows.Forms.NumericUpDown();
            this.updSnailNumber = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownBetAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartTheRace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSnail1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSnail2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSnail4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSnail3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownSnailNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Location = new System.Drawing.Point(41, 153);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 258);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::DSED_Project3_Races.Properties.Resources.smug__1__Transp1;
            this.pictureBox6.Location = new System.Drawing.Point(17, 4);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(64, 64);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::DSED_Project3_Races.Properties.Resources.nerd;
            this.pictureBox7.Location = new System.Drawing.Point(17, 176);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(64, 64);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::DSED_Project3_Races.Properties.Resources.smug;
            this.pictureBox8.Location = new System.Drawing.Point(17, 90);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(64, 64);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            // 
            // rbJane
            // 
            this.rbJane.AutoSize = true;
            this.rbJane.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJane.Location = new System.Drawing.Point(169, 172);
            this.rbJane.Margin = new System.Windows.Forms.Padding(4);
            this.rbJane.Name = "rbJane";
            this.rbJane.Size = new System.Drawing.Size(86, 36);
            this.rbJane.TabIndex = 10;
            this.rbJane.TabStop = true;
            this.rbJane.Text = "Jane";
            this.rbJane.UseVisualStyleBackColor = true;
            this.rbJane.CheckedChanged += new System.EventHandler(this.rbJane_CheckedChanged);
            // 
            // rbJohn
            // 
            this.rbJohn.AutoSize = true;
            this.rbJohn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJohn.Location = new System.Drawing.Point(169, 262);
            this.rbJohn.Margin = new System.Windows.Forms.Padding(4);
            this.rbJohn.Name = "rbJohn";
            this.rbJohn.Size = new System.Drawing.Size(88, 36);
            this.rbJohn.TabIndex = 11;
            this.rbJohn.TabStop = true;
            this.rbJohn.Text = "John";
            this.rbJohn.UseVisualStyleBackColor = true;
            this.rbJohn.CheckedChanged += new System.EventHandler(this.rbJohn_CheckedChanged);
            // 
            // rbJim
            // 
            this.rbJim.AutoSize = true;
            this.rbJim.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJim.Location = new System.Drawing.Point(169, 347);
            this.rbJim.Margin = new System.Windows.Forms.Padding(4);
            this.rbJim.Name = "rbJim";
            this.rbJim.Size = new System.Drawing.Size(73, 36);
            this.rbJim.TabIndex = 12;
            this.rbJim.TabStop = true;
            this.rbJim.Text = "Jim";
            this.rbJim.UseVisualStyleBackColor = true;
            this.rbJim.CheckedChanged += new System.EventHandler(this.rbJim_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1297, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 41);
            this.label1.TabIndex = 14;
            this.label1.Text = "Bets";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1136, 180);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(393, 39);
            this.textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(1136, 355);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(393, 39);
            this.textBox2.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(1136, 270);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(393, 39);
            this.textBox3.TabIndex = 17;
            // 
            // txbJohnBet
            // 
            this.txbJohnBet.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbJohnBet.Location = new System.Drawing.Point(360, 261);
            this.txbJohnBet.Margin = new System.Windows.Forms.Padding(4);
            this.txbJohnBet.Name = "txbJohnBet";
            this.txbJohnBet.Size = new System.Drawing.Size(132, 39);
            this.txbJohnBet.TabIndex = 21;
            // 
            // txbJimBet
            // 
            this.txbJimBet.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbJimBet.Location = new System.Drawing.Point(360, 347);
            this.txbJimBet.Margin = new System.Windows.Forms.Padding(4);
            this.txbJimBet.Name = "txbJimBet";
            this.txbJimBet.Size = new System.Drawing.Size(132, 39);
            this.txbJimBet.TabIndex = 22;
            // 
            // txbJaneBet
            // 
            this.txbJaneBet.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbJaneBet.Location = new System.Drawing.Point(360, 171);
            this.txbJaneBet.Margin = new System.Windows.Forms.Padding(4);
            this.txbJaneBet.Name = "txbJaneBet";
            this.txbJaneBet.Size = new System.Drawing.Size(132, 39);
            this.txbJaneBet.TabIndex = 23;
            // 
            // updownBetAmount
            // 
            this.updownBetAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updownBetAmount.Location = new System.Drawing.Point(728, 270);
            this.updownBetAmount.Name = "updownBetAmount";
            this.updownBetAmount.Size = new System.Drawing.Size(120, 34);
            this.updownBetAmount.TabIndex = 24;
            // 
            // btnBet
            // 
            this.btnBet.ForeColor = System.Drawing.Color.Transparent;
            this.btnBet.Image = global::DSED_Project3_Races.Properties.Resources.race_horse_Bet;
            this.btnBet.Location = new System.Drawing.Point(700, 434);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(207, 101);
            this.btnBet.TabIndex = 27;
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // StartTheRace
            // 
            this.StartTheRace.Image = global::DSED_Project3_Races.Properties.Resources.Amazing_Race_Logo;
            this.StartTheRace.Location = new System.Drawing.Point(653, 542);
            this.StartTheRace.Margin = new System.Windows.Forms.Padding(4);
            this.StartTheRace.Name = "StartTheRace";
            this.StartTheRace.Size = new System.Drawing.Size(327, 85);
            this.StartTheRace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StartTheRace.TabIndex = 18;
            this.StartTheRace.TabStop = false;
            this.StartTheRace.Click += new System.EventHandler(this.StartTheRace_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::DSED_Project3_Races.Properties.Resources.NZRB_Logo;
            this.pictureBox9.Location = new System.Drawing.Point(668, 32);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(284, 96);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 13;
            this.pictureBox9.TabStop = false;
            // 
            // pboxSnail1
            // 
            this.pboxSnail1.Image = global::DSED_Project3_Races.Properties.Resources.snail__2_;
            this.pboxSnail1.Location = new System.Drawing.Point(17, 667);
            this.pboxSnail1.Margin = new System.Windows.Forms.Padding(4);
            this.pboxSnail1.Name = "pboxSnail1";
            this.pboxSnail1.Size = new System.Drawing.Size(84, 42);
            this.pboxSnail1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxSnail1.TabIndex = 5;
            this.pboxSnail1.TabStop = false;
            // 
            // pboxSnail2
            // 
            this.pboxSnail2.Image = global::DSED_Project3_Races.Properties.Resources.snail__2_;
            this.pboxSnail2.Location = new System.Drawing.Point(17, 716);
            this.pboxSnail2.Margin = new System.Windows.Forms.Padding(4);
            this.pboxSnail2.Name = "pboxSnail2";
            this.pboxSnail2.Size = new System.Drawing.Size(84, 42);
            this.pboxSnail2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxSnail2.TabIndex = 4;
            this.pboxSnail2.TabStop = false;
            // 
            // pboxSnail4
            // 
            this.pboxSnail4.Image = global::DSED_Project3_Races.Properties.Resources.snail__2_;
            this.pboxSnail4.Location = new System.Drawing.Point(17, 826);
            this.pboxSnail4.Margin = new System.Windows.Forms.Padding(4);
            this.pboxSnail4.Name = "pboxSnail4";
            this.pboxSnail4.Size = new System.Drawing.Size(84, 42);
            this.pboxSnail4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxSnail4.TabIndex = 3;
            this.pboxSnail4.TabStop = false;
            // 
            // pboxSnail3
            // 
            this.pboxSnail3.Image = global::DSED_Project3_Races.Properties.Resources.snail__2_;
            this.pboxSnail3.Location = new System.Drawing.Point(17, 766);
            this.pboxSnail3.Margin = new System.Windows.Forms.Padding(4);
            this.pboxSnail3.Name = "pboxSnail3";
            this.pboxSnail3.Size = new System.Drawing.Size(84, 42);
            this.pboxSnail3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxSnail3.TabIndex = 2;
            this.pboxSnail3.TabStop = false;
            // 
            // raceTrack
            // 
            this.raceTrack.Image = global::DSED_Project3_Races.Properties.Resources.vectorstock_497407;
            this.raceTrack.Location = new System.Drawing.Point(17, 16);
            this.raceTrack.Margin = new System.Windows.Forms.Padding(4);
            this.raceTrack.Name = "raceTrack";
            this.raceTrack.Size = new System.Drawing.Size(1631, 852);
            this.raceTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.raceTrack.TabIndex = 0;
            this.raceTrack.TabStop = false;
            // 
            // lblname
            // 
            this.lblname.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(723, 166);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(137, 55);
            this.lblname.TabIndex = 28;
            this.lblname.Text = "label2";
            this.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updownSnailNumber
            // 
            this.updownSnailNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updownSnailNumber.Location = new System.Drawing.Point(728, 377);
            this.updownSnailNumber.Name = "updownSnailNumber";
            this.updownSnailNumber.Size = new System.Drawing.Size(120, 34);
            this.updownSnailNumber.TabIndex = 29;
            // 
            // updSnailNumber
            // 
            this.updSnailNumber.AutoSize = true;
            this.updSnailNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updSnailNumber.Location = new System.Drawing.Point(761, 329);
            this.updSnailNumber.Name = "updSnailNumber";
            this.updSnailNumber.Size = new System.Drawing.Size(55, 28);
            this.updSnailNumber.TabIndex = 30;
            this.updSnailNumber.Text = "Snail";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1664, 871);
            this.Controls.Add(this.updSnailNumber);
            this.Controls.Add(this.updownSnailNumber);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.btnBet);
            this.Controls.Add(this.updownBetAmount);
            this.Controls.Add(this.txbJaneBet);
            this.Controls.Add(this.txbJimBet);
            this.Controls.Add(this.txbJohnBet);
            this.Controls.Add(this.StartTheRace);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.rbJim);
            this.Controls.Add(this.rbJohn);
            this.Controls.Add(this.rbJane);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pboxSnail1);
            this.Controls.Add(this.pboxSnail2);
            this.Controls.Add(this.pboxSnail4);
            this.Controls.Add(this.pboxSnail3);
            this.Controls.Add(this.raceTrack);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownBetAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartTheRace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSnail1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSnail2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSnail4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSnail3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownSnailNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox raceTrack;
        private System.Windows.Forms.PictureBox pboxSnail3;
        private System.Windows.Forms.PictureBox pboxSnail4;
        private System.Windows.Forms.PictureBox pboxSnail2;
        private System.Windows.Forms.PictureBox pboxSnail1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbJane;
        private System.Windows.Forms.RadioButton rbJohn;
        private System.Windows.Forms.RadioButton rbJim;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox StartTheRace;
        private System.Windows.Forms.TextBox txbJaneBet;
        private System.Windows.Forms.NumericUpDown updownBetAmount;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.NumericUpDown updownSnailNumber;
        private System.Windows.Forms.Label updSnailNumber;
        private TextBox txbJohnBet;
        private TextBox txbJimBet;
    }
}

