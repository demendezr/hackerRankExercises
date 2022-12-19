using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankExercises.Algorithms
{
    internal class AppleAndOrange
    {
        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int applesCounter = 0;
            int orangesCounter = 0;

            for (int i = 0; i < apples.Count; i++)
            {
                int number = a + apples[i];
                if (number >= s && number <= t) applesCounter++;
            }

            for (int i = 0; i < oranges.Count; i++)
            {
                int number = b + oranges[i];
                if (number >= s && number <= t) orangesCounter++;
            }

            Console.WriteLine(applesCounter);
            Console.WriteLine(orangesCounter);
        }

        public static void Execute()
        {
            List<int> apples = new List<int>() { -2, 2, 1 };
            List<int> oranges = new List<int>() { 5, -6 };

            Console.WriteLine("Result of Apple and Orange: ");
            countApplesAndOranges(7,11,5,15,apples, oranges);
        }
    }
}
