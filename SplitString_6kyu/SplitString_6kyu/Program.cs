using System;
using System.Text.RegularExpressions;

namespace SplitString_6kyu
{
    class Program
    {
        static void Main()
        {
            // Complete the solution so that it splits the string into pairs of two characters. 
            // If the string contains an odd number of characters then it should replace the missing
            // second character of the final pair with an underscore ('_').

            Console.WriteLine(SplitString.Solution("abc"));
            Console.WriteLine(SplitString.Solution("abcdef"));
            Console.ReadKey();
        }
    }

    public class SplitString
    {
        public static string[] Solution(string str)
        {
            if (str.Length % 2 != 0)
                str = string.Concat(str, '_');

            return (Regex.Replace(str, ".{2}", "$0 ").TrimEnd()).Split();
        }
    }
}
