using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankExercises
{
    internal class ArrayManipulation
    {
        /*
         * Complete the 'arrayManipulation' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. 2D_INTEGER_ARRAY queries
         */
        public static long arrayManipulation(int n, List<List<int>> queries)
        {
            long[] output = new long[n + 1];
            long max = 0;
            long sum = 0;

            queries.ForEach(q =>
            {
                output[q[0] - 1] += q[2];
                output[q[1]] -= q[2];
            });

            foreach (long i in output)
            {
                sum += i;
                max = Math.Max(max, sum);
            }
            return max;
        }

        public static void Execute()
        {
            List<List<int>> queries = new List<List<int>>();

            /* Example 1:
                5 3
                1 2 100
                2 5 100
                3 4 100
                Salida: 200
            */
            /*int n = 5;
            queries.Add(new List<int>{ 1,2,100});   
            queries.Add(new List<int>{ 2,5,100});   
            queries.Add(new List<int>{ 3,4,100}); */

            /* Example 2:
                10 3
                1 5 3
                4 8 7
                6 9 1
                Salida: 10
            */
            /*int n = 10;
            queries.Add(new List<int> { 1, 5, 3 });
            queries.Add(new List<int> { 4, 8, 7 });
            queries.Add(new List<int> { 6, 9, 1 });*/

            /* Example 3:
                10 4
                2 6 8
                3 5 7
                1 8 1
                5 9 15
                Salida: 31    
            */
            /*int n = 10;
            queries.Add(new List<int> { 2, 6, 8 });
            queries.Add(new List<int> { 3, 5, 7 });
            queries.Add(new List<int> { 1, 8, 1 });
            queries.Add(new List<int> { 5, 9, 15 });*/

            /* Example 4:
                4 3
                2 3 603
                1 1 286
                4 4 882
                Salida: 882
             */
            int n = 4;
            queries.Add(new List<int> { 2, 3, 603 });
            queries.Add(new List<int> { 1, 1, 286 });
            queries.Add(new List<int> { 4, 4, 882 });

            long output = arrayManipulation(n, queries);

            Console.WriteLine();
            Console.WriteLine($"RESULT Array Manipulation: {output}");
        }
    }
}
