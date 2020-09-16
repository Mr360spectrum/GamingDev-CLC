/*
Karter Ence
Echo Activity
9/16/2020
CH 2
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Type in your name: ");
            string name = Console.ReadLine(); //Read whatever the user enters

            Console.WriteLine("Welcome, " + name + "."); //Concatenate strings

            Console.Write("What is your social security number? ");
            string social = Console.ReadLine();

            Console.Write("What is your mother's maiden name? ");
            string maidenName = Console.ReadLine();

            Console.WriteLine("Where did you meet your significant other? ");
            Console.ReadKey(); //Move on as soon as a single key is pressed
            Console.WriteLine("Oh, right. You don't have one. ");

            Console.Write("What is your driver's license number? ");
            string driver = Console.ReadLine();

            Console.Write("How much money do you make in a year? ");
            string income = Console.ReadLine();

            Console.Write("What is your mom's phone number? ");
            string phoneNumber = Console.ReadLine();

            Console.WriteLine("Here's the info I got:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("SSN: " + social);
            Console.WriteLine("Mother's maiden name: " + maidenName);
            Console.WriteLine("Location of first meeting with significant other: N/A");
            Console.WriteLine("Driver's license number: " + driver);
            Console.WriteLine("Yearly income: " + income);
            Console.WriteLine("Mom's phone number: " + phoneNumber);
            Console.WriteLine("\nThank you for your time!");


            //string myFirstVariable; //Declaration statement
            //myFirstVariable = "Welcome"; //Assignment statement

            //string theSecondOne = "Welcome II"; //Declaration and Assignment statements in one

            //Console.WriteLine(myFirstVariable + ", " + name + "."); //Using myFirstVariable in a console print statement

            Console.ReadKey(); //Wait for a key to be pressed
        }
    }
}
