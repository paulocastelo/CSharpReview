using System;
using System.IO;
namespace StreamFile {
    internal class Program {
        static void Main(string[] args) {
            string path = @"c:\temp\file1.txt";
            StreamReader sr = null;
            try {
                sr = File.OpenText(path);
                while (!sr.EndOfStream) {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e) {
                Console.Write("An error occurred");
                Console.Write(e.Message);
            }
            finally {
                if (sr != null) sr.Close();
            }
        }
    }
}