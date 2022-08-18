using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblem
{
    internal class Operations
    {
        public static int[,] Calculate(int[] input)
        {
            int[,] weights = new int[input.Length, 2];
            int sumDigits = 0;
            int j = 0;

            Console.WriteLine("ARRAY OF NUMBERS WITH THEIR WEIGHTS: ");
            // Weights
            foreach (var item in input)
            {
                int number = item;
                while (number > 0)
                {
                    var digit = number % 10;
                    number /= 10;
                    sumDigits += digit;
                }
                weights[j, 0] = sumDigits;
                weights[j, 1] = item;
                Console.WriteLine($"Weight: {weights[j, 0]}, Number: {weights[j, 1]}");
                sumDigits = 0;
                j++;
            }

            // Order
            int tmpWeight;
            int tmpNumber;
            for (int i = 0; i < input.Length; i++)
            {
                for (int k = i; k < input.Length; k++)
                {
                    if (weights[i, 0] > weights[k, 0])
                    {
                        tmpWeight = weights[i, 0];
                        tmpNumber = weights[i, 1];
                        weights[i, 0] = weights[k, 0];
                        weights[i, 1] = weights[k, 1];
                        weights[k, 0] = tmpWeight;
                        weights[k, 1] = tmpNumber;
                    }
                }
            }

            return weights;
        }
    }
}
