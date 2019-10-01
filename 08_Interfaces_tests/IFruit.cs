using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces_tests
{
    //Interface file type
    public interface IFruit
    {
        //interfaces cannot have access modifiers in them
        string Name { get; }
        bool IsPeeled { get; set; }

        //method
        string Peel();
    }

    public class Banana : IFruit
    {
        public string Name { get { return "Banana"; } }
        public bool IsPeeled { get; set; }
        public string Peel()
        {
            IsPeeled = true;
            return "Peeling in process";
        }
        //classes implementing interfaces must have all properties/methods from interface, but can have more of their own
        public int MyProperty { get; set; }
    }
    public class Kiwi : IFruit
    {
        public string Name { get { return "Kiwi"; } }

        public bool IsPeeled { get; set; }

        public string Peel()
        {
            IsPeeled = true;
            return "Peeling the Kiwi";
        }
    }
    public class Grape : IFruit
    {
        public string Name => "Grape";

        public bool IsPeeled { get; set; }

        public string Peel()
        {
            IsPeeled = true;
            return "A little weird, but you peeled the grapes";
        }
    }
}
