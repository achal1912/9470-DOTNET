using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Double_Diamensional
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int[] arr = new int[] { 10, 11, 100, 101, 110 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
        }
    }
}
