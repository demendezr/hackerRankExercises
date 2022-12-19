using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankExercises.Algorithms
{
    internal class BetweenTwoSets
    {
        public static int getTotalX(List<int> a, List<int> b)
        {
            int lastA = a.Last();
            int firstB = b.First();
            int counter = 0;

            int bandera = 1;
            List<int> factors = new List<int>();
            while(lastA < firstB)
            {
                lastA = a.Last() * bandera;
                factors.Add(lastA);
                bandera++;
            }

            for(int i = 0; i < factors.Count; i++)
            {
                bool existsValue = true;

                for(int k = 0; k < a.Count; k++)
                {
                    if (factors[i] % a[k] != 0)
                    {
                        existsValue = false;
                        break;
                    }
                }

                if (existsValue)
                {
                    for (int j = 0; j < b.Count; j++)
                    {
                        if (b[j] % factors[i] != 0)
                        {
                            existsValue = false;
                            break;
                        }
                    }
                }
                
                if (existsValue) counter++;
            }

            return counter;
        }

        public static void Execute()
        {
            List<int> a = new List<int>() { 3, 4 };
            List<int> b = new List<int>() { 24, 48 };

            Console.WriteLine($"Between Two Set result: {getTotalX(a,b)}");
        }
    }
}
