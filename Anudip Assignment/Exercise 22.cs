using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test("Red"));
            Console.WriteLine(test("Green"));
            Console.WriteLine(test("1"));
            Console.ReadLine();
        }

        public static string test(string str)
        {
            var s = str.Substring(str.Length - 1);
            return s + str + s;
        }
    }
}
