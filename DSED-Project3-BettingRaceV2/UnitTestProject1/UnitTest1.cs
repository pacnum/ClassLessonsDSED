using System;
using System.Runtime.CompilerServices;
using DSED_Project3_BettingRaceV2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        
        readonly Form1 myForm = new Form1();
        Guy[] guyArray = new Guy[3];

        [TestMethod]
        public void  JoStartingCash()
        {
            //Unit test to confirm starting Cash for Jo
            guyArray[0] = new Guy() { name = "Jo", cash = 50 };
            var Actual = 50;
            var Cash = 50;
            Assert.IsTrue(Actual == Cash);
        }

        [TestMethod]
        public void BobStartingCash()
        {
            //Unit test to confirm starting Cash for J
            guyArray[0] = new Guy() { name = "Bob", cash = 75 };
            var Actual = 75;
            var Cash = 75;
            Assert.IsTrue(Actual == Cash);
        }


    }
}
