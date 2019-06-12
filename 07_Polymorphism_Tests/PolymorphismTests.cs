using System;
using System.Collections.Generic;
using _07_Polymorphism_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_Polymorphism_Tests
{
    [TestClass]
    public class PolymorphismTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Animal firstAnimal = new Animal();
            firstAnimal.LegCount = 4; //cannot access sloth props, only its own


            Sloth sloth = new Sloth();
            sloth.LegCount = 4; //CAN access animal props and its own
            bool value = sloth.IsSlow; //cant declare, must set to variable as it already has a unchanging value

            Megatherium giantSloth = new Megatherium();
            giantSloth.HasTail = false;
            giantSloth.IsExtinct = true;

            Cat firstCat = new Cat();
            firstCat.MakeSound(); //Meow

            Liger liger = new Liger();
            liger.MakeSound(); //hover shows Liger.MakeSound only, not Cat.MakeSound
            Cheetah chee = new Cheetah();
            chee.MakeSound(); //Purr.
            //chee is purr here, but not below as a Cat type

            List<Cat> catList = new List<Cat>(); //works with Animal too, but not Sloths
            catList.Add(firstCat);
            catList.Add(liger);
            catList.Add(chee); //works, happy

            List<Animal> animalList = new List<Animal>();//works with cats, and sloths
            animalList.Add(firstCat);
            animalList.Add(liger);
            animalList.Add(chee);
            animalList.Add(giantSloth);

            foreach (Animal animal in animalList)
            {
                //cant call MakeSound() because not all animals have MakeSound
                //can only call Animal properties, not children properties
            }

            //foreach(Cat animal in animalList) //doesnt work, gets stuck at non-Cats
            //{
            //    animal.MakeSound();
            //}
            foreach (Animal animal in animalList)
            {

                //if(animal.GetType() == typeof(Cat)) //Must be Cat type! Liger and Cheetah types wont count as Cat! and skips
                if (animal is Cat) //works with Cat and children of Cat (ie Liger and Cheetah) but not Sloth etc
                {
                    //casting yay!
                    Cat cat = (Cat)animal;
                    //cant do above if type isnt already Cat (ex. sloths)
                    //if using (animal is Cat), casting still retains Liger as Liger, etc
                    cat.MakeSound(); //so cat meows and liger still roars
                    //Cheetah didnt purr, because it called original MakeSound, not new MakeSound
                    //new made method unrelated to original MakeSound;
                }
            }
        }
    }
}
