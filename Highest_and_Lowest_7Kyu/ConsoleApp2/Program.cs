using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Highest_and_Lowest_7Kyu
{
    class Program
    {
        //In this little assignment you are given a string of space 
        //separated numbers, and have to return the highest and lowest number.
        //    Example:
        //Kata.HighAndLow("1 2 3 4 5"); // return "5 1"
        //Kata.HighAndLow("1 2 -3 4 5"); // return "5 -3"
        //Kata.HighAndLow("1 9 3 4 -5"); // return "9 -5"
        //    Notes:
        //All numbers are valid Int32, no need to validate them.
        //    There will always be at least one number in the input string.
        //Output string must be two numbers separated by a single space, and highest number is first.
        static void Main()
        {
            Console.WriteLine(Kata.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
            Console.ReadKey();
        }
    }

    public static class Kata
    {
        public static string HighAndLow(string numbers)
        {
            var nums = from n in numbers.Split(' ')
                let t =  Convert.ToInt32(n)
                orderby t
                select t;

            var number = nums as int[] ?? nums.ToArray();
            return string.Join(" ", number.Max(), number.Min());
        }
    }
}
