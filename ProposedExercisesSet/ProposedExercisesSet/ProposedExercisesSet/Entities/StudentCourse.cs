using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProposedExercisesSet.Entities;

namespace ProposedExercisesSet.Entities {
    class StudentCourse {
        public int Code { get; set; }
        public string Course { get; set; }

        public StudentCourse(int code) {
            Code = code;
        }

        public StudentCourse(int code, string course) {
            Code = code;
            Course = course;
        }

        public override int GetHashCode() {
            return Code.GetHashCode();
        }

        public override bool Equals(object obj) {
            if (!(obj is StudentCourse)) {
                return false;
            }
            StudentCourse other = obj as StudentCourse;
            return Code.Equals(other.Code);
        }
    }
}
