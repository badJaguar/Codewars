using System;
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

        static void Main(string[] args)
        {
            Console.WriteLine(Kata.AlphabetWar("z"));
            //Console.WriteLine(Kata.AlphabetWar("bpq"));
            //Console.WriteLine(Kata.AlphabetWar("z"));
            //Console.WriteLine(Kata.AlphabetWar("tk"));
            Console.WriteLine(Kata.AlphabetWar("zdqmwpbs"));
            Console.WriteLine(Kata.AlphabetWar("zzzzs"));
            Console.WriteLine(Kata.AlphabetWar("wwwwwwz"));
            Console.ReadKey();
        }

        public class Kata
        {
            public static string AlphabetWar(string fight)
            {
                var victims = new char[] {
                    (char)('a' - char.Parse("a")), (char)('c' - char.Parse("c")), (char)('e' - char.Parse("e")),
                    (char)('f' - char.Parse("f")), (char)('g' - char.Parse("g")), (char)('h' - char.Parse("h")),
                    (char)('i' - char.Parse("i")), (char)('j' - char.Parse("j")), (char)('k' - char.Parse("k")),
                    (char)('l' - char.Parse("l")), (char)('n' - char.Parse("n")), (char)('o' - char.Parse("o")),
                    (char)('r' - char.Parse("r")), (char)('t' - char.Parse("t")), (char)('u' - char.Parse("u")),
                    (char)('v' - char.Parse("v")), (char)('x' - char.Parse("x")), (char)('y' - char.Parse("y"))
                };

                var leftChars = new char[]
                {
                    (char)('w' - char.Parse("w") + 4),
                    (char)('p' - char.Parse("p") + 3),
                    (char)('b' - char.Parse("b") + 2),
                    (char)('s' - char.Parse("s") + 1)
                };

                var rightChars = new char[]
                {
                    (char)('m' - char.Parse("m") + 4),
                    (char)('q' - char.Parse("q") + 3),
                    (char)('d' - char.Parse("d") + 2),
                    (char)('z' - char.Parse("z") + 1)
                };

                var vicsToZero = (from v in fight
                                  select v).Select(y => (int)y);

                //Console.WriteLine($"{string.Join(" ", vicsToZero)} victims");

                var left = (from f in fight
                            from v in victims
                            where f is 'w'
                               || f is 'p'
                               || f is 'b'
                               || f is 's'
                            select f + v).Select(t => (int)t).Sum();

                var right = (from f in fight
                             where f is 'm'
                                || f is 'q'
                                || f is 'd'
                                || f is 'z'
                             select f).Select(t => (int)t).Sum();

                //var stringList = (from f in fight.ToLower().Split()
                //                  select f).SelectMany(_ => _).ToArray().Except(victims);

                //Console.WriteLine($"{string.Join("", left)} is left");
                //Console.WriteLine($"{string.Join("", right)} is right");
                //Console.WriteLine($"{string.Join(" ", left)} left;\n {string.Join(" ", right)} right;\n {string.Join("", str)}");
                return
                leftChars.Select(e => (int)e).Sum() < rightChars.Select(h => (int)h).Sum() ? "Left side wins!"
                : (leftChars.Select(e => (int)e).Sum() > rightChars.Select(h => (int)h).Sum() ? "Right side wins!"
                : "Let's fight again!");
            }
        }
    }
}
