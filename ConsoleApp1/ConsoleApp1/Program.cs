using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
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
            public static string AbbrevName(string name) =>
                $"{name[0]}.{name[name.IndexOf(' ') + 1]}".ToUpper();
        }
    }
}
