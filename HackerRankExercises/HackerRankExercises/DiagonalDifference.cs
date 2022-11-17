using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankExercises
{
    internal class DiagonalDifference
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            int n = arr[0].Count;
            int result = 0;
            int firstCol = 0;
            int secondCol = n - 1;

            for(int i = 0; i < n; i++) {
                result += arr[i][firstCol] - arr[i][secondCol];
                firstCol++;
                secondCol--;
            }

            return result > 0 ? result: result * -1;
        }

        public static void Execute()
        {
            /* Example:
                n = 3

                11 2  4  4  5
                4  5  6  4  5
                10 8 -12 4  5             
                10 8 -12 4  5 
                4  5  6  4  5       
            
                first = 11 + 5 - 12 + 4 + 5 = 13
                second = 5 + 4 - 12 + 8 + 4 = 9
                result = |13 - 9| = 4
             */
            List<List<int>> arr = new List<List<int>>()
            {
                new List<int>() { 11,2,4,4,5},
                new List<int>() { 4,5,6,4,5},
                new List<int>() { 10,8,-12,4,5},
                new List<int>() { 10,8,-12,4,5},
                new List<int>() { 4,5,6,4,5}
            };  
            int result = diagonalDifference(arr);   
            Console.WriteLine($"RESULT Diagonal Difference: {result}");
        }
    }
}
