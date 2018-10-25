using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PrinterErrors_7kyu
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Printer.PrinterError("aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz"));
            Console.ReadKey();
        }
    }

    public class Printer
    {
        public static string PrinterError(String s)
        {
            var reg = new Regex((@"a-mA-m+"));
            var e = reg.GetGroupNames();
            foreach (var f in e)
            {
                Console.WriteLine(f);

            }
            return String.Empty;
        }
    }
}
