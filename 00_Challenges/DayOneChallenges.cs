using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _00_Challenges
{
    [TestClass]
    public class DayOneChallenges
    {
        [TestMethod]
        public void ChallengeOne()
        {
            //declare/initialise variables- one int, one string, one datetime
        }
        [TestMethod]
        public void ChallengeTwo()
        {
            //write a switch case that evaluates a user's response
            //whether or not they are wearing clothes
        }
        [TestMethod]
        public void ChallengeThree()
        {
            //write an if statement that uses a boolean to check if the user is happy or not
        }
        [TestMethod]
        public void ChallengeFour()
        {
            //write an if/else that gives responses based on salary ranges
            //1,000-10,000
            //11,000-50,000
            //51,000-100,000

        }
        [TestMethod]
        public void ChallengeFive()
        {
            //CHALLENGE: create a method that takes two strings from user and outputs the concated string;
            string strOne = "Hello";
            string strTwo = "How are you today?";
            string totalGreeting = ConcatStrings(strOne, strTwo);
        }
        private string ConcatStrings(string a, string b)
        {
            return a + ", " + b;
        }
        [TestMethod]
        public void ChallengeSix()
        {
            //build a greeting method, that prints a user's name to the console
            string name = "Laura";
            //string greeting = Greeting(name);
            Greeting(name);
        }
        private void Greeting(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
