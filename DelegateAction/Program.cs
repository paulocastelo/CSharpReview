﻿using System;
using DelegateAction.Entities;
using System.Collections.Generic;
namespace DelegateAction {
    internal class Program {
        static void Main(string[] args) {
            List<Product> products = new List<Product>();

            products.Add(new Product("TV", 900.00));
            products.Add(new Product("Mouse", 50.00));
            products.Add(new Product("Tablet", 350.50));
            products.Add(new Product("HD Case", 80.90));

            // Print all items in the list
            Console.WriteLine("Print all items in the list:");
            Console.WriteLine("+--------------------------------------+");
            foreach (Product p in products) {
                Console.WriteLine(p);
            }
            Console.WriteLine("+--------------------------------------+");

            // UpdatePrice is a method that receives a Product and updates its price
            Action<Product> act = UpdatePrice;
            // Others ways to declare the delegate
            //Action<Product> act = p => { p.Price += p.Price * 0.1; }; 
            // Action<Product> act = delegate (Product p) { p.Price += p.Price * 0.1; };
            // Action<Product> act = delegate (Product p) { UpdatePrice(p); };

            // Apply the action to all items in the list
            products.ForEach(act);
            //products.ForEach(UpdatePrice);

            // Print all items in the list with updated prices
            Console.WriteLine("Print all items in the list with updated prices:");
            Console.WriteLine("+--------------------------------------+");
            foreach (Product p in products) {
                Console.WriteLine(p);
            }
            Console.WriteLine("+--------------------------------------+");

        }

        static void UpdatePrice(Product p) {
            p.Price += p.Price * 0.1;
        }
    }
}
