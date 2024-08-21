namespace ProposedDictionaryExercises {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter full file path: ");
            //string filePath = Console.ReadLine();
            string path = @"C:\projetos\ProposedDictionaryExercises\in.txt";
            Console.WriteLine(path);
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] line = sr.ReadLine().Split(',');
                        string candidate = line[0];
                        int votes = int.Parse(line[1]);
                        if (dictionary.ContainsKey(candidate)) {
                            dictionary[candidate] += votes;
                        }
                        else {
                            dictionary[candidate] = votes;
                        }
                    }
                }
                foreach (var item in dictionary) {
                    Console.WriteLine(item.Key + ": " + item.Value);
                }
            }
            catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }


        }
    }
}
