using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Repository_Pattern_Console
{
    class Program
    {
        //this main method is our main entry point into our program
        static void Main(string[] args)
        {
            //call other file, to guide user to functionals
            ProgramUI program = new ProgramUI();
            program.Run();
        }
    }
}
