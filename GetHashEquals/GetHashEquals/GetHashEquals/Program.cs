using System;
using GetHashEquals.Entities;

namespace GetHashEquals {
    class Program {
        static void Main(string[] args) {
            string a = "Maria";
            string b = "Alex";
            Console.WriteLine(a.Equals(b)); // False
            string c = "Maria";
            Console.WriteLine(a.Equals(c));
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(c.GetHashCode());
            Console.WriteLine(b.GetHashCode());

            Client client1 = new Client("Maria", "maria@gmail.com");
            Client client2 = new Client("Alex", "alex@gmail.com");
            Console.WriteLine(client1.Equals(client2)); // False
            Console.WriteLine(client1.GetHashCode());
            Console.WriteLine(client2.GetHashCode());

            Client client3 = new Client("Maria", "maria@gmail.com");
            Console.WriteLine(client1.Equals(client3)); // True
        }
    }
}
