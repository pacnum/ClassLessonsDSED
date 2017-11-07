using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSED_Project3_BettingRaceV2
{
    public partial class Form1 : Form
    {
        Snail[] snailArray = new Snail[4];
        Guy[] guyArray = new Guy[3];
        int bettorNumber;
        int snailID;

        public Form1()
        {
            InitializeComponent();
            snailArray[0] = new Snail() { myPictureBox = pictureBox1 };
            snailArray[1] = new Snail() { myPictureBox = pictureBox2 };
            snailArray[2] = new Snail() { myPictureBox = pictureBox3 };
            snailArray[3] = new Snail() { myPictureBox = pictureBox4 };
            guyArray[0] = new Guy() { name = "Joe", cash = 50, guyLabel = lblJoBetLabel, guyRadioButton = rbJoe };
            guyArray[1] = new Guy() { name = "Bob", cash = 75, guyLabel = lblBobBetLabel, guyRadioButton = rbBob };
            guyArray[2] = new Guy() { name = "Al", cash = 45, guyLabel = lblAlBetLabel, guyRadioButton = rbAl };

            lblMinBet.Text = $"Minimum Bet Allowed: {updownBetValue.Minimum}";
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (snailID = 0; snailID < snailArray.Length; snailID++)
            {
                if (!snailArray[snailID].IsWinner())
                {
                    snailArray[snailID].Run();
                }
                else
                {
                    timer1.Stop();
                    groupBox1.Enabled = true;
                    MessageBox.Show($"Snail Number # {snailID+1} was the Winner", "Congratulations!!");
                    EndOfRace();

                }
            }
        }

        public void EndOfRace()
        {
            foreach (Guy guy in guyArray)
            {
                if (guy.isBetDone == true)
                {
                    guy.Collect(snailID);
                    guy.ClearLabels();
                }
                guy.isBetDone = false;
            }
            foreach (Snail snail in snailArray)
                snail.TakeStartingPosition();
            return;
        }

        #region RadioButtonChecks-Region
        private void rbJoe_CheckedChanged(object sender, EventArgs e)
        {
            if (rbJoe.Checked)
            {
                lblName.Text = "Joe";
                bettorNumber = 0;
            }
        }

        private void rbBob_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBob.Checked)
            {
                lblName.Text = "Bob";
                bettorNumber = 1;
            }
        }

        private void rbAl_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAl.Checked)
            {
                lblName.Text = "Al";
                bettorNumber = 2;
            }
        }


        #endregion

        private void btnBet_Click(object sender, EventArgs e)
        {
            if (!guyArray[bettorNumber].isBetDone)
                guyArray[bettorNumber].PlaceBet((int) updownBetValue.Value, (int) updownSnail.Value);
            else
            {
                MessageBox.Show ($"{guyArray}[bettorNumber].name) has not bet");
            }
        }
    }
}
