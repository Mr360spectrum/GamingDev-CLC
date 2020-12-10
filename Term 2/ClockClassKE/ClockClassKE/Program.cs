/*
Karter Ence
Clock Class
12/8/2020
Chapter 13.1
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockClassKE
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock myClock = new Clock();
            myClock.tellTime();

            Console.ReadKey();
        }
    }
}
