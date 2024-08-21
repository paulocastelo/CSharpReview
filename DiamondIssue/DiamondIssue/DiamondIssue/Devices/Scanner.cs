using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondIssue.Devices {
    class Scanner : Device, IScanner, IPrinter{
        public Scanner(int serialNumber) : base(serialNumber) {
        }
        public void Print(string document) {
            Console.WriteLine("Scanner printing: " + document);
        }

        public string Scan() {
            return "Scanner scanning";
        }

        public override void ProcessDoc(string document) {
            Console.WriteLine("Scanner processing: " + document);
        }
    }
}
