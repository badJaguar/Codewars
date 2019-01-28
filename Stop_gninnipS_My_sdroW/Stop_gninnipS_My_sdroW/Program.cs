using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop_gninnipS_My_sdroW
{
    class Program
    {
        //Write a function that takes in a string of one or more words, and returns the same string, 
        //but with all five or more letter words reversed(Just like the name of this Kata). 
        //Strings passed in will consist of only letters and spaces.Spaces will be included only when more than one word is present.

        //Examples:

        //spinWords( "Hey fellow warriors" ) => returns "Hey wollef sroirraw" 
        //spinWords( "This is a test") => returns "This is a test" 
        //spinWords( "This is another test" ) => returns "This is rehtona test"

        static void Main()
        {
            Console.WriteLine(Kata.SpinWords("Hey fellow warriors")); // => returns "Hey wollef sroirraw" 
            Console.WriteLine(Kata.SpinWords("This is a test")); //  => returns "This is a test"
            Console.WriteLine(Kata.SpinWords("This is another test")); // => returns "This is rehtona test"
            Console.ReadKey();
        }

        public class Kata
        {
            public static string SpinWords(string sentence)
            {
                var words = (from s in sentence.Split(' ')
                             let r = string.Concat(s.Reverse())
                             select s.Length < 5 ? s : r);

                return string.Join(" ", from s in sentence.Split(' ')
                                        let r = string.Concat(s.Reverse())
                                        select s.Length < 5 ? s : r);
            }
        }
    }
}
