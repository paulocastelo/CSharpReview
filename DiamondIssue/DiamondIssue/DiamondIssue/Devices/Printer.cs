using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondIssue.Devices {
    internal class Printer : Device, IPrinter {
        public Printer(int serialNumber) : base(serialNumber) {
        }

        public void Print(string document) {
            Console.WriteLine("Printer printing: " + document);
        }

        public override void ProcessDoc(string document) {
            Console.WriteLine("Printer processing: " + document);
        }
    }
}
