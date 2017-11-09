using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSED_Project3_BettingRaceV2
{
    //todo - Project Requirements
    //todo - Form Features
    //1.1 - The Maximum amount that can be bet for each bettor in a label - Done
    //todo 1.2 - The Up/Down box can only go to the maximum number for each bettor - 
    //todo (yes and no )  - It goes up - but an error displays when trying to bet more -
    //1.3 - When the The Bet is made, the name, amount, and Snail apper on the right - Done
    //1.4 - When a person is out of money, they CANNOT bet again - Done
    //1.5 - When all bettors lose, the game is over - Done unable to bet anymore

    //todo - Class Operations
    //2.1 - Two classes Greyhound and Bet - Done
    //2.2 - An Abstract punter class - Done
    //2.3 - Three inherited bettor classes - Done

    //todo - Unit Class
    //3.1 - A unit test using instantiation - Done





    public partial class Form1 : Form
    {
        //Snail and Guy Arrays need to be created
        //Create bettor numbers
        //Create a snail ID number

        Snail[] snailArray = new Snail[4];
        Guy[] guyArray = new Guy[3];
        int bettorNumber;
        int snailID;
        //private int cash;

        public Form1()
        {
            //Snail Array numbers 0-3 (1-4 snails) and associated image for race
            //Guy Arrays numbers 0-2 (1-3 guys)  and associated starting cash

            InitializeComponent();
            snailArray[0] = new Snail() { myPictureBox = pictureBox1 };
            snailArray[1] = new Snail() { myPictureBox = pictureBox2 };
            snailArray[2] = new Snail() { myPictureBox = pictureBox3 };
            snailArray[3] = new Snail() { myPictureBox = pictureBox4 };
            guyArray[0] = new Guy() { name = "Jo", cash = 50, guyLabel = lblJoBetLabel, guyRadioButton = rbJo };
            guyArray[1] = new Guy() { name = "Bob", cash = 75, guyLabel = lblBobBetLabel, guyRadioButton = rbBob };
            guyArray[2] = new Guy() { name = "Al", cash = 45, guyLabel = lblAlBetLabel, guyRadioButton = rbAl };

            //lblMinBet.Text = $"Minimum Bet Allowed: {updownBetValue.Minimum}";
            
        }

        //Race Start Button Click – Start the race timer, disable the betting group box
        private void btnStart_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            timer1.Start();
        }

        //Timer1_tick (System.Windows.Form.Timer) -  runs the race until there is a winner 
        //then displays congratulations message box
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
                    GameOver();
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

        //This region is for RadioButton Checks for punters to assign bettor numbers, 
        //so we can Display their name when making a bet in the lblName Label.
        //Added updown maximum = guy cash ( working now ! ) - 9-11-2017

        #region RadioButtonChecks-Region

        //public void RadioButton_CheckChanged(object sender, EventArgs e)
        //{
        //    RadioButton rbFake = sender as RadioButton;
        //    if (rbFake.Checked == true)
        //    {
        //        int ID = Convert.ToInt16(rbFake.Tag);
        //        //updownBetValue.Maximum = (int) Guy.cash;


        //    }
        //}

        //public static string GuyCash()
        //{
        //    GuyCash() = Guy.cash;
        //}
        private void rbJoe_CheckedChanged(object sender, EventArgs e)
        {
           

            if (rbJo.Checked)
            {
                lblName.Text = "Jo";
                bettorNumber = 0;
                //updownBetValue.Maximum = cash;
                updownBetValue.Maximum = guyArray[0].cash;



            }
        }

        private void rbBob_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBob.Checked)
            {
                lblName.Text = "Bob";
                bettorNumber = 1;
                updownBetValue.Maximum = guyArray[1].cash;
            }
        }

        private void rbAl_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAl.Checked)
            {
                lblName.Text = "Al";
                bettorNumber = 2;
                updownBetValue.Maximum = guyArray[2].cash;
            }
        }


        #endregion

        //Display a message if a punter/bettor has not bet.
        private void btnBet_Click(object sender, EventArgs e)
        {
            if (!guyArray[bettorNumber].isBetDone)
                guyArray[bettorNumber].PlaceBet((int) updownBetValue.Value, (int) updownSnail.Value);
            guyArray[bettorNumber].UpdateLabels();

        }

        public void GameOver()
        {
            if (guyArray[0].cash <= 0 && guyArray[1].cash <= 0 && guyArray[2].cash <= 0)
            {
                MessageBox.Show("Im Sorry All the bettors are now Broke - Game Over");
                this.Close();
            }
        }




    }
}
