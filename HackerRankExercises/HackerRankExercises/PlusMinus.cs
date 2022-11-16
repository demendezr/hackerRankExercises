using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankExercises
{
    internal class PlusMinus
    {
        public static void plusMinus(List<int> arr)
        {
            decimal positives = arr.FindAll(n => n > 0).Count();
            decimal negatives = arr.FindAll(n => n < 0).Count();
            decimal zeros = arr.FindAll(n => n == 0).Count();

            int n = arr.Count;            

            Console.WriteLine(Math.Round(positives / n, 6).ToString("0.000000"));
            Console.WriteLine(Math.Round(negatives / n, 6).ToString("0.000000"));
            Console.WriteLine(Math.Round(zeros / n, 6).ToString("0.000000"));
        }
        public static void Execute()
        {
            /* Example:
                n = 6
                -4 3 -9 0 4 1               
             */
            List<int> arr = new List<int>() { -4, 3, -9, 0, 4, 1 };
            Console.WriteLine($"RESULT Plus Minus:");
            plusMinus(arr);            
        }
    }
}
