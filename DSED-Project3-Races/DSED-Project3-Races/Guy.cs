using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSED_Project3_Races
{
    class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;

        public RadioButton MyradioButton;
        public Label MyLabel;

        //public void ClearBet()
        //{
        //    if (MyBet != null)
        //    {
        //        MyBet.Amount = 0;
        //    }

        //}

        //public bool PlaceBet(int BetAmount, int SnailtoWin)
        //{
        //    MyBet = new Bet() { Amount = BetAmount, Snail = SnailtoWin, Bettor = this };

        //    if (BetAmount <= Cash)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        public void Collect(int Winner)
        {
            if (MyBet != null)
            {
                Cash += MyBet.Payout(Winner);
            }
        }
    }
}
