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
            //var m = s.Split(' ').SelectMany(v => v.ToLower().ToCharArray(), (_, c) => c % 32);

            string[] words = s.Split(' ');

            //IEnumerable<int> g = string.Join(" ", words).Select(i => (int)i % 32);

            var sum = (from w in words
                       let e = w.Insert(w.Length, " ")
                       select e);

            foreach (var VARIABLE in sum)
            {
                var d = (from v in VARIABLE
                         select v).Aggregate((x, y) => (char)(x + y));
                var index = ((int)d % 32).ToString();
                Console.Write($" {index}");
            }
            return string.Empty;
        }
    }
}
