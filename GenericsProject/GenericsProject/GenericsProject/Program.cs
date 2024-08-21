
namespace GenericsProject {
    class Program {
        static void Main(string[] args) {
            PrintService<int> printService = new PrintService<int>();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }
            printService.Print();
            Console.WriteLine("First: "+ printService.First());


            PrintService<string> stringPrintService = new PrintService<string>();

            Console.Write("How many values? ");
            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++) {
                string x = Console.ReadLine();
                stringPrintService.AddValue(x);
            }
            stringPrintService.Print();
            Console.WriteLine("First: " + stringPrintService.First());

        }
    }
}
