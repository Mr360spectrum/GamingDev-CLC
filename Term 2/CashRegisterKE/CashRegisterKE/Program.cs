/*
Karter Ence
Cash Register
12/8/2020
Chapter 13.2
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegisterKE
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare a new CashRegister object
            CashRegister myRegister = new CashRegister();

            // add several dollar amounts
            myRegister.add(20.00);
            myRegister.add(15.50);
            myRegister.add(3.75);

            //Subtract several dollar amounts
            myRegister.subtract(5.00);
            myRegister.subtract(0.29);

            // display the current cash balance
            Console.WriteLine("The register has: $" + myRegister.report());
            Console.ReadKey();
        }

    }
     // CashRegister object definition  
   class CashRegister
   {
      // declare a property (class variable)
      double cash = 0.0;

    // define an add() method that takes one double "amount" parameter
    public void add(double amount)
        {
         Console.WriteLine("Adding $" + amount);
         cash += amount;
        }

    //Subtract money from cash
    public void subtract(double amount)
        {
            Console.WriteLine("Subtracting $" + amount);
            cash -= amount;
        }

    // define a report() method that returns one double value
    public double report()
        {
            return cash;
        }

    }
}
