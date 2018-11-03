using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HighestScoringWord_6kyu
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Kata.High("what time are we climbing up to the volcano"));

            Console.ReadKey();
        }
    }

    public class Kata
    {
        public static string High(string s)
        {
            var m = s.ToLower().Split(' ').ToArray();

            foreach (string n in m)
            {
                var sum = new[]
                {
                    n.ToCharArray()
                        .Select(h => (int) h % 32).Sum()
                };

                Console.Write($"{sum.Max()} ");
            }
            return string.Empty;
        }
    }
}
