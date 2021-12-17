using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Single_Diamensional_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 30, 150, 170, 200 };
            int len = arr.Length;
            Console.WriteLine("Length of Array " + len);
            Console.WriteLine(arr[0] + " " + arr[4]);
            Console.ReadLine();
        }
    }
}
