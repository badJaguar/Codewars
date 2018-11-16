using System;
using System.Linq;

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
            var highCount = (s.ToLower().Split(' ').ToArray())
                               .Select(r =>
                                new[] { r.ToCharArray().Select(g => (int)g % 32).Sum() })
                               .Select(u => u[0]).ToArray();

            var strings = s.Split();
            Array.Sort(highCount, strings);
            var sorted = string.Join(" ", strings);
            Console.WriteLine(sorted);

            return sorted;
        }
    }
}
