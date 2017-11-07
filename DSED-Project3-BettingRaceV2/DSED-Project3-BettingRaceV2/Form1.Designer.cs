namespace DSED_Project3_BettingRaceV2
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.rbJoe = new System.Windows.Forms.RadioButton();
            this.rbBob = new System.Windows.Forms.RadioButton();
            this.rbAl = new System.Windows.Forms.RadioButton();
            this.lblName = new System.Windows.Forms.Label();
            this.btnBet = new System.Windows.Forms.Button();
            this.updownBetValue = new System.Windows.Forms.NumericUpDown();
            this.updownSnail = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMinBet = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblJoeBetLabel = new System.Windows.Forms.Label();
            this.lblBobBetLabel = new System.Windows.Forms.Label();
            this.lblAlBetLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pboxRaceTrack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.updownBetValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownSnail)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxRaceTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(1140, 290);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(162, 66);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // rbJoe
            // 
            this.rbJoe.AutoSize = true;
            this.rbJoe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJoe.Location = new System.Drawing.Point(103, 56);
            this.rbJoe.Name = "rbJoe";
            this.rbJoe.Size = new System.Drawing.Size(53, 32);
            this.rbJoe.TabIndex = 2;
            this.rbJoe.TabStop = true;
            this.rbJoe.Text = "Jo";
            this.rbJoe.UseVisualStyleBackColor = true;
            this.rbJoe.CheckedChanged += new System.EventHandler(this.rbJoe_CheckedChanged);
            // 
            // rbBob
            // 
            this.rbBob.AutoSize = true;
            this.rbBob.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBob.Location = new System.Drawing.Point(103, 145);
            this.rbBob.Name = "rbBob";
            this.rbBob.Size = new System.Drawing.Size(69, 32);
            this.rbBob.TabIndex = 3;
            this.rbBob.TabStop = true;
            this.rbBob.Text = "Bob";
            this.rbBob.UseVisualStyleBackColor = true;
            this.rbBob.CheckedChanged += new System.EventHandler(this.rbBob_CheckedChanged);
            // 
            // rbAl
            // 
            this.rbAl.AutoSize = true;
            this.rbAl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAl.Location = new System.Drawing.Point(103, 235);
            this.rbAl.Name = "rbAl";
            this.rbAl.Size = new System.Drawing.Size(51, 32);
            this.rbAl.TabIndex = 4;
            this.rbAl.TabStop = true;
            this.rbAl.Text = "Al";
            this.rbAl.UseVisualStyleBackColor = true;
            this.rbAl.CheckedChanged += new System.EventHandler(this.rbAl_CheckedChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Emoji", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(27, 306);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(91, 37);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "label1";
            // 
            // btnBet
            // 
            this.btnBet.Location = new System.Drawing.Point(222, 297);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(104, 41);
            this.btnBet.TabIndex = 6;
            this.btnBet.Text = "Bet";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // updownBetValue
            // 
            this.updownBetValue.Location = new System.Drawing.Point(430, 315);
            this.updownBetValue.Name = "updownBetValue";
            this.updownBetValue.Size = new System.Drawing.Size(120, 22);
            this.updownBetValue.TabIndex = 7;
            // 
            // updownSnail
            // 
            this.updownSnail.Location = new System.Drawing.Point(905, 313);
            this.updownSnail.Name = "updownSnail";
            this.updownSnail.Size = new System.Drawing.Size(51, 22);
            this.updownSnail.TabIndex = 8;
            this.updownSnail.Tag = "";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(635, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "For Snail Number ...";
            // 
            // lblMinBet
            // 
            this.lblMinBet.Location = new System.Drawing.Point(254, 145);
            this.lblMinBet.Name = "lblMinBet";
            this.lblMinBet.Size = new System.Drawing.Size(150, 23);
            this.lblMinBet.TabIndex = 10;
            this.lblMinBet.Text = "Minimum Bet Label";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(562, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Betting";
            // 
            // lblJoeBetLabel
            // 
            this.lblJoeBetLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoeBetLabel.Location = new System.Drawing.Point(504, 76);
            this.lblJoeBetLabel.Name = "lblJoeBetLabel";
            this.lblJoeBetLabel.Size = new System.Drawing.Size(190, 46);
            this.lblJoeBetLabel.TabIndex = 12;
            this.lblJoeBetLabel.Text = "Joe Bet Label";
            // 
            // lblBobBetLabel
            // 
            this.lblBobBetLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBobBetLabel.Location = new System.Drawing.Point(504, 133);
            this.lblBobBetLabel.Name = "lblBobBetLabel";
            this.lblBobBetLabel.Size = new System.Drawing.Size(195, 34);
            this.lblBobBetLabel.TabIndex = 13;
            this.lblBobBetLabel.Text = "Bob Bet Label";
            // 
            // lblAlBetLabel
            // 
            this.lblAlBetLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlBetLabel.Location = new System.Drawing.Point(507, 207);
            this.lblAlBetLabel.Name = "lblAlBetLabel";
            this.lblAlBetLabel.Size = new System.Drawing.Size(151, 36);
            this.lblAlBetLabel.TabIndex = 14;
            this.lblAlBetLabel.Text = "Al Bet Label";
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pictureBox7);
            this.groupBox1.Controls.Add(this.pictureBox6);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.lblMinBet);
            this.groupBox1.Controls.Add(this.rbJoe);
            this.groupBox1.Controls.Add(this.rbBob);
            this.groupBox1.Controls.Add(this.rbAl);
            this.groupBox1.Controls.Add(this.lblJoeBetLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblAlBetLabel);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.updownSnail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblBobBetLabel);
            this.groupBox1.Controls.Add(this.btnBet);
            this.groupBox1.Controls.Add(this.updownBetValue);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.groupBox1.Location = new System.Drawing.Point(36, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1329, 382);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::DSED_Project3_BettingRaceV2.Properties.Resources.wink__1_;
            this.pictureBox7.Location = new System.Drawing.Point(19, 207);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(64, 64);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 17;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::DSED_Project3_BettingRaceV2.Properties.Resources.nerd;
            this.pictureBox6.Location = new System.Drawing.Point(19, 121);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(64, 64);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 16;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DSED_Project3_BettingRaceV2.Properties.Resources.smug__1__Transp;
            this.pictureBox5.Location = new System.Drawing.Point(18, 34);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(64, 64);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.Image = global::DSED_Project3_BettingRaceV2.Properties.Resources.snail__2_;
            this.pictureBox4.Location = new System.Drawing.Point(36, 571);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(83, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = global::DSED_Project3_BettingRaceV2.Properties.Resources.snail__2_;
            this.pictureBox3.Location = new System.Drawing.Point(36, 537);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(83, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::DSED_Project3_BettingRaceV2.Properties.Resources.snail__2_;
            this.pictureBox2.Location = new System.Drawing.Point(36, 503);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::DSED_Project3_BettingRaceV2.Properties.Resources.snail__2_;
            this.pictureBox1.Location = new System.Drawing.Point(36, 461);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pboxRaceTrack
            // 
            this.pboxRaceTrack.Image = global::DSED_Project3_BettingRaceV2.Properties.Resources.vectorstock_497407;
            this.pboxRaceTrack.Location = new System.Drawing.Point(3, 23);
            this.pboxRaceTrack.Name = "pboxRaceTrack";
            this.pboxRaceTrack.Size = new System.Drawing.Size(1387, 576);
            this.pboxRaceTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxRaceTrack.TabIndex = 0;
            this.pboxRaceTrack.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 611);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pboxRaceTrack);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.updownBetValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownSnail)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxRaceTrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxRaceTrack;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RadioButton rbJoe;
        private System.Windows.Forms.RadioButton rbBob;
        private System.Windows.Forms.RadioButton rbAl;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.NumericUpDown updownBetValue;
        private System.Windows.Forms.NumericUpDown updownSnail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMinBet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblJoeBetLabel;
        private System.Windows.Forms.Label lblBobBetLabel;
        private System.Windows.Forms.Label lblAlBetLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

