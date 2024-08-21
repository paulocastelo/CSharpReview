using System.Collections.Generic;

namespace HashSetSortedSet {
    internal class Program {
        static void Main(string[] args) {
            HashSet<string> set = new HashSet<string>();
            set.Add("TV");
            set.Add("Radio");
            set.Add("Computer");
            set.Add("Notebook");
            set.Add("Tablet");
            Console.WriteLine(set.Contains("Computer"));

            foreach (string item in set) {
                Console.WriteLine(item); ;
            }

            SortedSet<int> set2 = new SortedSet<int>() { 0, 2, 4, 6, 8, 10 };
            SortedSet<int> set3 = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };
            PrintCollection(set2);
            PrintCollection(set3);

            //Union
            SortedSet<int> set4 = new SortedSet<int>(set2);
            set4.UnionWith(set3);
            PrintCollection(set4);

            //Intersection
            SortedSet<int> set5 = new SortedSet<int>(set2);
            set5.IntersectWith(set3);
            PrintCollection(set5);

            //Difference
            SortedSet<int> set6 = new SortedSet<int>(set2);
            set6.ExceptWith(set3);
            PrintCollection(set6);
        }

        static void PrintCollection<T>(IEnumerable<T> collection) {
            foreach (T obj in collection) {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
