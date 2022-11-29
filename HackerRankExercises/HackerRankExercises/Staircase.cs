using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankExercises
{
    internal class Staircase
    {
        /*
         * Complete the 'staircase' function below.
         *
         * The function accepts INTEGER n as parameter.
         */
        public static void staircase(int n)
        {
            for (int i = 1; i <= n; i++) { 
                Console.WriteLine($"{new String(' ', n - i)}{new String('#', i)}");
            }
        }
        public static void Execute()
        {
            /* Example:
                n = 6

                     #
                    ##
                   ###
                  ####
                 #####
                ######
             */

            Console.WriteLine($"RESULT Staircase:");
            int n = 6;
            staircase(n);
        }
    }
}
