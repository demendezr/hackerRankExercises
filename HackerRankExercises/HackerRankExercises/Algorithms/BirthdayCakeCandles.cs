using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankExercises.Algorithms
{
    internal class BirthdayCakeCandles
    {
        /*
         * Complete the 'birthdayCakeCandles' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY candles as parameter.
         */

        public static int birthdayCakeCandles(List<int> candles)
        {
            int max = candles.Max();
            return candles.Where(x => x == max).Select(x => x).Count();
        }

        public static void Execute()
        {
            List<int> candles = new List<int>()
            {
                4,4,1,3
            };
            Console.WriteLine("Birthday Cake Candles result: ");
            Console.WriteLine(birthdayCakeCandles(candles));
        }
    }
}
