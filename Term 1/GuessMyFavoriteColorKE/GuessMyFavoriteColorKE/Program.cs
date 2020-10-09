/*
Karter Ence
Guess my Favorite Color
10/9/2020
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyFavoriteColorKE
{
    class Program
    {
        static void Main(string[] args)
        {
            String answer = "";

            //Start a do-while loop
            do
            {
                Console.WriteLine("What is my favorite color?");
                answer = Console.ReadLine();
            }
            while (answer != "blue"); //Continue while answer is not equal to "blue"

            Console.WriteLine("That's right!");
            Console.ReadKey();
        }
    }
}
