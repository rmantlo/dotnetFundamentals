using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Loops
{
    [TestClass]
    public class LoopExamples
    {
        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 21;

            //1 starting point
            //2 while condition is true, keep looping
            //3 what happens after each loop
            //4 code execute in loop
            //for  //1           //2            //3
            for (int i = 0; i < studentCount; i++)
            {
                //4
                Console.WriteLine(i);
            }
        }

        [TestMethod]
        public void ForeachLoops()
        {
            string name = "Jane Doe";

            //1 collection being iterated over
            //2 name of the current iteration (index number?)
            //3 type in collection
            //4 in key word used to separate individual and collection
            //foreach  //3  //2  //4  //1
            foreach (char letter in name)
            {
                Console.WriteLine(letter);
            }

            List<string> names = new List<string>();
            names.Add("Jake");
            names.Add("Susan");
            names.Add("Tanner");
            names.Add("Lucy");
            foreach (string person in names)
            {
                Console.WriteLine(person);
                foreach (char e in person)
                {
                    Console.WriteLine(e);  //loop ina loop
                }
            }
        }

        [TestMethod]
        public void WhileLoops()
        {
            int total = 1;

            while (total != 10)
            {
                Console.WriteLine(total);
                total++;
            }

            while (true) //this will run indefinitely until we break it
            {
                Console.WriteLine(total);
                total++;
                if (total > 25)
                {
                    break; //here is the break!
                }
            }
        }
    }
}
