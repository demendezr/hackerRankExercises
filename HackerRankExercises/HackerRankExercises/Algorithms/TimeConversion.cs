using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankExercises.Algorithms
{
    internal class TimeConversion
    {
        /*
        * Complete the 'timeConversion' function below.
        *
        * The function is expected to return a STRING.
        * The function accepts STRING s as parameter.
        */

        public static string timeConversion(string s)
        {
            Dictionary<string, string> times = new Dictionary<string, string>
            {
                { "01", "13" },
                { "02", "14" },
                { "03", "15" },
                { "04", "16" },
                { "05", "17" },
                { "06", "18" },
                { "07", "19" },
                { "08", "20" },
                { "09", "21" },
                { "10", "22" },
                { "11", "23" },
                { "12", "00" }
            };

            string[] values = s.Split(':');
            string newTime = "";

            if (!s.Contains("PM"))
            {
                if (string.Equals(values[0], "12")) newTime = $"{times[values[0]]}:";
                else newTime = $"{values[0]}:";
            }
            else {
                if (string.Equals(values[0], "12")) newTime = "12:";
                else newTime = $"{times[values[0]]}:";
            }

            newTime += string.Join(":", values.Skip(1));
            return newTime.Replace("PM","").Replace("AM","");
        }

        public static void Execute()
        {
            string s = "06:40:03AM";
            Console.WriteLine($"Time Conversion result: {timeConversion(s)}");
        }
    }
}
