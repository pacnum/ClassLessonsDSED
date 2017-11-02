namespace DSED_Project1
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
            this.btnRandom = new System.Windows.Forms.Button();
            this.txtbRandomNumber = new System.Windows.Forms.TextBox();
            this.btnFire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(219, 160);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(123, 62);
            this.btnRandom.TabIndex = 0;
            this.btnRandom.Text = "button1";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbRandomNumber
            // 
            this.txtbRandomNumber.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbRandomNumber.Location = new System.Drawing.Point(581, 168);
            this.txtbRandomNumber.Name = "txtbRandomNumber";
            this.txtbRandomNumber.Size = new System.Drawing.Size(78, 38);
            this.txtbRandomNumber.TabIndex = 1;
            this.txtbRandomNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFire
            // 
            this.btnFire.Location = new System.Drawing.Point(219, 265);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(123, 64);
            this.btnFire.TabIndex = 2;
            this.btnFire.Text = "button2";
            this.btnFire.UseVisualStyleBackColor = true;
            // this.btnFire.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 670);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.txtbRandomNumber);
            this.Controls.Add(this.btnRandom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.TextBox txtbRandomNumber;
        private System.Windows.Forms.Button btnFire;
    }
}

