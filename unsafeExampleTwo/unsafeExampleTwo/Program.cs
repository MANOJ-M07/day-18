﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unsafeExampleTwo
{
    public class Program
    {
        public unsafe static string ReverseString(string str)
        {
            if (str ==  null)
            {
                return null;    
            }
            int length = str.Length;    
            char* reversed = stackalloc char[length];

            fixed (char* orginal = str)
            {
                char* pOrginal = orginal;
                char* pReversed = reversed + length - 1;

                for (int i = 0; i < length; i++)
                {
                    *pReversed = *pOrginal;
                    pOrginal++;
                    pReversed--;
                }
            }
            return new string(reversed, 0, length);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string to reverse");
            string input = Console.ReadLine();
            string reversed = ReverseString(input);
            Console.WriteLine($"Reveersed string: {reversed}");
            Console.ReadKey ();
        }
    }
}
