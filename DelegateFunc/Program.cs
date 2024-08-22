using System;
using System.Collections.Generic;
using DelegateFunc.Entities;
using System.Linq;

namespace DelegateFunc {
    class Program {
        static void Main(string[] args) {
            
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            // Delegate Func
            Func<Product, string> func = NameUpper;

            // Apply the func and generate a list with name and price of each product
            List<string> result2 = list.Select(func).ToList();
            foreach (string s in result2) {
                Console.WriteLine(s);
            }

            // Forms to use Delegate Func
            // 1. Using lambda expression
            List<string> result = list.Select(NameUpper).ToList();

            // 2. Using lambda expression inline
            // List<string> result = list.Select(p => p.Name.ToUpper()).ToList();

            // 3. Using lambda expression inline with delegate Func
            // List<string> result = list.Select(p => p.Name.ToUpper()).ToList();

            // 4. Using lambda expression inline with delegate Func and method reference
            // List<string> result = list.Select(p => p.Name.ToUpper()).ToList();

            // Print the result
            // 1. Simple way
            //Console.WriteLine(result);

            // 2. Using foreach
            result.ForEach(Console.WriteLine);

        }

        static string NameUpper(Product p) {
            return p.Name.ToUpper();
        }
    }
}
