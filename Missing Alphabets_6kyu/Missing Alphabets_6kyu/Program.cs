using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Missing_Alphabets_6kyu
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine(Kata.MissingAlphabets("abcdefghijklmnopqrstuvwxy")); //z
            Console.WriteLine(Kata.MissingAlphabets("abbccddeeffgghhiijjkkllmmnnooppqqrrssttuuvvwwxxy")); //ayzz
            Console.WriteLine(Kata.MissingAlphabets("aabbccddeeffgghhiijjkkllmmnnooppqqrrssttuuvvwwxxyy")); //zz
            Console.WriteLine(Kata.MissingAlphabets("codewars")); //bfghijklmnpqtuvxyz
            Console.ReadKey();
        }

        public class Kata
        {
            public static string MissingAlphabets(string str)
            {
                var alphabet = (from a in "abcdefghijklmnopqrstuvwxyz"
                                select a);

                var vara = from s in str
                           select s;
                var alphabet1 = "abcdefghijklmnopqrstuvwxyz";

                var e = Regex.Matches(str, alphabet1);

                Console.WriteLine($"{string.Concat(e)}");
                return default;
            }
        }
    }
}
