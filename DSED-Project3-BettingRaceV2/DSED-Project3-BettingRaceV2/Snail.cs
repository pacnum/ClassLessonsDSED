using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSED_Project3_BettingRaceV2
{
    class Snail
    {
        public int distance;
        public int racetrackLength = 1120;
        public PictureBox myPictureBox;
        static Random randomizer = new Random();

        public void UpdatePosistion()
        {
            myPictureBox.Left = distance;
        }

        public void TakeStartingPosition()
        {
            distance = 0;
            UpdatePosistion();
        }

        public void Run()
        {
            distance += randomizer.Next(1, 5);
            UpdatePosistion();
        }

        public bool IsWinner()
        {
            return myPictureBox.Left >= racetrackLength ? true : false;
        }
    }
}
