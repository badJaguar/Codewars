using System;
using System.Linq;

namespace Sort_the_odd_6Kyu
{
    class Program
    {
        //You have an array of numbers.
        //    Your task is to sort ascending odd numbers but even numbers must be on their places.
        //    Zero isn't an odd number and you don't need to move it.If you have an empty array, you need to return it.
        //    Example
        //    sortArray([5, 3, 2, 8, 1, 4]) == [1, 3, 2, 8, 5, 4]
        static void Main()
        {
            Console.WriteLine(Kata.SortArray(new[] { 5, 3, 2, 8, 1, 4 })); // 1, 3, 2, 8, 5, 4
            //Console.WriteLine(Kata.SortArray(new[] { 5, 3, 1, 8, 0 })); // 1, 3, 5, 8, 0
            //Console.WriteLine(Kata.SortArray(new int[] { }));
            Console.ReadKey();
        }
    }

    public class Kata
    {
        public static int[] SortArray(int[] array)
        {
            var odd = (from a in array
                       where a % 2 != 0
                       select a).ToArray();

            var even = array.Where(a => a % 2 == 0);
            Array.Sort(odd, array);
            Console.WriteLine(string.Join(" ", array));
            return default(int[]);
        }
    }
}
