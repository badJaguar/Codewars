using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortWordsByVowelCount
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(SortByVowels.Sorted("love", "I", "communication", "greater"));
            Console.ReadKey();
        }
    }

    internal class SortByVowels
    {
        public static string Sorted(params string[] words)
        {
            var vowelsCount = (from t in words
                select t.ToLower())
                .Select(t=>(int)t.Count("aeiou".Contains)).ToArray();

            Array.Sort(vowelsCount,words);
            return string.Join(" ", words);
        }
    }
}
