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
            var regex = new Regex("[A-Z]");
            var m = s.ToLower().Split(' ').ToArray();
            var e = s.ToLower().ToCharArray();

            foreach (string n in m)
            {
                Console.Write($"{n.ToCharArray().Select(h=> (int)h % 32).Sum()} ");
            }

            //foreach (var num in e)
            //{
            //    var index = (int)num % 32;

            //    Console.WriteLine(index);
            //}
            return string.Empty;
        }
    }
}
