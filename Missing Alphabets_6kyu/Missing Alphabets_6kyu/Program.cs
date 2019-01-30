using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Missing_Alphabets_6kyu
{
    class Program
    {
        static void Main()
        {

            //Console.WriteLine(Kata.MissingAlphabets("abcdefghijklmnopqrstuvwxy")); //z
            Console.WriteLine(Kata.MissingAlphabets("abbccddeeffgghhiijjkkllmmnnooppqqrrssttuuvvwwxxy")); //ayzz
            Console.WriteLine(Kata.MissingAlphabets("aabbccddeeffgghhiijjkkllmmnnooppqqrrssttuuvvwwxxyy")); //zz
            Console.WriteLine(Kata.MissingAlphabets("codewars")); //bfghijklmnpqtuvxyz
            Console.ReadKey();
        }

        public class Kata
        {
            public static string MissingAlphabets(string str)
            {
                var alphabet = (from d in "abcdefghijklmnopqrstuvwxyz".ToCharArray()
                                select d);

                var res = from a in str.ToCharArray()
                          where !str.Contains(alphabet.First())
                          select a;

                //var result = 

                Console.WriteLine($"{string.Join(" ", res)}");
                return default; // only regex
            }
        }
    }
}
