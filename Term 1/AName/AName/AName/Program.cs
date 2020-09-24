/*
Karter Ence
A Name
9/24/2020
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AName
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Bobolariadociousnapjerdane"; //Declare a variable (also, the s is silent in the name)
            Console.WriteLine("Hello " + name);
            Console.WriteLine("What is your last name? ");
            string lastName = Console.ReadLine(); //Get a last name from the user
            Console.WriteLine("Welcome " + name + " " + lastName + "."); //Concatenate strings
            Console.ReadKey(); //Wait for input
        }
    }
}
