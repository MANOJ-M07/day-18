using CalcLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsageExample
{
    public static class MyClass
    {
        public static void Welcome(this Calc obj)
        {
            Console.WriteLine("Welcome to calculator");
        }

        public static double Avg(this Calc obj, double num1, double num2)
        {
            double result = ((obj.Add(num1, num2)) / 2);
            return result;
        }
    }
}
