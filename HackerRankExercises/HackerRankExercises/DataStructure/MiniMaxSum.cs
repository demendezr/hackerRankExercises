using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankExercises.Arrays
{
    internal class MiniMaxSum
    {
        /*
         * Complete the 'miniMaxSum' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */
        public static void miniMaxSum(List<int> arr)
        {
            arr.Sort();
            Int64 minSum = 0;
            Int64 maxSum = 0;

            for(int i=0;i < arr.Count; i++) { 
                if (i > 0) maxSum += arr[i];
                if(i < arr.Count - 1) minSum += arr[i];
            }
            Console.WriteLine($"{minSum} {maxSum}");
        }

        public static void Execute()
        {
            /* Example:
                1 3 5 7 9

                Minimun Sum: 1+3+5+7 = 16
                Max Sum: 3+5+7+9 = 24
                Result: 16 24
             */

            List<int> arr = new List<int>()
            {
                1, 3, 5, 7, 9
                //5, 5, 5, 5, 5
            };

            Console.WriteLine($"RESULT Mini-Max Sum:");
            miniMaxSum(arr);
        }
    }
}
