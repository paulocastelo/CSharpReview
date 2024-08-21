using InterfaceIComparable.Entities;

namespace InterfaceIComparable {
    class Program {
        static void Main(string[] args) {
            string path = @"c:\temp\in.csv";
            try {
                using (StreamReader sr = File.OpenText(path)) {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream) {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee emp in list) {
                        System.Console.WriteLine(emp);
                    }
                }
            }
            catch (System.IO.IOException e) {
                System.Console.WriteLine("An error occurred");
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
