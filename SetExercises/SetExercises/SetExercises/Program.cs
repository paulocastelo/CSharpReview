using SetExercises.Entities;
using System.Collections.Generic;
namespace SetExercises {
    internal class Program {
        static void Main(string[] args) {

            HashSet<LogRecord> set = new HashSet<LogRecord>();


            Console.WriteLine("Enter full file path: ");
            //string path = Console.ReadLine();
            string path = @"C:\projetos\SetExercises\SetExercises\in.txt";
            Console.WriteLine(path);

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord(name, instant));
                    }
                    Console.WriteLine("Total users: " + set.Count);
                    foreach (LogRecord obj in set) {
                        Console.WriteLine(obj);
                    }
                }
            }
            catch (IOException e) {
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }
    }
}
