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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pboxRaceTrack = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.updownBetValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownSnail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxRaceTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(1020, 295);
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
            this.rbJoe.Location = new System.Drawing.Point(73, 291);
            this.rbJoe.Name = "rbJoe";
            this.rbJoe.Size = new System.Drawing.Size(110, 21);
            this.rbJoe.TabIndex = 2;
            this.rbJoe.TabStop = true;
            this.rbJoe.Text = "radioButton1";
            this.rbJoe.UseVisualStyleBackColor = true;
            this.rbJoe.CheckedChanged += new System.EventHandler(this.rbJoe_CheckedChanged);
            // 
            // rbBob
            // 
            this.rbBob.AutoSize = true;
            this.rbBob.Location = new System.Drawing.Point(73, 318);
            this.rbBob.Name = "rbBob";
            this.rbBob.Size = new System.Drawing.Size(110, 21);
            this.rbBob.TabIndex = 3;
            this.rbBob.TabStop = true;
            this.rbBob.Text = "radioButton2";
            this.rbBob.UseVisualStyleBackColor = true;
            this.rbBob.CheckedChanged += new System.EventHandler(this.rbBob_CheckedChanged);
            // 
            // rbAl
            // 
            this.rbAl.AutoSize = true;
            this.rbAl.Location = new System.Drawing.Point(73, 345);
            this.rbAl.Name = "rbAl";
            this.rbAl.Size = new System.Drawing.Size(110, 21);
            this.rbAl.TabIndex = 4;
            this.rbAl.TabStop = true;
            this.rbAl.Text = "radioButton3";
            this.rbAl.UseVisualStyleBackColor = true;
            this.rbAl.CheckedChanged += new System.EventHandler(this.rbAl_CheckedChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(73, 405);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 17);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "label1";
            // 
            // btnBet
            // 
            this.btnBet.Location = new System.Drawing.Point(291, 393);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(104, 41);
            this.btnBet.TabIndex = 6;
            this.btnBet.Text = "Bet";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // updownBetValue
            // 
            this.updownBetValue.Location = new System.Drawing.Point(481, 399);
            this.updownBetValue.Name = "updownBetValue";
            this.updownBetValue.Size = new System.Drawing.Size(120, 22);
            this.updownBetValue.TabIndex = 7;
            // 
            // updownSnail
            // 
            this.updownSnail.Location = new System.Drawing.Point(808, 399);
            this.updownSnail.Name = "updownSnail";
            this.updownSnail.Size = new System.Drawing.Size(51, 22);
            this.updownSnail.TabIndex = 8;
            this.updownSnail.Tag = "";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(635, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "For Snail Number ...";
            // 
            // lblMinBet
            // 
            this.lblMinBet.Location = new System.Drawing.Point(73, 222);
            this.lblMinBet.Name = "lblMinBet";
            this.lblMinBet.Size = new System.Drawing.Size(150, 23);
            this.lblMinBet.TabIndex = 10;
            this.lblMinBet.Text = "Minimum Bet Label";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(288, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Betting";
            // 
            // lblJoeBetLabel
            // 
            this.lblJoeBetLabel.Location = new System.Drawing.Point(288, 289);
            this.lblJoeBetLabel.Name = "lblJoeBetLabel";
            this.lblJoeBetLabel.Size = new System.Drawing.Size(150, 23);
            this.lblJoeBetLabel.TabIndex = 12;
            this.lblJoeBetLabel.Text = "Joe Bet Label";
            // 
            // lblBobBetLabel
            // 
            this.lblBobBetLabel.Location = new System.Drawing.Point(288, 316);
            this.lblBobBetLabel.Name = "lblBobBetLabel";
            this.lblBobBetLabel.Size = new System.Drawing.Size(150, 23);
            this.lblBobBetLabel.TabIndex = 13;
            this.lblBobBetLabel.Text = "Bob Bet Label";
            // 
            // lblAlBetLabel
            // 
            this.lblAlBetLabel.Location = new System.Drawing.Point(288, 347);
            this.lblAlBetLabel.Name = "lblAlBetLabel";
            this.lblAlBetLabel.Size = new System.Drawing.Size(150, 23);
            this.lblAlBetLabel.TabIndex = 14;
            this.lblAlBetLabel.Text = "Al Bet Label";
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
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
            this.pboxRaceTrack.Location = new System.Drawing.Point(13, 13);
            this.pboxRaceTrack.Name = "pboxRaceTrack";
            this.pboxRaceTrack.Size = new System.Drawing.Size(1377, 586);
            this.pboxRaceTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxRaceTrack.TabIndex = 0;
            this.pboxRaceTrack.TabStop = false;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 611);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAlBetLabel);
            this.Controls.Add(this.lblBobBetLabel);
            this.Controls.Add(this.lblJoeBetLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMinBet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updownSnail);
            this.Controls.Add(this.updownBetValue);
            this.Controls.Add(this.btnBet);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.rbAl);
            this.Controls.Add(this.rbBob);
            this.Controls.Add(this.rbJoe);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pboxRaceTrack);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.updownBetValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownSnail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxRaceTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

