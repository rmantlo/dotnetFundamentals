using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    //is no access modifier on class, it defaults to internal
    public class Cookie
    {
        //properties, class lvl variables
        //get tells the property that it can be called and it's value called elsewhere? return avalue
        //set tells property that it can be set
        public int SugarAmount { get; set; }
        public int CookieBatchSize { get; set; }
        public bool Gooey { get; set; }

        public Cookie()
        {
            //2 with same name but diff params is called overloading
        }
        public Cookie(int sugarInGrams, bool gooey)
        {
            SugarAmount = sugarInGrams;
            Gooey = gooey;
        }
    }
}
