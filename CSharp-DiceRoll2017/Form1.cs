using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_DiceRoll2017
{
    public partial class Form1 : Form
    {
        int value;
        public Form1()
        {
            InitializeComponent();

            NumberOfDice();
            DiceResultNumber();
        }

        public void NumberOfDice()
        {
            cmbNumberOfDice.Items.Add(1);
            cmbNumberOfDice.Items.Add(2);
            cmbNumberOfDice.Items.Add(3);
            cmbNumberOfDice.Items.Add(4);
            cmbNumberOfDice.Items.Add(5);
            cmbNumberOfDice.Items.Add(6);
            //cmbNumberOfDice.Items.Add(7);
            //cmbNumberOfDice.Items.Add(8);
            //cmbNumberOfDice.Items.Add(9);



        }

        public void DiceResultNumber()
        {
            cmbDiceResultNumber.Items.Add(1);
            cmbDiceResultNumber.Items.Add(2);
            cmbDiceResultNumber.Items.Add(3);
            cmbDiceResultNumber.Items.Add(4);
            cmbDiceResultNumber.Items.Add(5);
            cmbDiceResultNumber.Items.Add(6);

        }


        private void btnDiceRoll_Click(object sender, EventArgs e)
        {

            Random random = new Random(DateTime.Now.Millisecond);
            Thread.Sleep(5);
            int Dice1, Dice2, Dice3, Dice4, Dice5, Dice6, Dice7, Dice8, Dice9 = 0;
            lbxDiceRoll.Items.Clear();
            bool RollDiceAgain = true;
            int Count = 0;

            //Trying to get code to select a dice number ... 
            // bool DiceResult = cmbDiceResultNumber;

            //In pleace to work out high score code
            //int HighestScore = 0;




            do
            {
                Count++;


                Dice1 = random.Next(1, 7);
                Dice2 = random.Next(1, 7);
                Dice3 = random.Next(1, 7);
                Dice4 = random.Next(1, 7);
                Dice5 = random.Next(1, 7);
                Dice6 = random.Next(1, 7);
                // Dice7 = random.Next(1, 7);
                // Dice8 = random.Next(1, 7);
                // Dice9 = random.Next(1, 7);

                lbxDiceRoll.Items.Insert(0,
                    Dice1 + " " + Dice2 + " " + Dice3 + " " + Dice4 + " " + Dice5 + " " + Dice6); // + " " + Dice7);//

                if ((Dice1 == Dice2) && (Dice2 == Dice3) && (Dice3 == Dice4) && (Dice4 == Dice5) && (Dice5 == Dice6)) //&& //(Dice6 == Dice7)//)
                {
                    RollDiceAgain = false;

                }

                lblCount.Text = "This dice roll took ... " + Count + " times";

                //This code section is in the loop here - so in the wrong place
                //lblHighScore.Items.Add(Count);


            } while (RollDiceAgain == true);

            lblHighScore.Items.Add(Count);
            cmbNumberOfDice.Items.Clear();
            NumberOfDice();

        }

        private void cmbNumberOfDice_SelectedIndexChanged(object sender, EventArgs e)
        {
            value = Convert.ToInt32(cmbNumberOfDice.SelectedItem);
        }







        // Add Count to High Score




        // if HighScore  < Count, Count is now new HighScore; --- .max


        //     if (HighScore > Count) lblHighScore.Items.Add(HighScore);
        //     else
        //      {
        //         
        //      }




    }
}

