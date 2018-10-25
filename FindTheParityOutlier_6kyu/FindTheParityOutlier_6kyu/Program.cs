using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheParityOutlier_6kyu
{
    class Program
    {
        //You are given an array(which will have a length of at least 3, but could be very large) containing integers.
        //The array is either entirely comprised of odd integers or entirely comprised of even integers except for
        //a single integer N. Write a method that takes the array as an argument and returns this "outlier" N.

        static void Main()
        {
            var integers = new[] { 1056521, 7, 17, 1901, 21104421, 7, 1, 35521, 206847684, 1, 7781 };
            Console.WriteLine(Kata.Find(integers));
            Console.ReadKey();
        }
    }

    // First variant.
    public class Kata
    {
        public static int Find(int[] integers)
        {
            var oddNum = (from i in integers
                          where i % 2 != 0
                          select i).First();

            var evenNum = (from i in integers
                           where i % 2 == 0
                           select i).First();

            return oddNum.ToString().Length == 1 ? oddNum : evenNum;
        }
    }

    // Second variant
    public class Kata2
    {
        public static int Find(int[] integers)
        {
            var oddNum = integers.First(i => i % 2 != 0);
            var evenNum = integers.First(i => i % 2 == 0);

            return oddNum.ToString().Length == 1 ? oddNum : evenNum;
        }
    }
}
