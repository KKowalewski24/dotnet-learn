using System;
using System.Collections.Generic;
using System.Linq;

namespace Basics.Concepts.Linq {

    public class FilterQuery {

        /*------------------------ FIELDS REGION ------------------------*/

        /*------------------------ METHODS REGION ------------------------*/
        public void Usage(IList<Student> students) {
            string[] ids = { "111", "114", "112" };

            QueryByID(students, ids);
            QueryByYear(students, GradeLevel.SecondYear);
        }

        private void QueryByYear(IList<Student> students, GradeLevel year) {
            IEnumerable<Student> studentQuery =
                from student in students
                where student.Year == year
                select student;

            Console.WriteLine($"The following students are at level {year}");
            foreach (Student name in studentQuery) {
                Console.WriteLine($"{name.LastName}: {name.Id}");
            }
        }

        private void QueryByID(IList<Student> students, string[] ids) {
            IEnumerable<Student> queryNames =
                from student in students
                let studentId = student.Id.ToString()
                where ids.Contains(studentId)
                select student;

            foreach (Student name in queryNames) {
                Console.WriteLine($"{name.LastName}: {name.Id}");
            }
        }

    }

}
