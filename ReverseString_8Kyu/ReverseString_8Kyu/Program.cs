using System;
using System.Linq;

namespace ReverseString_8Kyu
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Kata.Solution("world"));
            Console.ReadLine();
        }
    }

    public static class Kata
    {
        public static string Solution(string str) =>
            new string(str.ToCharArray().Reverse().ToArray());
    }
}
