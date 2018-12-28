using System;
using System.Linq;
using System.Text;
using System.Xml;
using Int32 = System.Int32;

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
            Console.WriteLine(Kata.AlphabetWar("z"));
            Console.WriteLine(Kata.AlphabetWar("bpq"));
            Console.WriteLine(Kata.AlphabetWar("z"));
            Console.WriteLine(Kata.AlphabetWar("tk"));
            Console.WriteLine(Kata.AlphabetWar("zdqmwpbs"));
            Console.WriteLine(Kata.AlphabetWar("zzzzs"));
            Console.WriteLine(Kata.AlphabetWar("wwwwwwz"));
            Console.ReadKey();
        }

        public class Kata
        {

            public static string AlphabetWar(string fight)
            {
                var r = (from e in "mqdz".ToCharArray()
                         select e).First();
                var l = (from e in "wpbs".ToCharArray()
                         select e).First();

                var rightPower = (from f in fight
                                  select f == 'm' ? r = (char)4
                                      : (f == 'q' ? r = (char)3
                                      : (f == 'd' ? r = (char)2
                                      : (f == 'z' ? r = (char)1 : 0)))).Sum();

                var leftPower = (from f in fight
                                 select f == 'w' ? l = (char)4
                                     : (f == 'p' ? l = (char)3
                                     : (f == 'b' ? l = (char)2
                                     : (f == 's' ? l = (char)1 : 0)))).Sum();


                Console.WriteLine($"{string.Join("", leftPower)} {string.Join("", rightPower)}");

                //Console.WriteLine($"{string.Join(" ", left)} left;\n {string.Join(" ", right)} right;\n {string.Join("", str)}");
                return default;
                //  leftChars < rightChars ? "Left side wins!"
                //: (leftChars > rightChars ? "Right side wins!"
                //: "Let's fight again!");
            }
        }
    }
}
