using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWords_7Kyu
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Kata.ReverseWords("This is an example!"));
            Console.ReadKey();
        }
    }

    public static class Kata
    {
        public static string ReverseWords(string str)
        {
            var words = from s in str.Split()
                        select s.Insert(s.Length, " ").TrimStart()
                            .Reverse().ToArray(); // 1st variant.

            return new string(str.ToArray().Reverse().ToArray());
        }
    }
    //str.Split().Select(s => s.Insert(s.Length, " ").TrimStart().Reverse())
}
