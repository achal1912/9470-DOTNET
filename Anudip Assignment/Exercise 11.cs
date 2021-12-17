using System;

namespace Exercise11_if_else
{
    internal class program
    {
        static void Main(string[] args)
         {
            int n;
                Console.Write("Enter an integer: ");
                n = Int32.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("{0} is even", 'n');
            }
            else
            {
                Console.WriteLine("{0} is odd", 'n');
            }
            Console.ReadLine ();
         }
    }
}


