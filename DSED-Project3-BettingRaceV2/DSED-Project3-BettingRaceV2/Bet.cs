using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSED_Project3_BettingRaceV2
{
    public class Bet
    {
        public int amount;
        public int snail;
        public Guy Bettor;

        public int Payout(int winnerSnail)
        {
            //Winner of race is paid *2 otherwise they lose
            return snail == winnerSnail ? amount * 2 : 0;
        }
    }
}
