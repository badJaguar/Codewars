using System;
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
                var alphabet = (from d in "abcdefghijklmnopqrstuvwxyz"
                    select d).ToList();

                var result = alphabet.ToList().FindAll(d=> !str.ToList().Contains(d));

                Console.WriteLine($"{string.Join(" ",result)}");
                return default; // only regex
            }
        }
    }
}
