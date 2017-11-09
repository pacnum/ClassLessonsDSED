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
            this.rbJo = new System.Windows.Forms.RadioButton();
            this.rbBob = new System.Windows.Forms.RadioButton();
            this.rbAl = new System.Windows.Forms.RadioButton();
            this.lblName = new System.Windows.Forms.Label();
            this.btnBet = new System.Windows.Forms.Button();
            this.updownBetValue = new System.Windows.Forms.NumericUpDown();
            this.updownSnail = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMinBet = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblJoBetLabel = new System.Windows.Forms.Label();
            this.lblBobBetLabel = new System.Windows.Forms.Label();
            this.lblAlBetLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
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
            // rbJo
            // 
            this.rbJo.AutoSize = true;
            this.rbJo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJo.Location = new System.Drawing.Point(298, 53);
            this.rbJo.Name = "rbJo";
            this.rbJo.Size = new System.Drawing.Size(129, 32);
            this.rbJo.TabIndex = 2;
            this.rbJo.TabStop = true;
            this.rbJo.Text = "Jo has $50";
            this.rbJo.UseVisualStyleBackColor = true;
            this.rbJo.CheckedChanged += new System.EventHandler(this.rbJoe_CheckedChanged);
            // 
            // rbBob
            // 
            this.rbBob.AutoSize = true;
            this.rbBob.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBob.Location = new System.Drawing.Point(298, 147);
            this.rbBob.Name = "rbBob";
            this.rbBob.Size = new System.Drawing.Size(145, 32);
            this.rbBob.TabIndex = 3;
            this.rbBob.TabStop = true;
            this.rbBob.Text = "Bob has $75";
            this.rbBob.UseVisualStyleBackColor = true;
            this.rbBob.CheckedChanged += new System.EventHandler(this.rbBob_CheckedChanged);
            // 
            // rbAl
            // 
            this.rbAl.AutoSize = true;
            this.rbAl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAl.Location = new System.Drawing.Point(298, 237);
            this.rbAl.Name = "rbAl";
            this.rbAl.Size = new System.Drawing.Size(128, 32);
            this.rbAl.TabIndex = 4;
            this.rbAl.TabStop = true;
            this.rbAl.Text = "Al has $45";
            this.rbAl.UseVisualStyleBackColor = true;
            this.rbAl.CheckedChanged += new System.EventHandler(this.rbAl_CheckedChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Emoji", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(57, 313);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(99, 37);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Punter";
            // 
            // btnBet
            // 
            this.btnBet.Location = new System.Drawing.Point(222, 297);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(161, 59);
            this.btnBet.TabIndex = 6;
            this.btnBet.Text = "Bet";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // updownBetValue
            // 
            this.updownBetValue.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updownBetValue.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.updownBetValue.Location = new System.Drawing.Point(490, 304);
            this.updownBetValue.Name = "updownBetValue";
            this.updownBetValue.Size = new System.Drawing.Size(79, 38);
            this.updownBetValue.TabIndex = 7;
            this.updownBetValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // updownSnail
            // 
            this.updownSnail.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updownSnail.Location = new System.Drawing.Point(922, 310);
            this.updownSnail.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.updownSnail.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updownSnail.Name = "updownSnail";
            this.updownSnail.Size = new System.Drawing.Size(67, 38);
            this.updownSnail.TabIndex = 8;
            this.updownSnail.Tag = "";
            this.updownSnail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updownSnail.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(630, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 41);
            this.label1.TabIndex = 9;
            this.label1.Text = "For Snail Number ...";
            // 
            // lblMinBet
            // 
            this.lblMinBet.Location = new System.Drawing.Point(1137, 35);
            this.lblMinBet.Name = "lblMinBet";
            this.lblMinBet.Size = new System.Drawing.Size(150, 23);
            this.lblMinBet.TabIndex = 10;
            this.lblMinBet.Text = "Minimum Bet Label";
            this.lblMinBet.Visible = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(544, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Betting";
            this.label2.Visible = false;
            // 
            // lblJoBetLabel
            // 
            this.lblJoBetLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoBetLabel.Location = new System.Drawing.Point(682, 58);
            this.lblJoBetLabel.Name = "lblJoBetLabel";
            this.lblJoBetLabel.Size = new System.Drawing.Size(575, 46);
            this.lblJoBetLabel.TabIndex = 12;
            this.lblJoBetLabel.Text = "Jo has not made a bet";
            // 
            // lblBobBetLabel
            // 
            this.lblBobBetLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBobBetLabel.Location = new System.Drawing.Point(682, 147);
            this.lblBobBetLabel.Name = "lblBobBetLabel";
            this.lblBobBetLabel.Size = new System.Drawing.Size(575, 34);
            this.lblBobBetLabel.TabIndex = 13;
            this.lblBobBetLabel.Text = "Bob has not made a bet";
            // 
            // lblAlBetLabel
            // 
            this.lblAlBetLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlBetLabel.Location = new System.Drawing.Point(682, 237);
            this.lblAlBetLabel.Name = "lblAlBetLabel";
            this.lblAlBetLabel.Size = new System.Drawing.Size(575, 36);
            this.lblAlBetLabel.TabIndex = 14;
            this.lblAlBetLabel.Text = "Al has not made a bet";
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox7);
            this.groupBox1.Controls.Add(this.pictureBox6);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.lblMinBet);
            this.groupBox1.Controls.Add(this.rbJo);
            this.groupBox1.Controls.Add(this.rbBob);
            this.groupBox1.Controls.Add(this.rbAl);
            this.groupBox1.Controls.Add(this.lblJoBetLabel);
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
            this.groupBox1.Location = new System.Drawing.Point(123, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1368, 382);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(438, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 54);
            this.label3.TabIndex = 18;
            this.label3.Text = "$";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::DSED_Project3_BettingRaceV2.Properties.Resources.wink__1_;
            this.pictureBox7.Location = new System.Drawing.Point(197, 209);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(64, 64);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 17;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::DSED_Project3_BettingRaceV2.Properties.Resources.nerd;
            this.pictureBox6.Location = new System.Drawing.Point(197, 123);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(64, 64);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 16;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DSED_Project3_BettingRaceV2.Properties.Resources.smug__1__Transp;
            this.pictureBox5.Location = new System.Drawing.Point(196, 36);
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
            this.pictureBox4.Location = new System.Drawing.Point(3, 734);
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
            this.pictureBox3.Location = new System.Drawing.Point(3, 690);
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
            this.pictureBox2.Location = new System.Drawing.Point(3, 644);
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
            this.pictureBox1.Location = new System.Drawing.Point(3, 600);
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
            this.pboxRaceTrack.Size = new System.Drawing.Size(1579, 753);
            this.pboxRaceTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxRaceTrack.TabIndex = 0;
            this.pboxRaceTrack.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1583, 774);
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
        private System.Windows.Forms.RadioButton rbJo;
        private System.Windows.Forms.RadioButton rbBob;
        private System.Windows.Forms.RadioButton rbAl;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.NumericUpDown updownBetValue;
        private System.Windows.Forms.NumericUpDown updownSnail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMinBet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblJoBetLabel;
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
        private System.Windows.Forms.Label label3;
    }
}

