using ComparingHash.Entities;
using System.Collections.Generic;
namespace ComparingHash {
    internal class Program {
        static void Main(string[] args) {
            
            HashSet<string> hashSet = new HashSet<string>();
            hashSet.Add("Maria");
            hashSet.Add("Alex");
            hashSet.Add("Bob");
            Console.WriteLine(hashSet.Contains("Maria"));

            HashSet<Product> productSet = new HashSet<Product>();
            productSet.Add(new Product("TV", 900.0));
            productSet.Add(new Product("Notebook", 1200.0));
            Product prod = new Product("TV", 900.0);
            Console.WriteLine("The productSet Contains prod? " + productSet.Contains(prod));

            HashSet<Point> pointSet = new HashSet<Point>();
            pointSet.Add(new Point(3, 4));
            pointSet.Add(new Point(5, 10));
            Point p = new Point(5, 10);
            Console.WriteLine("The pointSet Contains p? " + pointSet.Contains(p));

            Product prod2 = new Product("TV", 900.0);
            Console.WriteLine("Is prod equals to prod2? " + prod.Equals(prod2));
            productSet.Add(prod2);

            Console.WriteLine("ProductSet items:");
            foreach (Product item in productSet) {
                Console.WriteLine(item.Name + " - " + item.Price);
            }


        }
    }
}
