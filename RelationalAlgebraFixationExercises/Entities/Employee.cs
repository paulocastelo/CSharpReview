using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationalAlgebraFixationExercises.Entities {
    class Employee {
        private static int nextId = 1;

        public int Id { get; private set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee() {
            Id = nextId++;
        }

        public Employee(string name, double salary) {
            Id = nextId++;
            Name = name;
            Salary = salary;
        }

        public Employee(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
            if (id >= nextId) {
                nextId = id + 1;
            }
        }

        public override string ToString() {
            return Id + ", " + Name + ", " + Salary;
        }
    }
}
