using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSED_Project3_Races
{
    public class Snail
    {
        //public int SnailID { get; set; }
        //public string Name { get; set; }
        public int StartingPosition;
        public int RacetrackLenght;
        public PictureBox MyPictureBox = null;
        public Random MyRandom;

        public bool Run()
        {
            MyPictureBox.Left += MyRandom.Next(1, 5);
            if (MyPictureBox.Left >= RacetrackLenght - 45)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void TakeStartingPostion()
        {
            MyPictureBox.Left = StartingPosition;
        }
    }
}
