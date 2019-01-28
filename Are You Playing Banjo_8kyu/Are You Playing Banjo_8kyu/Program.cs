using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Are_You_Playing_Banjo_8kyu
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Kata.AreYouPlayingBanjo("Martin"));
            Console.WriteLine(Kata.AreYouPlayingBanjo("Rikke"));
            Console.WriteLine(Kata.AreYouPlayingBanjo("rolf"));
            Console.ReadKey();
        }

        public class Kata
        {
            public static string AreYouPlayingBanjo(string name) =>
              name.StartsWith("R") || name.StartsWith("r")
              ? $"{name} plays banjo"
              : $"{name} does not play banjo";
        }
    }
}
