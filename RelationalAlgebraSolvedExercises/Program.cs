using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using RelationalAlgebraSolvedExercises.Entities;

namespace RelationalAlgebraSolvedExercises {
    internal class Program {
        static void Main(string[] args) {
            // Load txt file from the path
            Console.Write("Input the file's path: ");
            //string path = Console.ReadLine();
            string path = @"C:\projetos\CSharpReview\RelationalAlgebraSolvedExercises\in.txt";

            List<Product> products = new List<Product>();

            using (StreamReader sr = File.OpenText(path)) {
                while (!sr.EndOfStream) {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    products.Add(new Product(name, price));
                }
            }

            //Stream stream = File.OpenRead(path);
            //StreamReader reader = new StreamReader(stream);
            //for (int i = 0; i < stream.Length; i++) {
            //    string line = reader.ReadLine();
            //    string[] fields = line.Split(',');
            //    string name = fields[0];
            //    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
            //    products.Add(new Product(name, price));
            //}

            Console.Write("PRODUCTS AVARAGE PRICE: ");

            // Avarage price of products - LINQ
            var avg = (from p in products
                       select p.Price).Sum() / (products.Count);

            // Avarage price of products - LINQ 2
            var avg2 = products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();

            Console.WriteLine(avg.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

            Console.WriteLine("PRODUCTS WITH PRICE LOWER THAN AVERAGE:");
            // Products with price lower than average - LINQ
            var lowerThanAvg = from p in products
                               where p.Price < avg
                               orderby p.Name descending
                               select p.Name;

            // Products with price lower than average - LINQ 2
            var lowerThanAvg2 = products
                .Where(p => p.Price < avg)
                .OrderByDescending(p => p.Name)
                .Select(p => p.Name);

            // Products with price lower than average - LINQ 3
            foreach (string name in lowerThanAvg) {
                Console.WriteLine(name);
            }

            // Products with price lower than average - LINQ 4
            foreach (string name in lowerThanAvg2) {
                Console.WriteLine(name);
            }
        }
    }
}
