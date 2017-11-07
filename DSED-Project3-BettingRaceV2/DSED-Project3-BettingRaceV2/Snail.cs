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
        //Create distance, racetracklength, random, and picturebox functions within this code 
        public int distance;
        public int racetrackLength = 1120;
        public PictureBox myPictureBox;
        static Random randomizer = new Random();

        //Have the snail position start at the left of the screen, and distance to be the beginning of the windows form feild(0)
        public void UpdatePosistion()
        {
            myPictureBox.Left = distance;
        }

        public void TakeStartingPosition()
        {
            distance = 10;
            UpdatePosistion();
        }

        //run the race with each snail moving a randon number to the right between 1 and 5 
        //minus another random number between 1 and 2
        //untill the end of the race, each time showing the images again as an updatepostion command
        public void Run()
        {
            distance += randomizer.Next(1,5) - randomizer.Next(1,2);
            UpdatePosistion();
        }

        //Run race untill their is a winner
        public bool IsWinner()
        {
            return myPictureBox.Left >= racetrackLength ? true : false;
        }
    }
}
