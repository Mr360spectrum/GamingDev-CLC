/*
Karter Ence
Favorite Class
9/16/2020
CH 2.4 
*/ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteClassKE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite class?"); //Prints question
            string favoriteClass = Console.ReadLine(); //Reads what the user enters
            Console.WriteLine("Your favorite class is " + favoriteClass + "."); //Print what the user entered

            Console.ReadKey(); //Wait for a key press
        }
    }
}
