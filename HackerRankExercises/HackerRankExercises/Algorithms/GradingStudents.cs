using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankExercises.Algorithms
{
    internal class GradingStudents
    {
        /*
         * Complete the 'gradingStudents' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts INTEGER_ARRAY grades as parameter.
         */
        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < grades.Count; i++)
            {
                int grade = grades[i];

                if (grade >= 38)
                {
                    while (true)
                    {
                        var division = Decimal.Divide(grade,5);
                        if (division % 1 == 0) break;
                        grade += 1;
                    }
                    if (grade - grades[i] < 3) result.Add(grade);
                    else if (grade - grades[i] == 3) result.Add(grades[i]);
                    else result.Add(grades[i]);
                }
                else
                {
                    result.Add(grade);
                }
            }

            return result;
        }

        public static void Execute()
        {
            List<int> students = new List<int>()
            {
                80,96,18,73,78,60,60,15,45,15,10,5,46,87,33,60,14,71,65,2,5,97,0
            };

            Console.WriteLine("Result Grading Studens:");
            Console.WriteLine(string.Join("\n", gradingStudents(students)));
        }
    }
}
