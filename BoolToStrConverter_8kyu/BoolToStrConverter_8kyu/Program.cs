using System;

namespace BoolToStrConverter_8kyu
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Kata.BoolToWord(true));
            Console.WriteLine(Kata.BoolToWord(false));
            Console.ReadKey();
        }

        public static class Kata
        {
            public static string BoolToWord(bool word) =>
                word.Equals(true) ? "Yes" : "No";
        }
    }
}
