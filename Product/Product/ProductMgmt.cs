using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class ProductMgmt
    {
        static List<Product1> products;

        public ProductMgmt()
        {
            products = new List<Product1>()
            {
                new Product1 { ID = 1, Name = "Herbal Shampoo", Price = 450.50, MfDate = new DateTime(day: 12, month: 1, year: 2022) },
                new Product1 { ID = 2, Name = "Dabur Honey", Price = 750.50, MfDate = new DateTime(day: 12, month: 11, year: 2022) },
                new Product1 { ID = 3, Name = "Matic Surf", Price = 4250.50, MfDate = new DateTime(day: 12, month: 10, year: 2021) },
                new Product1 { ID = 4, Name = "Tata Gold Tea", Price = 2230.50, MfDate = new DateTime(day: 12, month: 02, year: 2023) },
                new Product1 { ID = 5, Name = "veg .poha", Price = 70.50, MfDate = new DateTime(day: 02, month: 11, year: 2022) },
                new Product1 { ID = 6, Name = "Fce Wash", Price = 1250.50, MfDate = new DateTime(day: 01, month: 11, year: 2023) },
            };
        }

        public void PrintList()
        {
            foreach (Product1 product in products)
            {
                Console.WriteLine("ID: \t " + product.ID);
                Console.WriteLine("Name: \t" + product.Name);
                Console.WriteLine("MfDate: \t" + product.MfDate);
                Console.WriteLine("Price: \t" + product.Price);

            }
        }

        public void AddProcut(Product1 pro)
        {
            products.Add(pro);
            Console.WriteLine("List after adding product");
            this.PrintList();
        }
    }
}
