using System;
using System.Linq;
using System.Collections.Generic;
namespace LingBasics {
    internal class Program {
        static void Main(string[] args) {
            // Specify the data source.
            int[] numbers = new int[] { 2, 3, 4, 5 };

            // Define the query expression.
            var result = numbers
                .Where(n => n % 2 == 0)
                .Select(x => x * 10);

            // Execute the query.
            foreach (int x in result) {
                Console.WriteLine(x);
            }

            // List of all operations LINQ can perform

            // Filtering: Where, OfType
            // Sorting: OrderBy, OrderByDescending, ThenBy, ThenByDescending, Reverse
            // Set: Distinct, Except, Intersect, Union
            // Quantifiers: All, Any, Contains
            // Projection: Select, SelectMany
            // Partitioning: Skip, SkipWhile, Take, TakeWhile
            // Join: Join, GroupJoin
            // Grouping: GroupBy
            // Generation: DefaultIfEmpty, Empty, Range, Repeat
            // Element: ElementAt, ElementAtOrDefault, First, FirstOrDefault, Last, LastOrDefault, Single, SingleOrDefault
            // Conversion: AsEnumerable, AsQueryable, Cast, ToArray, ToDictionary, ToList
            // Concatenation: Concat
            // Aggregation: Aggregate, Average, Count, LongCount, Max, Min, Sum

        }
    }
}
