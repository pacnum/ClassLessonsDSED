using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSED_Project3_BettingRaceV2
{


    class Guy
    {
        public string name;
        public Bet myBet;

        public int cash;
        public bool isBetDone = false;
        public RadioButton guyRadioButton;
        public Label guyLabel;

        public void UpdateLabels()
        {
            guyRadioButton.Text = $"{name} has {"$"+cash} !!";
            guyLabel.Text = $"{name} bets ${myBet.amount} on Snail Number {myBet.snail + 1}";
        }

        public void ClearLabels()
        {
            guyRadioButton.Text = $"{name} has {"$"+cash}";
            guyLabel.Text = $"{name} did not make a bet";
        }

        public void PlaceBet(int amount, int snailToWin)
        {
            if (cash < amount)
            {
                MessageBox.Show($"{name} doesn't have enough money");
            }
            else
            {
                isBetDone = true;
                cash -= amount;
                myBet = new Bet();
                myBet.amount = amount;
                myBet.snail = snailToWin - 1;
                myBet.Bettor = this;
                UpdateLabels();
            }
        }

        public void Collect(int winnerSnail)
        {
            cash += myBet.Payout(winnerSnail);
        }



    }
}
