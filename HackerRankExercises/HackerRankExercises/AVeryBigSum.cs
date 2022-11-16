using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankExercises
{
    internal class AVeryBigSum
    {
        public static long aVeryBigSum(List<long> ar)
        {
            return ar.Sum();
        }

        public static void Execute()
        {
            /* Example:
                n = 5
                1000000001 1000000002 1000000003 1000000004 1000000005                
             */
            List<long> ar = new List<long>() { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005};
            long result = aVeryBigSum(ar);
            Console.WriteLine($"RESULT A Very Big Sum: {result}");
        }
    }
}
