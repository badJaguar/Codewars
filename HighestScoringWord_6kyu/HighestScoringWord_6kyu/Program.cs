using System;
using System.Diagnostics;
using System.Linq;

namespace HighestScoringWord_6kyu
{
    class Program
    {
        static void Main()
        {
            var w = new Stopwatch();
            w.Start();
            Console.WriteLine(Kata.High("what time are we climbing up to the volcano"));
            Console.WriteLine(w.ElapsedMilliseconds);

            Console.ReadKey();
        }
    }

    //Instructions:
    //Given a string of words, you need to find the highest scoring word.
    //Each letter of a word scores points according to it's position in the alphabet: a = 1, b = 2, c = 3 etc.
    //You need to return the highest scoring word as a string.
    //If two words score the same, return the word that appears earliest in the original string.
    //All letters will be lowercase and all inputs will be valid.
    public class Kata
    {
        public static string High(string s)
        {
            var strings = s.Split();

            var highCount = (s.ToLower().Split(' ').ToArray()
                              .Select(r =>
                               new[] { r.ToCharArray().Select(g => (int)g % 32).Sum() })
                              .Select(u => u[0]).ToArray());

            Array.Sort(highCount, strings);

            return string.Join(" ", strings.Last());
        }
    }
}
