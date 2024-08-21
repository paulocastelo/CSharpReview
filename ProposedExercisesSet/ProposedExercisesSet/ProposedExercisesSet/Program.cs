using ProposedExercisesSet.Entities;
namespace ProposedExercisesSet {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("How many students are for course A? ");
            int studentsA = int.Parse(Console.ReadLine());

            HashSet<StudentCourse> students = new HashSet<StudentCourse>();

            for (int i = 0; i < studentsA; i++) {
                Console.Write("Enter the student's code for course A: ");
                int code = int.Parse(Console.ReadLine());
                string course = "A";
                students.Add(new StudentCourse(code, course));
            }

            Console.Write("How many students are for course B? ");
            int studentsB = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentsB; i++) {
                Console.Write("Enter the student's code for course B: ");
                int code = int.Parse(Console.ReadLine());
                string course = "B";
                students.Add(new StudentCourse(code, course));
            }

            Console.Write("How many students are for course C? ");
            int studentsC = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentsC; i++) {
                Console.Write("Enter the student's code for course C: ");
                int code = int.Parse(Console.ReadLine());
                string course = "C";
                students.Add(new StudentCourse(code, course));
            }

            Console.WriteLine("Total students: " + students.Count);


        }
    }
}
