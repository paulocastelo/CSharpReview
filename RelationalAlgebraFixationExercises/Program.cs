using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using RelationalAlgebraFixationExercises.Entities;
using System.Globalization;
namespace RelationalAlgebraFixationExercises {
    internal class Program {
        static void Main(string[] args) {
            List<Employee> employees = new List<Employee>();
            string path = @"C:\projetos\CSharpReview\RelationalAlgebraFixationExercises\in.txt";

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        double salary = double.Parse(fields[1]);
                        employees.Add(new Employee(name, salary));
                    }
                }

                // Calculate average salary of employees
                var avg = employees.Select(e => e.Salary).DefaultIfEmpty(0.0).Average();
                Console.WriteLine("Average salary: " + avg.ToString("F2"));

                // Calculate average salary of employees whose salary is greater than 2000.0
                var avg2 = (from p in employees
                            where p.Salary > 2000.0
                            select p.Salary).DefaultIfEmpty(0.0).Average();
                Console.WriteLine(avg2.ToString("F2", CultureInfo.InvariantCulture));

                // Get names of employees whose salary is greater than average
                var names = employees.Where(e => e.Salary > avg).OrderBy(e => e.Name).Select(e => e.Name);
                foreach (string name in names) {
                    Console.WriteLine(name);
                }
            }
            catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
