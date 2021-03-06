﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Union
{
    class Program
    {
        static void Main(string[] args)
        {
            Linq48();
            Console.ReadKey();
        }

        /// <summary>
        /// Linq48
        /// </summary>
        public static void Linq48()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            var uniqueNumbers = numbersA.Union(numbersB);

            Console.WriteLine("Unique numbers from both arrays:");

            foreach (var n in uniqueNumbers)
            {
                Console.WriteLine(n);
            }
        }

        public static void Linq49()
        {
            List<Product> products = Product.GetProductList();
            List<Customer> customers = Customer.GetCustomerList();

            var productFirstChars =
                from p in products
                select p.ProductName[0];
            var customerFirstChars =
                from c in customers
                select c.CompanyName[0];

            var uniqueFirstChars = productFirstChars.Union(customerFirstChars);

            Console.WriteLine("Unique first letters from Product names and Customer names: ");
            foreach (var ch in uniqueFirstChars)
            {
                Console.WriteLine(ch);
            }
        }
    }
}
