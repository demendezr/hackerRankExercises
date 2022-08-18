using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankExercises
{
    internal class MatrixLayerRotation
    {
        /* Complete the 'matrixRotation' function below.
        *
        * The function accepts following parameters:
        *  1. 2D_INTEGER_ARRAY matrix
        *  2. INTEGER r
        */
        /*
           1  2  3  4      2  3  4 10    3  4 10 16    4 10 16 22
           7  8  9 10      1  9 15 16    2 15 21 22    3 21 20 28
           13 14 15 16 ->  7  8 21 22 -> 1  9 20 28 -> 2 15 14 27 ->
           19 20 21 22    13 14 20 28    7  8 14 27    1  9  8 26
           25 26 27 28    19 25 26 27    13 19 25 26   7 13 19 25

           10 16 22 28    16 22 28 27    22 28 27 26    28 27 26 25
            4 20 14 27    10 14  8 26    16  8  9 25    22  9 15 19
            3 21  8 26 ->  4 20  9 25 -> 10 14 15 19 -> 16  8 21 13
            2 15  9 25     3 21 15 19     4 20 21 13    10 14 20  7
            1  7 13 19     2  1  7 13     3  2  1  7     4  3  2  1
         */
        public static void matrixRotation(List<List<int>> matrix, int r)
        {
            int m = matrix.Count; // rows 5
            int n = matrix[0].Count; // cols 4

            int layers = Math.Min(m, n) / 2;

            for (int i = 0; i < layers; i++)
            {
                while (r > 0)
                {
                    //clockwise
                    for (int j = i; j < n - i - 1; j++)
                    {
                        int temp = matrix[i][j];
                        matrix[i][j] = matrix[i][j + 1];
                        matrix[i][j + 1] = temp;
                    }
                    // Rotate right column
                    for (int j = i; j < m - i - 1; j++)
                    {
                        int temp = matrix[j][n - i - 1];
                        matrix[j][n - i - 1] = matrix[j + 1][n - i - 1];
                        matrix[j + 1][n - i - 1] = temp;
                    }
                    // Rotate bottom row
                    for (int j = n - i - 1; j > i; j--)
                    {
                        int temp = matrix[m - i - 1][j];
                        matrix[m - i - 1][j] = matrix[m - i - 1][j - 1];
                        matrix[m - i - 1][j - 1] = temp;
                    }
                    // Rotate left column
                    for (int j = m - i - 1; j > i + 1; j--)
                    {
                        int temp = matrix[j][i];
                        matrix[j][i] = matrix[j - 1][i];
                        matrix[j - 1][i] = temp;
                    }

                    r--;
                }
            }

            // Output final matrix
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matrix[i][j]} ");
                }
                Console.WriteLine("");
            }
        }

        public static void Execute()
        {
            /* Example:
                5 4 7
                1 2 3 4
                7 8 9 10
                13 14 15 16
                19 20 21 22
                25 26 27 28
             */
            int r = 7;
            List<List<int>> matrix = new List<List<int>>()
            {
                new List<int>(){ 1,2,3,4 },
                new List<int>(){ 7,8,9,10 },
                new List<int>(){ 13,14,15,16 },
                new List<int>(){ 19,20,21,22 },
                new List<int>(){ 25,26,27,28 },
            };

            Console.WriteLine($"RESULT Matrix Layer Rotation:");
            matrixRotation(matrix, r);
        }
    }
}
