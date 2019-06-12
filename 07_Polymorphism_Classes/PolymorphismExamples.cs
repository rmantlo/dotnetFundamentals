using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Polymorphism_Classes
{
    //get polymorphism through inheritance

    //renaming class! ahh (will have multiple classes)
    public class Animal
    {
        public int EyeCount { get; set; }
        public int LegCount { get; set; }
        public double WeightInPounds { get; set; }
        public bool HasTail { get; set; }
        public bool HasFur { get; set; }
        public Animal() { Console.WriteLine("Animal Constructor"); } //constructor
        public Animal(int eyeCount, int legCount, double weightInPounds, bool hasTail, bool hasFur)
        {
            EyeCount = eyeCount;
            LegCount = legCount;
            WeightInPounds = weightInPounds;
            HasTail = hasTail;
            HasFur = hasFur;
            Console.WriteLine("Animal Constructor");
        }
    }
    public class Sloth : Animal //can only have one parent class/base class
    {
        public Sloth()
        {
            Console.WriteLine("Sloth Constructor");
        }
        public Sloth(int eyeCount, int legCount, double weightInPounds, bool hasTail, bool hasFur) : base(eyeCount,legCount,weightInPounds,hasTail,hasFur)
        {
            Console.WriteLine("Sloth Constructor");
        }
        public bool IsSlow
        {
            get { return true; }
        }
        //get finds the value and returns it
        //set finds the value and sets it to the prop
        //delete set, so can only get value,  so must set value manually in prop's get
        //makes value unchangable

    }
    public class Megatherium : Sloth
    {
        public bool IsExtinct { get; set; }
    }
    public class Cat : Animal
    {
        public Cat()
        {
            Console.WriteLine("Cat Constructor");
        }
        public Cat(int eyeCount, int legCount, double weightInPounds, bool hasTail, bool hasFur, double clawLength) : base(eyeCount, legCount, weightInPounds, hasTail, hasFur)
        {
            ClawLengthInInches = clawLength;
        }
        public double ClawLengthInInches { get; set; }
        //virtual says this method isnt set in stone, virtual properties and methods can be overridden
        public virtual void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
    public class Liger : Cat
    {
        //hover over MakeSound w/ green squiggs (with override gone)
        //overrides cat.makesound, and only shows liger.makesound
        //allows for use of same commands with different results
        public override void MakeSound()
        {
            base.MakeSound(); //refers to original Cat MakeSound method (Meow)
            Console.WriteLine("Roar");
        }
    }
    public class Cheetah : Cat
    {
        //cheetahs can meow
        //new instead of override
        //new makes it unrelated to other MakeSound method
        public new void MakeSound()
        {
            base.MakeSound(); //refers to original Cat MakeSound method
            //base points only one lvl up
            Console.WriteLine("Purrr");
        }
    }
    
}
