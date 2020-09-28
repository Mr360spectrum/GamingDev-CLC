/*
Karter Ence
Chapter 4 Example
9/28/2020
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4ExampleKE
{
    class Program
    {
        enum FishType
        {
            TROUT,
            BASS,
            FLOUNDER,
            CARP,
            TUNA
        }
        static void Main(string[] args)
        {
            FishType myFish = FishType.TROUT;
            Console.WriteLine(myFish);

            //Whole number data types
            byte byteVar; //1 byte (num up to 255)
            sbyte sbyteVar; //1 byte (num from -128 to 127)
            short shortVar; //2 bytes (num from -32,768 to 32,767)
            int intVar; //4 bytes (num from -2,147,483,648 to 2,147,483,647)
            uint uintVar; //4 bytes (num up to 4,294,967,295)
            long longVar; //8 bytes (num from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807)

            byteVar = 17;
            shortVar = 100;
            short answer = (short)(byteVar + shortVar);
            Console.WriteLine(answer);

            //Fractional numbers

            float floatVar; //4 bytes (-3.4 x 10^38 to +3.4 x 10^38 (with 7 significant digits)
            double doubleVar; //8 bytes (-1.7 x 10^308 to +1.7 x 10^308 (with 15-16 significant digits)
            decimal decimalVar; //16 bytes (-7.9 x 10^28 to 7.9 x 10^28 (with 28-29 significant digits)

            floatVar = 1.02f;
            decimalVar = 1.02m;
            doubleVar = 1.69;

            const double PI = 3.1415926535897932384626;

            int test = (int)doubleVar;
            Console.WriteLine(test);

            //Non-numeric data

            char charVar; //2 bytes (One text character)
            bool boolVar; //1 byte (true or false)

            charVar = 'h';

            //int myInt1;
            //System.Int32 myInt2;
            //Console.WriteLine(System.Int32.MaxValue);

            Console.ReadKey();
        }
    }
}
