using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankExercises
{
    internal class CompareTheTriplets
    {
        /*
         * Complete the 'compareTriplets' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY a
         *  2. INTEGER_ARRAY b
         */
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> result = new List<int>();
            int aliceScore = 0;
            int bobScore = 0;

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i]) aliceScore++;
                else if (a[i] < b[i]) bobScore++;
            }

            result.Add(aliceScore);
            result.Add(bobScore);

            return result;
        }

        public static void Execute()
        {
            /* Example:
                17 28 30
                99 16 8

                Output: 2 1
             */
            List<int> a = new List<int>() { 17, 28, 30};
            List<int> b = new List<int>() { 99, 16, 8};
            List<int> result = compareTriplets(a, b);
            Console.WriteLine($"RESULT Compare the Triplets: {result[0]} {result[1]}");
        }
    }
}
