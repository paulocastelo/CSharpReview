using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapesInterfaceAndHeritance.Model.Enums;

namespace ShapesInterfaceAndHeritance.Model.Entities {
    class Circle : AbstractShape {
        public double Radius { get; set; }

        public override double Area() {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override string ToString() {
            return "Circle color: "
                + color
                + ", radius: "
                + Radius.ToString("F2",CultureInfo.InvariantCulture)
                + ", area: "
                + Area().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
