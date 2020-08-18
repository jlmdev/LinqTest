using System;
using System.Linq;
using System.Collections.Generic;

namespace LinqTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Here is our original array
            var scores = new List<int>() { 42, 100, 98, 15 };

            // Make a new list to store the results
            var newScores = scores.Select(score => score * 2);

            // Print out the scores comma separated
            Console.WriteLine(String.Join(',', newScores));
        }
    }
}
