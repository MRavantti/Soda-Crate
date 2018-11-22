using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaCrate
{
    class SodaCrateProgram
    {
        static void Main(string[] args)
        {
            //main program to with welcome text and call command for the name and run method.
            Console.WriteLine("Welcome to the most epic soda-crate simulator in the galaxy! What is your name?");
            SodaCrate.Name = Console.ReadLine();
            SodaCrate.MainMenu();
        }
    }
}