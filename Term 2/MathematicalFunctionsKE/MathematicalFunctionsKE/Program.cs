using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicalFunctionsKE
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 3 + 5;
            int num2 = 3 - 5;
            int num3 = 6 / (int)3.0;
            int num4 = 5 * 5;
            int num5 = 7 % 4;
            Console.WriteLine(Math.Sqrt(2910));
            Console.WriteLine(Math.Pow(32042340, 40));
            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.E);
            Console.WriteLine(Math.Round(3234.834234234234321234));
            Console.WriteLine(Math.Abs(-348937248234));
            Console.WriteLine(Math.Ceiling(55.1));
            Console.WriteLine(Math.Floor(55.1));

            Console.WriteLine("\n" + num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);
            Console.WriteLine(num5);
            Console.ReadKey();
        }
    }
}
