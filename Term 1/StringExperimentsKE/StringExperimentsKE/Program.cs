/*
Karter Ence
String Experiments
9/30/2020
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExperimentsKE
{
    class Program
    {
        static void Main(string[] args)
        {
            string test1 = "Work hard. Dream Big.";
            string test2 = "case";
            string test3 = "CASE";
            string test4 = "";

            // display the string length
            Console.WriteLine(test1.Length);

            // string concatenation 
            Console.WriteLine(test1 + " Laugh Often!");

            // string equality, with and without case-sensitivity
            Console.WriteLine(test2.Equals(test3));
            Console.WriteLine(test2.Equals(test3, StringComparison.OrdinalIgnoreCase));

            // accessing individual characters
            Console.WriteLine(test1[0]); // first character
            Console.WriteLine(test1[5]); // sixth character

            // test for empty strings
            Console.WriteLine(String.IsNullOrEmpty(test1));
            Console.WriteLine(String.IsNullOrEmpty(test4));

            //Wait for input
            Console.ReadKey();
        }
    }
}
