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
            var indexedNums = array.Select((num, idx) => new { num, idx }).ToList();

            var evens = indexedNums.Where(x => x.num % 2 == 0);
            var odds = indexedNums.Where(x => x.num % 2 == 1);

            var sortedOdds = odds.OrderBy(x => x.num); //sort the odd numbers by their value

            var reindexedOdds = sortedOdds.Zip(odds, (o1, o2) => new { o1.num, o2.idx });

                var endSequence = evens.Concat(reindexedOdds).OrderBy(x => x.idx).Select(x => x.num);
            Console.WriteLine(string.Join(" ", endSequence));
            return default(int[]);
        }
    }
}
