using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSED_Project3_Races
{
    public partial class Form1 : Form
    {
        Snail[] SnailArray = new Snail[4];
        LegoPunter[] LegoPunterArray = new LegoPunter[3];
        Random Randomizer = new Random();

        public Form1()
        {
            InitializeComponent();
            //LoadData();
            SnailArray[0] = new Snail()
            {
                MyPictureBox = pboxSnail1,
                StartingPosition = pboxSnail1.Left,
                RacetrackLenght = raceTrack.Width - pboxSnail1.Width,
                MyRandom = Randomizer
            };

            SnailArray[1] = new Snail()
            {
                MyPictureBox = pboxSnail2,
                StartingPosition = pboxSnail2.Left,
                RacetrackLenght = raceTrack.Width - pboxSnail2.Width,
                MyRandom = Randomizer
            };

            SnailArray[3] = new Snail()
            {
                MyPictureBox = pboxSnail3,
                StartingPosition = pboxSnail3.Left,
                RacetrackLenght = raceTrack.Width - pboxSnail3.Width,
                MyRandom = Randomizer
            };

            SnailArray[4] = new Snail()
            {
                MyPictureBox = pboxSnail4,
                StartingPosition = pboxSnail4.Left,
                RacetrackLenght = raceTrack.Width - pboxSnail4.Width,
                MyRandom = Randomizer
            };

            LegoPunterArray[0] = new LegoPunter
            {

                Name = "Jane",
                Cash = 50,
                MyradioButton = rbJane,
                //MyLabel = txbJaneBet,
                MyBet = null,

            };


            LegoPunterArray[1] = new LegoPunter
            {

                Name = "John",
                Cash = 75,
                MyradioButton = rbJohn,
                //MyLabel = txbJohnBet,
                MyBet = null,

            };

            LegoPunterArray[2] = new LegoPunter
            {

                Name = "Jim",
                Cash = 50,
                MyradioButton = rbJim,
               // MyLabel = txbJimBet,
                MyBet = null,

            };

            for (int i = 0; i < 3; i++)
            {
                LegoPunterArray[i].UpdateLabels();
            }
        }


        private void StartTheRace_Click(object sender, EventArgs e)
        {
            timer1.Start();
            //groupbox1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i <= 3; i++)
            {
                if (SnailArray[i].Run() == true)
                {
                    for (int k = 0; k <= 2; k++)
                    {
                        LegoPunterArray[k].Collect(i);
                        LegoPunterArray[k].ClearBet();
                        LegoPunterArray[k].UpdateLabels();
                    }
                    for (int j = 0; j <= 3; j++)
                    {
                        SnailArray[j].TakeStartingPostion();
                    }
                    timer1.Stop();
                    //groupbox1.Enabled = true;
                    MessageBox.Show("Snail number " + (i + 1) + " won the race!");
                }
                else
                {
                    SnailArray[i].Run();
                }
            }
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 2; i++)
            {
                if (LegoPunterArray[i].MyradioButton.Checked == true)
                {
                    LegoPunterArray[i].PlaceBet((int)updownBetAmount.Value, ((int)updownSnailNumber.Value - 1));
                    LegoPunterArray[i].MyLabel.Text = LegoPunterArray[i].MyBet.GetDescription();
                }
            }
        }

        private void rbJane_CheckedChanged(object sender, EventArgs e)
        {
            if (rbJane.Checked == true)
            {
                lblname.Text = "Jane";
            }
        }

        private void rbJohn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbJohn.Checked == true)
            {
                lblname.Text = "John";
            }
        }

        private void rbJim_CheckedChanged(object sender, EventArgs e)
        {
            if (rbJim.Checked == true)
            {
                lblname.Text = "Jim";
            }
        }


    }
}
