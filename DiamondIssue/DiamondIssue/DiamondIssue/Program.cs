using DiamondIssue.Devices;

namespace DiamondIssue {
    internal class Program {
        static void Main(string[] args) {
            Printer printer = new Printer(1080);
            printer.ProcessDoc("My letter");
            printer.Print("My letter");

            Scanner scanner = new Scanner(2003);
            scanner.ProcessDoc("My email");
            System.Console.WriteLine(scanner.Scan());

            ComboDevice comboDevice = new ComboDevice(3921);
            comboDevice.ProcessDoc("My dissertation");
            comboDevice.Print("My dissertation");
            System.Console.WriteLine(comboDevice.Scan());

        }
    }
}
