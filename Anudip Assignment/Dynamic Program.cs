using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_program
{
    internal class Program
    {
            class Demo 
        {
            dynamic Data = 12;
            public int Method(int A, int B)
            {
                return (A + B) * Data;
            }
        }
        class program
        {
            static void Main(string[] args)
            {
                Demo Obj = new Demo();
                dynamic value1 = 10;
                dynamic value2 = 11;
                dynamic Str = "Your Result Is: ";
                Console.WriteLine(Str + Obj.Method(value1, value2));
                Console.ReadLine();
            }
        }
    }
}
