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
            //var regex = new Regex("[A-Z]");
            //var c = s.ToLower().Remove(' ').ToCharArray();
            //var m = s.Split(' ').ToArray();
            var e = s.ToLower().ToCharArray();

            //var ch = from w in s.Split(' ')
            //         select (w.ToCharArray())
            //             .Aggregate((x, y) => (char)(x + y));

            foreach (var VARIABLE in e)
            {
                var index = (int)VARIABLE % 32;

                Console.WriteLine(index);
            }
           
                
                
            
            return string.Empty;
        }
    }
}
