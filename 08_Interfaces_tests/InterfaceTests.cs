using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_Interfaces_tests
{
    [TestClass]
    public class InterfaceTests
    {
        [TestMethod]
        public void CallingInterfaceMethods()
        {
            IFruit banana = new Banana();
            string output = banana.Peel();
            Console.WriteLine(output);
        }
        [TestMethod]
        public void InterfaceCollections()
        {
            List<IFruit> fruitList = new List<IFruit>
            {
                new Banana(),
                new Kiwi(),
                new Grape()
            };

            foreach (IFruit fruit in fruitList)
            {
                Console.WriteLine(fruit.Name);
                Console.WriteLine(fruit.Peel());
            }
        }
        [TestMethod]
        public void InterfacesInMethods()
        {
            IFruit kiwi = new Kiwi();
            string fruitName = GetFruitName(kiwi);
            Console.WriteLine(fruitName);
        }
        [TestMethod]
        public string GetFruitName(IFruit fruit)
        {
            return fruit.Name;
        }
        [TestMethod]
        public void TypeOfInstance()
        {
            var fruitSalad = new List<IFruit>
            {
                new Kiwi(),
                new Kiwi { IsPeeled = true },
                new Grape(),
                new Banana { IsPeeled = true },
                new Grape(),
                new Banana()
            };

            foreach(var fruit in fruitSalad)
            {
                //beautiful mix of if type examples
                if (fruit is Kiwi)
                {
                    if (fruit.IsPeeled)
                    {
                        Console.WriteLine("Is a peeled kiwi");
                    }
                    else
                    {
                        Console.WriteLine("Is a fuzzy kiwi");
                    }
                }
                else if (fruit.GetType() == typeof(Grape))
                {
                    Console.WriteLine("Grape!");
                }
                else if (fruit.IsPeeled)
                {
                    Console.WriteLine("Is a peeled bananananananana");
                }
                else
                {
                    Console.WriteLine("is a non openned banananana");
                }
            }
        }
    }
}
