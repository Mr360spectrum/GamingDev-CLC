/*
Karter Ence
Test Scores
9/28/2020
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestScoresKE
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare test scores as integers
            int testScore1 = 85;
            int testScore2 = 92;
            int testScore3 = 100;
            int testScore4 = 80;

            //Print test scores
            Console.WriteLine("Test score 1: " + testScore1);
            Console.WriteLine("Test score 2: " + testScore2);
            Console.WriteLine("Test score 3: " + testScore3);
            Console.WriteLine("Test score 4: " + testScore4);

            //Find the sum and assign it to the integer "sum"
            int sum = testScore1 + testScore2 + testScore3 + testScore4;
            //Find the average and assign it to the integer "average"
            double average = sum / 4;
            Console.WriteLine("AVERAGE SCORE = " + average);

            //Wait for input
            Console.ReadKey();
        }
    }
}
