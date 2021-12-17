﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test("if else"));
            Console.WriteLine(test("else"));
            Console.ReadLine();
        }

        public static string test(string s)
        {
            if (s.Length > 2 && s.Substring(0, 2).Equals("if"))
            {
                return s;
            }
            return "if " + s;
        }
    }
}
