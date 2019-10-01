using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types
{
    [TestClass]
    public class TypeExamples
    {
        [TestMethod]
        public void ValueTypes()
        {
            float firstVariable; //this is a declaration
            firstVariable = 7f; //this is initialization

            bool on = true;
            bool off = false;

            char character = '@'; //char only used single quotes, not doubles. only one character, no more

            //number types:
            //int, double, decimal, float, long, short, byte
            byte byteExample = 255; //0-255, uncommon
            sbyte sByteExmaple = -128; //bytes that are neg
            short shortExample = -32768; //-32768--32767
            Int16 anotherShortExample = 12312; //same as short
            int intMin = -2147483648;
            Int32 intMax = 2147483647;
            long longExample = 9223372036854775807;
            Int64 longMin = -9223372036854775808; //this and above are whole numbers only

            //decimal types, need suffixes at end
            float floatExample = 1.024312f; //need f at end, decimal type, single precision floating-point number, round to 7 digits
            double doubleExmaple = 3.22432342342342342334; //does not need suffix, it is default decimal type, or can have d at end, single precision floating-point number, can be very long, rounds after 15 digits
            decimal decimalExmaple = 1.23352345234m; //needs m at end, m has to meaning, for extreme precision, longest of all decimal types

        }

        [TestMethod]
        public void Operators()
        {
            int numOne = 15;
            int numTwo = 7;

            int sum = numOne + numTwo;
            int diff = numOne - numTwo;
            int quot = numOne / numTwo; //nearest whole number
            int prod = numOne * numTwo; 
            int remainder = numOne % numTwo; //remainer from division

        }

        [TestMethod]
        public void ReferenceTypes()
        {
            string firstName = "john"; //need double quotes
            string age = "42";
            string lastName = "smith";

            //concatenation
            string name = firstName + " " + lastName;

            //Composite formatting
            string compositeFullName = string.Format("{0} {1}", firstName, lastName);

            //String interpolation
            string interpolationName = $"{firstName} {lastName}";

            Console.WriteLine(firstName);
            Console.WriteLine(interpolationName);
            Console.WriteLine(compositeFullName);

            //other reference types - objects
            DateTime today = DateTime.Today; //stores both a date and a time, multiple type, ie today/now/tomorrow, days in month etc, these are structs not actually references
            DateTime someDay = new DateTime(1978, 1, 1); //creates new datetime value;
            TimeSpan timeSpanExample = today - someDay; //math
            Console.WriteLine(someDay);

            //Collections - i.e. array, diff from javascript array, not often used
            string banana = "An awesome fruit";
            string[] strArray = { "Hello","Ahhhh","World","I'm suck in a computer", banana, "?" };
            string[] anotherArray = new string[17]; //needs pre determined array length in this format

            List<string> listExample = new List<string>();
            listExample.Add(banana); //these are like javascript arrays
            listExample.Add("hello");
            Console.WriteLine(listExample);

            Queue<int> queueExample = new Queue<int>(); //first in, first out collection of objects/arrays
            Dictionary<int, string> dictionaryExample = new Dictionary<int, string>(); //this is more like javascript objects,

        }
    }
}
