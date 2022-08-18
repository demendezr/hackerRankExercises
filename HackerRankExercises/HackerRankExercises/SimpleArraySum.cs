using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankExercises
{
    internal class SimpleArraySum
    {
        /*
         * Complete the 'simpleArraySum' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY ar as parameter.
         */
        public static int simpleArraySum(List<int> ar)
        {
            return ar.Sum();
        }

        public static void Execute()
        {
            // Example: 1 2 3 4 10 11
            List<int> list = new List<int>() { 1,2,3,4,10,11};
            int sum = simpleArraySum(list);
            Console.WriteLine($"RESULT Simple Array Sum: {sum}");
        }
    }
}
