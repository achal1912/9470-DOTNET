using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(103));
            Console.WriteLine(test(98));
            Console.WriteLine(test(89));
            Console.ReadLine();
        }
        public static bool test(int x)
        {
            if (Math.Abs(x - 100) <= 10 || Math.Abs(x - 200) <= 10)
                return true;
            return false;
        }

    }
}
