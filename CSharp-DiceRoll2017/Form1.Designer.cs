namespace CSharp_DiceRoll2017
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
            this.lbxDiceRoll = new System.Windows.Forms.ListBox();
            this.btnDiceRoll = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNumberOfDice = new System.Windows.Forms.ComboBox();
            this.cmbDiceResultNumber = new System.Windows.Forms.ComboBox();
            this.lblNumberOfDiceSelected = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxDiceRoll
            // 
            this.lbxDiceRoll.FormattingEnabled = true;
            this.lbxDiceRoll.ItemHeight = 16;
            this.lbxDiceRoll.Location = new System.Drawing.Point(87, 88);
            this.lbxDiceRoll.Name = "lbxDiceRoll";
            this.lbxDiceRoll.Size = new System.Drawing.Size(287, 292);
            this.lbxDiceRoll.TabIndex = 0;
            // 
            // btnDiceRoll
            // 
            this.btnDiceRoll.Location = new System.Drawing.Point(481, 88);
            this.btnDiceRoll.Name = "btnDiceRoll";
            this.btnDiceRoll.Size = new System.Drawing.Size(200, 109);
            this.btnDiceRoll.TabIndex = 1;
            this.btnDiceRoll.Text = "Roll";
            this.btnDiceRoll.UseVisualStyleBackColor = true;
            this.btnDiceRoll.Click += new System.EventHandler(this.btnDiceRoll_Click);
            // 
            // lblCount
            // 
            this.lblCount.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.Maroon;
            this.lblCount.Location = new System.Drawing.Point(481, 236);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(200, 144);
            this.lblCount.TabIndex = 2;
            // 
            // lblHighScore
            // 
            this.lblHighScore.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.ForeColor = System.Drawing.Color.Maroon;
            this.lblHighScore.FormattingEnabled = true;
            this.lblHighScore.ItemHeight = 37;
            this.lblHighScore.Location = new System.Drawing.Point(813, 152);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(224, 226);
            this.lblHighScore.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(813, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "High Score";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbNumberOfDice
            // 
            this.cmbNumberOfDice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbNumberOfDice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNumberOfDice.FormattingEnabled = true;
            this.cmbNumberOfDice.Location = new System.Drawing.Point(182, 438);
            this.cmbNumberOfDice.Name = "cmbNumberOfDice";
            this.cmbNumberOfDice.Size = new System.Drawing.Size(82, 39);
            this.cmbNumberOfDice.TabIndex = 5;
            this.cmbNumberOfDice.SelectedIndexChanged += new System.EventHandler(this.cmbNumberOfDice_SelectedIndexChanged);
            // 
            // cmbDiceResultNumber
            // 
            this.cmbDiceResultNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbDiceResultNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDiceResultNumber.FormattingEnabled = true;
            this.cmbDiceResultNumber.Location = new System.Drawing.Point(878, 426);
            this.cmbDiceResultNumber.Name = "cmbDiceResultNumber";
            this.cmbDiceResultNumber.Size = new System.Drawing.Size(80, 70);
            this.cmbDiceResultNumber.TabIndex = 6;
            // 
            // lblNumberOfDiceSelected
            // 
            this.lblNumberOfDiceSelected.AutoSize = true;
            this.lblNumberOfDiceSelected.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfDiceSelected.Location = new System.Drawing.Point(87, 403);
            this.lblNumberOfDiceSelected.Name = "lblNumberOfDiceSelected";
            this.lblNumberOfDiceSelected.Size = new System.Drawing.Size(286, 32);
            this.lblNumberOfDiceSelected.TabIndex = 7;
            this.lblNumberOfDiceSelected.Text = "Number of Dice Selected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(807, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Dice Result Number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 917);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNumberOfDiceSelected);
            this.Controls.Add(this.cmbDiceResultNumber);
            this.Controls.Add(this.cmbNumberOfDice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnDiceRoll);
            this.Controls.Add(this.lbxDiceRoll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxDiceRoll;
        private System.Windows.Forms.Button btnDiceRoll;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.ListBox lblHighScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNumberOfDice;
        private System.Windows.Forms.ComboBox cmbDiceResultNumber;
        private System.Windows.Forms.Label lblNumberOfDiceSelected;
        private System.Windows.Forms.Label label2;
    }
}

