/*
Karter Ence
Average Score
Chapter 7.1
11/8/2020 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageScoreKE
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize scores
            int score1 = 250;
            int score2 = 350;
            int score3 = 120;
            int score4 = 500;
            int score5 = 250;

            //Add all scores together
            int total = score1 + score2 + score3 + score4 + score5;

            //Divide total by number of scores
            int avgScore = total / 5;

            //Output results
            Console.WriteLine("Your average score is: " + avgScore);
            Console.ReadKey();
        }
    }
}
