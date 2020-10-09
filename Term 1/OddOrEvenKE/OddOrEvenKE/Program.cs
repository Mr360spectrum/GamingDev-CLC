/*
Karter Ence
Odd or Even
10/9/2020
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEvenKE
{
    class Program
    {
        static void Main(string[] args)
        {
            // asks user for number
            Console.Write("Enter your number: ");

            // get text from user and convert to integer
            int number = int.Parse(Console.ReadLine());

            // modulus symbol % returns the remainder
            int remainder = number % 2;

            // if remainder is equal to 0
            if (remainder == 0)
            {
               // display even message
               Console.WriteLine(number + " is Even");
            }
            else
            {
               // display odd message
               Console.WriteLine(number + " is Odd");
            }
            Console.ReadKey();
        }
    }
}
