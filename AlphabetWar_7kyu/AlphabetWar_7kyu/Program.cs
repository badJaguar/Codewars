using System;
using System.Diagnostics;
using System.Linq;

namespace AlphabetWar_7kyu
{
    class Program
    {
        //        Introduction
        //There is a war and nobody knows - the alphabet war!
        //There are two groups of hostile letters.The tension between left side letters and right side letters was too high and the war began.
        //Task
        //Write a function that accepts fight string consists of only small letters and return who wins the fight.
        //When the left side wins return Left side wins!, when the right side wins return Right side wins!, in other case return Let's fight again!.
        //The left side letters and their power:
        //w - 4
        //p - 3
        //b - 2
        //s - 1
        //The right side letters and their power:
        //m - 4
        //q - 3
        //d - 2
        //z - 1
        //The other letters don't have power and are only victims.
        //Example
        //AlphabetWar("z");        //=> Right side wins!
        //        AlphabetWar("zdqmwpbs"); //=> Let's fight again!
        //        AlphabetWar("zzzzs");    //=> Right side wins!
        //        AlphabetWar("wwwwwwz");  //=> Left side wins!

        static void Main()
        {
            var watch = new Stopwatch();
            watch.Start();
            Console.WriteLine(Kata.AlphabetWar("z"));
            Console.WriteLine(Kata.AlphabetWar("bpq"));
            Console.WriteLine(Kata.AlphabetWar("z"));
            Console.WriteLine(Kata.AlphabetWar("tk"));
            Console.WriteLine(Kata.AlphabetWar("zdqmwpbs"));
            Console.WriteLine(Kata.AlphabetWar("zzzzs"));
            Console.WriteLine(Kata.AlphabetWar("wwwwwwz"));

            var t = watch.ElapsedMilliseconds;
            Console.WriteLine(t);

            Console.ReadKey();
        }

        public class Kata
        {
            public static string AlphabetWar(string fight)
            {
                var leftSide = (from f in fight.ToLower()
                                select f == 'w' ? (char)4
                                    : (f == 'p' ? (char)3
                                    : (f == 'b' ? (char)2
                                    : (f == 's' ? (char)1 : 0)))).Sum();

                var rightSide = (from f in fight.ToLower()
                                 select f == 'm' ? (char)4
                                     : (f == 'q' ? (char)3
                                     : (f == 'd' ? (char)2
                                     : (f == 'z' ? (char)1 : 0)))).Sum();

                return leftSide > rightSide ? "Left side wins!"
                       : (leftSide < rightSide ? "Right side wins!"
                       : "Let's fight again!");
            }
        }
    }
}
