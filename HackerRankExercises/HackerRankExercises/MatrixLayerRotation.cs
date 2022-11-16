using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
            Stopwatch stopwatchMain = new Stopwatch();
            Stopwatch stopwatch = new Stopwatch();
            Stopwatch stopwatch1 = new Stopwatch();
            Stopwatch stopwatch2 = new Stopwatch();
            Stopwatch stopwatch3 = new Stopwatch();
            Stopwatch stopwatch4 = new Stopwatch();
            Stopwatch stopwatch5 = new Stopwatch();

            stopwatchMain.Start();   


            stopwatch.Start();

            int m = matrix.Count; // rows 5
            int n = matrix[0].Count; // cols 4

            int layers = Math.Min(m, n) / 2;
            stopwatch.Stop();
            

            for (int i = 0; i < layers; i++)
            {
                int colNumber = n - i - 1;
                int rowNumber = m - i - 1;

                for (int rotations = r; rotations > 0; rotations--)
                {
                    stopwatch1.Start();
                    //clockwise
                    List<int> row = matrix[i];
                    for (int j = i; j < colNumber; j++)
                    {
                        int temp = row[j];
                        row[j] = row[j + 1];
                        row[j + 1] = temp;                        
                    }
                    matrix[i] = row;
                    stopwatch1.Stop();
                    

                    stopwatch2.Start();
                    // Rotate right column
                    for (int j = i; j < rowNumber; j++)
                    {
                        int temp = matrix[j][colNumber];
                        matrix[j][colNumber] = matrix[j + 1][colNumber];
                        matrix[j + 1][colNumber] = temp;
                    }
                    stopwatch2.Stop();
                    

                    stopwatch3.Start();
                    // Rotate bottom row
                    row = matrix[rowNumber];
                    for (int j = colNumber; j > i; j--)
                    {
                        int temp = row[j];
                        row[j] = row[j - 1];
                        row[j - 1] = temp;
                    }
                    matrix[rowNumber] = row;
                    stopwatch3.Stop();
                    

                    stopwatch4.Start();
                    // Rotate left column
                    for (int j = rowNumber; j > i + 1; j--)
                    {
                        int temp = matrix[j][i];
                        matrix[j][i] = matrix[j - 1][i];
                        matrix[j - 1][i] = temp;
                    }
                    stopwatch4.Stop();                    
                }
            }

            stopwatch5.Start();
            // Output final matrix
            foreach(var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row.ToArray())); 
            }
            stopwatch5.Stop();

            stopwatchMain.Stop();

            Console.WriteLine("Get layers: {0} ms", stopwatch.ElapsedMilliseconds);
            Console.WriteLine("Clockwise: {0} ms", stopwatch1.ElapsedMilliseconds);
            Console.WriteLine("Rotate right column: {0} ms", stopwatch2.ElapsedMilliseconds);
            Console.WriteLine("Rotate bottom: {0} ms", stopwatch3.ElapsedMilliseconds);
            Console.WriteLine("Rotate left column: {0} ms", stopwatch4.ElapsedMilliseconds);
            Console.WriteLine("Output final matrix: {0} ms", stopwatch5.ElapsedMilliseconds);
            Console.WriteLine("TOTAL: {0} ms", stopwatchMain.ElapsedMilliseconds);
        }

        public static void Execute()
        {
            // Small sample:

            /*int r = 7;
            List<List<int>> matrix = new List<List<int>>()
            {
                new List<int>(){ 1,2,3,4 },
                new List<int>(){ 7,8,9,10 },
                new List<int>(){ 13,14,15,16 },
                new List<int>(){ 19,20,21,22 },
                new List<int>(){ 25,26,27,28 },
            };*/

            // Large sample reading from the text file MatrixLayerRotationInput.txt
            int r = 7865;
            List<List<int>> matrix = new List<List<int>>();
            foreach (string line in File.ReadLines(@"C:\Users\Daniel-Kriptos\Documents\Visual Studio 2022\Projects\GitHub\hackerRankExercises\HackerRankExercises\HackerRankExercises\MatrixLayerRotationInput.txt"))
            {
                string[] vals = line.Split(new char[] { ' ' });

                List<int> ints = new List<int>();
                for(int i=0;i<vals.Length;i++)
                {
                    ints.Add(int.Parse(vals[i]));
                }
                matrix.Add(ints);
            }

            Console.WriteLine($"RESULT Matrix Layer Rotation:");
            matrixRotation(matrix, r);
        }
    }
}
