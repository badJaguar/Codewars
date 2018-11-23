using System;
using System.Linq;
using System.Runtime.InteropServices;

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
            Console.WriteLine(Kata.SortArray(new[] { 5, 3, 1, 8, 0 })); // 1, 3, 5, 8, 0
            Console.WriteLine(Kata.SortArray(new int[] { }));
            Console.ReadKey();
        }
    }

    public class Kata
    {
        public static int[] SortArray(int[] array)
        {
            var indexed = array.Select((num, ind) => // Indexing sequences
                new
                {
                    Number = num,
                    Index = ind
                }).ToList();

            var evens = (from i in indexed // Evens finds
                         where i.Number % 2 == 0
                         select i).ToList();

            var odds = (from i in indexed // Odds finds
                        where i.Number % 2 != 0
                        select i).ToList();

            var sortedOdds = from o in odds // Odds sorting
                             orderby o.Number
                             select o;

            // Replace on a places in present array of odd numbers to sortedOdds by index.
            // Sorted odds takes places by index of odds.
            var reindexOdds = sortedOdds.Zip(odds,
                (x, y) =>
                    new
                    {
                        x.Number,
                        y.Index
                    });

            var evensOddsConcat = (from e in evens.Concat(reindexOdds)
                                   orderby e.Index
                                   select e.Number).ToArray();

            Console.WriteLine(string.Join(" ", evensOddsConcat));
            return default(int[]);
        }
    }
}
