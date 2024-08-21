﻿using ComparisonT.Entities;

namespace ComparisonT {
    internal class Program {
        static void Main(string[] args) {
            List<Product> list = new List<Product>();

            // Adding products to the list
            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            // Sorting the list
            list.Sort(CompareProducts);

            // Printing the list
            Console.WriteLine("Sort by name: ");
            foreach (Product p in list) {
                Console.WriteLine(p);
            }
            Console.WriteLine();

            // Sorting by price
            list.Sort(ComparePricesProducts);
            // Printing the list
            Console.WriteLine("Sort by price:");
            foreach (Product p in list) {
                Console.WriteLine(p);
            }

            // Using lambda expression
            Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
            list.Sort(comp);
            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));
        }

        static int CompareProducts(Product p1, Product p2) {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }

        static int ComparePricesProducts(Product p1, Product p2) {
            return p1.Price.CompareTo(p2.Price);
        }
    }
}
