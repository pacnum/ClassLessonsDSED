using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSED_Project3_Races
{
    class Bet
    {
        public int Amount;
        public int Snail;
        public LegoPunter Bettor;

        public string GetDescription()
        {
            if (Bettor.PlaceBet(Bettor.MyBet.Amount, Bettor.MyBet.Snail) == true)
            {
                return Bettor.Name + " bets " + Amount + " on snail number " + (Snail + 1);
            }
            else
            {
                Bettor.ClearBet();
                return Bettor.Name + " didn't bet";
            }
        }

        public int Payout(int Winner)
        {
            if (Bettor.MyBet.Snail == Winner)
            {
                return Amount;

            }
            else
            {
                return -Amount;
            }
        }
    }
}
