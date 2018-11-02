using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AbbreviateaTwoWordName_8kyu
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Kata.AbbrevName("Sam Harris"));
            Console.ReadKey();
        }

        public class Kata
        {
            public static string AbbrevName(string name)
            {
                var regName = (Regex.Replace(name.Split(' ').First(), "\\s(.*)", string.Empty));
                var regLastN = (Regex.Replace(name.Split(' ').Last(), "\\s(.*)", string.Empty));

                return $"{regName.Remove(1, regName.Length - 1).ToUpper()}." +
                       $"{regLastN.Remove(1, regLastN.Length - 1).ToUpper()}";
            }
        }
    }
}
