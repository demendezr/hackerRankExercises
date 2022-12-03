using System.Diagnostics;

namespace HackerRankExercises.Arrays
{
    internal class MaximumElement
    {
        /*
         * Complete the 'getMax' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts STRING_ARRAY operations as parameter.
         */

        public static void getMax(List<string> operations)
        {
            /*
             * 1 x  -Push the element x into the stack.
               2    -Delete the element present at the top of the stack.
               3    -Print the maximum element in the stack.
             */
            
            int number, max, pointer = 0;
            int[] stack = new int[operations.Count];
            string query;

            for (int i = 0; i < operations.Count; ++i)
            {
                query = operations[i];

                if (query.Substring(0,1) == "1")
                {
                    number = Convert.ToInt32(query.Substring(2));
                    if (pointer == 0)
                    {
                        stack[pointer++] = number;
                    }
                    else
                    {
                        max = stack[pointer - 1];
                        stack[pointer++] = (number > max) ? number : max;
                    }
                }
                else if (query.Substring(0,1) == "2")
                {
                    --pointer;
                }
                else
                {
                    Console.WriteLine(stack[pointer - 1]);
                }
            }
        }

        public static void Execute()
        {
            /* Example:
                10      operations[] size n = 10
                1 97    operations = ['1 97', '2', '1 20', ....]
                2
                1 20
                2
                1 26
                1 20
                2
                3
                1 91
                3

                Result: 
                26
                91
             */

            List<string> operations = new List<string>()
            {
               "1 97","2", "1 20", "2", "1 26", "1 20", "2", "3", "1 91", "3"

            };

            Console.WriteLine($"RESULT Maximum Element: ");
            getMax(operations);
        }
    }
}
