using System;
using System.IO;
using System.Collections.Generic;

namespace DirectoryProject {
    internal class Program {
        static void Main(string[] args) {

            string path = @"c:\temp\myfolder";

            try {
                // List all files in the directory: not uses var
                Console.WriteLine("Print not using var.");
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS");
                foreach (string s in folders) {
                    Console.WriteLine(s);
                }

                //List all files in the directory: uses var
                Console.WriteLine("Print using var.");
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES");
                foreach(string s in files) {
                    Console.WriteLine(s);
                }

                //Create a new folder
                Directory.CreateDirectory(path + @"\folder");
                Console.WriteLine("New folder created: " + path + @"\folder");

            }
            catch (Exception e) {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
