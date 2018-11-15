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
            var splitWords = s.ToLower().Split(' ').ToArray();

            foreach (var word in splitWords)
            {
                var highestCount = new[]
                {
                    word.ToCharArray()
                        .Select(h => (int) h % 32).Sum()
                };

                Console.Write($"{highestCount[0]} ");
            }
            return string.Empty;
        }
    }
}
