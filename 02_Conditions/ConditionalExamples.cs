using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Conditions
{
    [TestClass]
    public class ConditionalExamples
    {
        [TestMethod]
        public void IfElseStatements()
        {
            int age = 18;

            if( age > 17)
            {
                Console.WriteLine("You're an adult");
            }
            else if (age > 6)
            {
                Console.WriteLine("You're a kid");
            }
            else if (age > 0)
            {
                Console.WriteLine("You are way to young, stop that.");
            }
            else
            {
                Console.WriteLine("How do you exist and reasonably use a computer?");
            }

            if( age < 65 && age > 17)
            {
                Console.WriteLine("You are either old enough or young enough to kick ass");
            } else if( age > 64 || age < 18)
            {
                Console.WriteLine("You can still kickass too i guess");
            }

            if (age == 21)
            {
                Console.WriteLine("yay, you can drink");
            }

            if(age != 19)
            {
                Console.WriteLine("you're not 'equal to' 19 years old");
            }
        }

        [TestMethod]
        public void SwitchCases()
        {
            int age = 22;
            //switches in c# cant have operators, only straight value
            switch (age)
            {
                case 18:
                    Console.WriteLine("You can vote, and get thousand in student debt");
                    break;
                case 21:
                    Console.WriteLine("you can drink now, and still get thousands in student debt");
                    break;
                case 16:
                    Console.WriteLine("you can drive now");
                    break;
                case 22:
                case 23: //22, 23, 24 case all same result this way;
                case 24:
                    Console.WriteLine("party years");
                    break;
                default:
                    Console.WriteLine("nothing significant for your age, and highly likely to be in debt");
                    break;
            }
        }

        [TestMethod]
        public void Ternaries()
        {
            // (Condition/boolean) ? trueResult : falseResult
            int age = 78;

            bool isAdult = (age > 80) ? true : false;

            int numOne = 10;
            int numTwo = (numOne == 10) ? 30 : 20;
            Console.WriteLine((numOne == 5) ? "true" : "false" );
        }
    }
}
