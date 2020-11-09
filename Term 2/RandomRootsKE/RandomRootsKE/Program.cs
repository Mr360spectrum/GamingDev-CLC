/*
Karter Ence
Random Roots
Chapter 7.2
11/8/2020
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomRootsKE
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create random object and store in local variable
            Random random = new Random();

            Console.WriteLine("Press a key to continue.");

            //Create a for loop that will iterate 10 times
            for (int i = 0; i < 10; i++)
            {
                //Create a random number between 0 and 25, inclusive
                int number = random.Next(0, 26);

                //Calculate the square root of the number
                double sqrt = Math.Sqrt(number);

                Console.WriteLine("The square root of " + number + " is " + sqrt);
                Console.ReadKey();
            }
        }
    }
}
