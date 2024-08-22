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
        public string Email { get; set; }
        public double Salary { get; set; }

        public Employee() {}

        public Employee(string name, string email, double salary) {
            Id = nextId++;
            Name = name;
            Email = email;
            Salary = salary;
        }

        public override string ToString() {
            return Id + ", " + Name + ", " + Salary;
        }
    }
}
