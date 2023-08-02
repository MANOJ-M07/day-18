using CalcLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsageExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;
            do
            {
                Console.WriteLine("Enter Fisrt Number");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Choose operation");
                Console.WriteLine("!.Add 2.Sub 3.Multi 4. Div");
                int op = int.Parse(Console.ReadLine());
                Calc calc = new Calc();
                switch (op)
                {
                    case 1:
                        {
                            Console.WriteLine("Result after addition is: \t" + calc.Add(num1, num2));
                            break;
                        }
                ;
                    case 2:
                        {
                            Console.WriteLine("Result after Subtraction is: \t" + calc.Sub(num1, num2));
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Result after multiplication is: \t" + calc.Multi(num1, num2));
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Result after divition is: \t" + calc.Div(num1, num2));
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid operation choice!!!");
                            break;
                        }
                }
                Console.WriteLine("If wanna continous press y");
                choice = Console.ReadLine().ToLower();
            } while (choice == "y");

            Console.ReadKey();        
            
        }
    }
}
