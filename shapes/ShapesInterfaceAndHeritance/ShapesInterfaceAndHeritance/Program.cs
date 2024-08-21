using System;
using ShapesInterfaceAndHeritance.Model.Entities;
using ShapesInterfaceAndHeritance.Model.Enums;

namespace ShapesInterfaceAndHeritance {
    internal class Program {
        static void Main(string[] args) {
            IShape s1 = new Circle() { Radius = 2.0, color = Color.Black };
            IShape s2 = new Rectangle() { Width = 3.5, Height = 4.2, color = Color.White };
            IShape s3 = new Rectangle() { Width = 1.5, Height = 2.0, color = Color.Black };
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
