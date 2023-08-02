﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnsafeCodeExampleOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 10, 20, 55, 33, 44 };
            unsafe
            {
                fixed (int* ptr = &array[0])
                {
                    int* ptr2 = ptr;
                    Console.WriteLine(*ptr2);
                    ptr2 += 1;
                    Console.WriteLine(*ptr2);
                }
            }
            Console.ReadKey();
        }
    }
}
