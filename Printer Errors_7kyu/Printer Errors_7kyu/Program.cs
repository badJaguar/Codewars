using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Printer_Errors_7kyu
{
    class Program
    {
        static void Main()
        {
            var watch = new Stopwatch();
            watch.Start();
            Console.WriteLine($"{Printer.PrinterError("aaaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz")}" +
                              $" {watch.ElapsedMilliseconds}");
            Console.ReadKey();
        }
    }

    public class Printer
    {
        public static string PrinterError(string s)
        {
            var regexError = new Regex("[n-z]", RegexOptions.Compiled);
            var errors = regexError.Matches(s);
            return $"{errors.Count}/{s.Length}";
        }
    }
}
