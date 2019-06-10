using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Methods
{
    [TestClass]
    public class MethodsExample
    {
        [TestMethod]
        public void Methods()
        {
            int sumOne = AddTwoNumbers(4, 17);
            AddTwoNumbers(6, 25);

            int x = 4, y = 4; //nice short for multiple sames
            int numberOne = int.Parse("17");
            string response = "5";
            int numberTwo = int.Parse(response);
            int sumTwo = AddTwoNumbers(numberOne, numberTwo);
            SubTwoNumbers(5, 3);
            MultTwoNumbers(4, 4);
            DivideTwoNumbers(8, 2);
            float dividend = DivideTwoNumbers(4, 0); //to avoid issues with divvide by errors
            RemainderOfTwoNumbers(34, 9);
        }
        //Access modifier (public, private, internal)
        //Return type (the type that the method returns or spits out)
        //Method signature (method name, and the parameters)

        //access modifier   return type   name(parameters)
        private int AddTwoNumbers( int numOne, int numTwo)
        {
            int result = numOne + numTwo;
            return result;
        }
        private int SubTwoNumbers( int a, int b)
        {
            return a - b;
        }
        private int MultTwoNumbers( int a, int b)
        {
            return a * b;
        }
        private float DivideTwoNumbers( float a, float b)
        {
            //return a/b; will create run time error is divided by 0, fix out of method
            return a / b;
        }
        private int RemainderOfTwoNumbers(int a, int b)
        {
            return a % b;
        }
    }
}
