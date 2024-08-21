using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondIssue.Devices {
    abstract class Device {
        public int SerialNumber { get; set; }

        public abstract void ProcessDoc(string document);
        public Device(int serialNumber) {
            SerialNumber = serialNumber;
        }
    }
}
