using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapesInterfaceAndHeritance.Model.Enums;
using ShapesInterfaceAndHeritance.Model.Entities;

namespace ShapesInterfaceAndHeritance.Model.Entities {
    abstract class AbstractShape : IShape {
        public Color color { get; set; }
        public abstract double Area();
    }
}
