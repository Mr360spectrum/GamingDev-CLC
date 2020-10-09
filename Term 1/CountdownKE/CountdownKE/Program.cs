/*
Karter Ence
Countdown
10/9/2020
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountdownKE
{
    class Program
    {
        static void Main(string[] args)
        {
            int i; //Declare index
            for (i = 0; i < 10; i++) //i equals 0; run until i equals or is greater than 10; add 1 to i when repeated
            {
                Console.WriteLine(10 - i);
            }
            Console.WriteLine("Blastoff!");
            Console.ReadKey();
        }
    }
}
