using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondIssue.Devices {
    class ComboDevice : Device, IPrinter, IScanner{
        public ComboDevice(int serialNumber) : base(serialNumber) {
        }

        public void Print(string document) {
            Console.WriteLine("ComboDevice printing: " + document);
        }

        public string Scan() {
            return "ComboDevice scanning";
        }

        public override void ProcessDoc(string document) {
            Console.WriteLine("ComboDevice processing: " + document);
        }
    }
}
