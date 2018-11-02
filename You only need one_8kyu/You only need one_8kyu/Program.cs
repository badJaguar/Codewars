using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace You_only_need_one_8kyu
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Kata.Check(new object[] { 66, 101 }, 66));
            Console.WriteLine(Kata.Check(new object[] { "what", "a", "great", "kata" }, "kat"));
            Console.WriteLine(Kata.Check(new object[] { 't', 'e', 's', 't' }, 'e'));
            Console.ReadKey();
        }

        public class Kata
        {
            public static bool Check(object[] a, object x)
            {
                if (a.Contains(x))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
