/*
Karter Ence
Conditional Statements
9/30/2020
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsKE
{
    class Program
    {
        static void Main(string[] args)
        {
            //Compare two numbers
            //Console.WriteLine(1 < 2); //Less than
            //Console.WriteLine(1 > 2);
            //Console.WriteLine(1 < 1);

            //Console.WriteLine(1 <= 2); //Less than or equal to
            //Console.WriteLine(1 >= 2);
            //Console.WriteLine(1 <= 1);

            //Console.WriteLine(1 == 1);
            //Console.WriteLine(1 != 1); //NOT operator
            
            bool result1 = 52 > 40;
            bool result2 = -3.1415926535897932284626 < 1.732;
            String name = "";
            
            if (String.IsNullOrEmpty(name))
            {
                Console.WriteLine("Correct i thinko");
            }
            else
            {
                Console.WriteLine("no");
            }

            //Wait for input
            Console.ReadKey();
        }
    }
}
