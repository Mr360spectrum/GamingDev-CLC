/*
Karter Ence
Reference Data
9/30/2020 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceDataKE
{
    class Contact
    {
        public String name;
        public String number;
        public String homeAddress;
        public String workAddress;
        public String email;
        public byte age;


        public void Display() //Create a method that will print all info of the given object
        {
            Console.WriteLine(name);
            Console.WriteLine(number);
            Console.WriteLine(homeAddress);
            Console.WriteLine(workAddress);
            Console.WriteLine(email);
            Console.WriteLine(age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Contact karter = new Contact(); //Create a new Contact object
            //Contact bobolariadociousnapjerdane = new Contact(); //The 'S' is silent!
            //Contact ananamolalia = new Contact();

            ////Assign values to the Contact object
            //karter.name = "Karter";
            //karter.number = "0123456789";
            //karter.homeAddress = "1 House Lane";
            //karter.workAddress = "123 School Boulevard";
            //karter.age = 17;
            //karter.email = "email@address.com";

            ////Invoke the Display method on the given Contact object
            //karter.Display()

            //String myString = "Strings must be wrapped in double quotes.";
            //String myString2 = "strings must be wrapped in double quotes.";

            ////The SUPERIOR version
            //Console.WriteLine(myString.Equals(myString2, StringComparison.OrdinalIgnoreCase)); //Check to see if two strings are the same
            //Console.WriteLine(myString == myString); //This works too, just... don't do it, I guess.

            //Create the alphabet
            String Letters = "       abcdefghijklmnopqrstuvwxyz          ";
            String Letters2 = "abcdefghijklmnopqrstuvwxyz";

            //Console.WriteLine(Letters.Equals(Letters2));

            //Console.WriteLine(Letters.Length);
            //Letters = Letters.Trim();
            //Console.WriteLine(Letters.Length);

            //Letters = Letters.Replace("e", "z");
            //Console.WriteLine(Letters);

            ////Grab the characters from the starting index all the way up until the requested number of characters is returned
            //Console.WriteLine(Letters.Substring(0,3));

            //int kInd = Letters.IndexOf("k");
            //Console.WriteLine(kInd);

            //Console.WriteLine(Letters.Contains("r"));

            //char k = Letters[10]; //Find the letters at the proper index
            //char a = Letters[0];
            //char r = Letters[17];
            //char t = Letters[19];
            //char e = Letters[4];
            //Console.Write(k); //Print the letter, but leave the text cursor where it is
            //Console.Write(a);
            //Console.Write(r);
            //Console.Write(t);
            //Console.Write(e);
            //Console.Write(r);

            String empty = "";
            String nullString = null;

            //Wait for input
            Console.ReadKey();
        }
    }
}
