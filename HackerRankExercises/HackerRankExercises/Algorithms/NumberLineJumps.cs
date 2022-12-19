using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankExercises.Algorithms
{
    internal class NumberLineJumps
    {
        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            for (int i = 0; i < 10000; i++)
            {
                x1 += v1;
                x2 += v2;
                if (x1 == x2) return "YES";
            }

            return "NO";
        }

        public static void Execute()
        {
            Console.WriteLine($"Number Line Jumps result: {kangaroo(0, 3, 4, 2)}");
        }
    }
}
