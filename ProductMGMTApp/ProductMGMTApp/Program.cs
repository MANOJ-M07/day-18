using System;
using Product;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMGMTApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Operation \n 1.ShowList \n 2.Add Product");
            int op = int.Parse(Console.ReadLine());
            ProductMgmt mgmt = new ProductMgmt();
            switch (op)
            {
                case 1:
                    {
                        mgmt.PrintList();
                        break;
                    }

                case 2:
                    {
                        Product1 obj = new Product1();
                        Console.WriteLine("Enter Id");
                        obj.ID = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Product Name ");
                        obj.Name = Console.ReadLine();
                        Console.WriteLine("Enter product price");
                        obj.Price = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter MfDate");
                        obj.MfDate = DateTime.Parse(Console.ReadLine());
                        mgmt.AddProcut(obj);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid operation");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
