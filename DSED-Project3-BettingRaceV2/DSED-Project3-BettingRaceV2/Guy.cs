using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSED_Project3_BettingRaceV2
{


    public class Guy
    {
        //Create name, myBet, cash, isBetDone, RadioButtons and  guylabels to be used within this code 
        public string name;
        public Bet myBet;
        public int cash;
        public bool isBetDone = false;
        public RadioButton guyRadioButton;
        public Label guyLabel;

        public void UpdateLabels()
        {
            //Updates labels and radio buton text with cash avaiable and Snail Bet Number
            guyRadioButton.Text = $"{name} has ${cash}";
            guyLabel.Text = $"{name} bets ${myBet.amount} on Snail Number {myBet.snail + 1}";
        }

        public void ClearLabels()
        {
            //Recalulates avaiable cash, and if no bet is give, displays this message in Betting Label
            guyRadioButton.Text = $"{name} has ${cash}";
            guyLabel.Text = $"{name} did not make a bet";
        }

        public void PlaceBet(int amount, int snailToWin)
        {
            //Displays an error message if bet amount is greater than avaiable cash
            if (cash < amount)
            {
                MessageBox.Show($"{name} doesn't have enough money");
            }
            else
            {
                //If all good, bet amount is taken, myBet (amount,Snail, and Bettor) info is collected
                //and labels are updated to show the selection
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
            //Winner of race is paid 
            cash += myBet.Payout(winnerSnail);
        }



    }
}
