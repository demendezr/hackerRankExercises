using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankExercises.Arrays
{
    internal class LeftRotation
    {
         /* Complete the 'rotateLeft' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER d
         *  2. INTEGER_ARRAY arr
         */

        public static List<int> rotateLeft(int d, List<int> arr)
        {
            // You can iterate the array to rotate it
            /* for(int i = 0; i < d; i++)
            {
                var temp = arr[0];
                for (int j = 0; j < arr.Count; j++)
                {
                    if ((j + 1) < arr.Count)
                    {
                        arr[j] = arr[j + 1];
                    }
                }
                arr[arr.Count - 1] = temp; 
            }

            return arr;*/

            //Or simply you can use Linq to rotate the array
            return arr.Skip(d).Concat(arr.Take(d)).ToList();
        }

        public static void Execute()
        {
            /* Example:
                d = 4
                1 2 3 4 5

                Rotations: 2 3 4 5 1   3 4 5 1 2   4 5 1 2 3   5 1 2 3 4
                Result: 5 1 2 3 4
             */

            const int numberOfRotations = 4;
            List<int> arrayToRotate = new List<int>() { 1, 2, 3, 4, 5 };

            var result = rotateLeft(numberOfRotations, arrayToRotate);
            Console.WriteLine($"RESULT Left Rotation: {String.Join(" ", result)}");
        }
    }
}
