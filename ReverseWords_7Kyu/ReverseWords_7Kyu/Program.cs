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
            Console.WriteLine(Kata.ReverseWords("This  is an example!"));
            Console.ReadKey();
        }
    }

    public static class Kata
    {
        public static string ReverseWords(string str)
        {
            var reversedWords = str.Split(' ').Reverse();
            var words = reversedWords as string[] ?? reversedWords.ToArray();
            Array.Reverse(words.ToArray());
            str = string.Join(" ", words);
            return new string(str.ToArray().Reverse().ToArray());
        }
    }
}
