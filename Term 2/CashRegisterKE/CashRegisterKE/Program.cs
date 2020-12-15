/*
Karter Ence
Cash Register
12/14/2020
Chapter 13.5
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegisterKE
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // declare a new CashRegister object
            CashRegister myRegister = new CashRegister(0.06);

            // add several dollar amounts
            myRegister.add(20.00);
            myRegister.add(15.50);
            myRegister.add(3.75);


            CashRegister.setCurrencyType("EURO");
            Console.WriteLine("The current currency type: " + CashRegister.getCurrencyType());

            // display the current cash balance and tax info
            Console.WriteLine("The register has: " + myRegister.report().ToString("C"));
            double taxCollected = myRegister.getSalesTax() * myRegister.report();
            Console.WriteLine("Sales tax rate: " + myRegister.getSalesTax().ToString("P"));
            Console.WriteLine("Sales tax collected: " + taxCollected.ToString("C"));

            Console.ReadKey();
        }
    }
    // CashRegister object definition
    class CashRegister
    {
        // declare a property (class variable)
        public double cash = 0.0;
        private double salesTax;
        private static string currencyType = "USD";

        // define a public constructor
        public CashRegister(double taxValue)
        {
            salesTax = taxValue;
        }

        // define an add() method that takes one double "amount" parameter
        public void add(double amount)
        {
            Console.WriteLine("Adding $" + amount);
            cash += amount;
        }

        // define a report() method that returns one double value
        public double report()
        {
            return cash;
        }

        // public "getter" method
        public double getSalesTax()
        {
            return salesTax;
        }

        // public "setter" method
        public void setSalesTax(double newTax)
        {
            if (newTax >= 0) // safety check!
            {
                salesTax = newTax;
            }
        }

        // a "setter" method for the static property
        static public void setCurrencyType(string newCurrency)
        {
            currencyType = newCurrency;
        }

        // a "getter" method for the static property
        static public string getCurrencyType()
        {
            return currencyType;
        }
    }
}
