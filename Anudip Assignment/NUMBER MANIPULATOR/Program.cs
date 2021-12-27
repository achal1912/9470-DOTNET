using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULATORAPPLICATION
{
    class NumberManipulator
    {
        public void swrap(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
        static void main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            int a = 600;
            int b = 100;
            Console.WriteLine("before swap,value of a : {0}", a);
            Console.WriteLine("before swap,value of b : {0}", b);
            n.swrap(ref a, ref b);
            Console.WriteLine("after swap,value of a : {0}", a);
            Console.WriteLine("after swap,value of b : {0}", b);
            Console.ReadLine();
        }
    }
}
