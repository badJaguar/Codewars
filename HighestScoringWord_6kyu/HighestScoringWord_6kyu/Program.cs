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
            var splitWords = (s.ToLower().Split(' ').ToArray())

                               .Select(r => new[]
                               {
                                   r.ToCharArray()
                                    .Select(g => (int) g % 32).Sum()
                               })
                               .Select(u => u[0]);

            var l = string.Join(" ", splitWords);
            Console.WriteLine(l);

            //foreach (var word in splitWords)
            //{
            //    var highestCount = new[]
            //    {
            //        word.ToCharArray()
            //            .Select(h => (int) h % 32).Sum()
            //    };

            //    var e = (new[] { word.ToCharArray().Select(g => (int)g % 32).Sum() });
            //var i = string.Join(" ", splitWords);

            //Console.Write($"{i[0]} ");
            //}
            return string.Empty;
        }
    }
}
