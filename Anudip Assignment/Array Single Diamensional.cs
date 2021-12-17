using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Single_diamensional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 11, 100, 101, 110 };
            int len = arr.Length;
            Console.WriteLine("Length of Array " + len);
            Console.WriteLine(arr[0] + " " + arr[4]);
            Console.ReadLine();
        }
        
    }
}
