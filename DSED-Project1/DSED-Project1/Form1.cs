using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSED_Project1
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        //Finding a random number between 1 and 6 - and placing in a textbox called RandomNumber.

        public void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int dice = rnd.Next(1, 7); // Random Number between 1 and <7

            txtbRandomNumber.Text = dice.ToString();

            this.Text = dice.ToString();

        }

        //public void button2_Click(object sender, EventArgs e)
        //{
        //    int Count = 0;
        //    bool ShootAgain = true;

        //    do
        //    {
        //        Count++;
        //        if (ShootAgain == dice)
        //        {
        //        }
        //    } while (VScroll);

        //}

    }


}
