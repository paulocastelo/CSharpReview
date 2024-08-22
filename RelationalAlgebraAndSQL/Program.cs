﻿using System;
using System.Linq;
using System.Collections.Generic;
using RelationalAlgebraAndSQL.Entities;
namespace RelationalAlgebraAndSQL {
    internal class Program {

        static void Print<T>(string message, IEnumerable<T> collection) {
            Console.WriteLine(message);
            foreach (T obj in collection) {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
        static void Main(string[] args) {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

            List<Product> products = new List<Product>() {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            // "TIER 1 AND PRICE < 900:"
            //var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900);
            var r1 =
                from p in products
                where p.Category.Tier == 1 && p.Price < 900
                select p;
            Print("TIER 1 AND PRICE < 900:", r1);

            // "NAMES OF PRODUCTS FROM TOOLS:"
            //var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            var r2 =
                from p in products
                where p.Category.Name == "Tools"
                select p.Name;
            Print("NAMES OF PRODUCTS FROM TOOLS:", r2);

            // "NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT:"
            //var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            var r3 =
                from p in products
                where p.Name[0] == 'C'
                select new {
                    p.Name,
                    p.Price,
                    CategoryName = p.Category.Name };
            Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT:", r3);

            // "TIER 1 ORDER BY PRICE THEN BY NAME:"
            //var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            var r4 =
                from p in products
                where p.Category.Tier == 1
                orderby p.Price, p.Name
                select p;
            Print("TIER 1 ORDER BY PRICE THEN BY NAME:", r4);

            // "TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4:"
            //var r5 = r4.Skip(2).Take(4);
            var r5 =
                (from p in r4
                 select p).Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4:", r5);

            // "FIRST OR DEFAULT TEST1:"
            var r6 = (from p in products
                      select p).FirstOrDefault();
            Console.WriteLine("First or default test1: " + r6);

            // "FIRST OR DEFAULT TEST2:"
            var r7 = (from p in products
                      where p.Price > 3000.0
                      select p).FirstOrDefault();
            Console.WriteLine("First or default test2: " + r7);

            // "SINGLE OR DEFAULT TEST1:"
            //var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            var r8 = (from p in products
                      where p.Id == 3
                      select p).SingleOrDefault();
            Console.WriteLine("Single or default test1: " + r8);

            // "SINGLE OR DEFAULT TEST2:"
            //var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            var r9 = (from p in products
                      where p.Id == 30
                      select p).SingleOrDefault();
            Console.WriteLine("Single or default test2: " + r9);

            
            Console.WriteLine();
            // "GROUP BY CATEGORY:"
            var r16 = (from p in products
                       group p by p.Category);
            foreach (IGrouping<Category, Product> group in r16) {
                Console.WriteLine("# Category " + group.Key.Name + ":");
                foreach (Product p in group) {
                    Console.WriteLine("    - " + p);
                }
                Console.WriteLine();
            }

        }
    }
}
