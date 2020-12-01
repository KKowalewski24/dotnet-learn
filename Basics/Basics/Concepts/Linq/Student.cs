using System.Collections.Generic;

namespace Basics.Concepts.Linq {

    public class Student {

        /*------------------------ FIELDS REGION ------------------------*/
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Id { get; private set; }
        public GradeLevel Year { get; private set; }
        public IList<int> ExamScores { get; private set; }

        /*------------------------ METHODS REGION ------------------------*/
        public Student(string firstName, string lastName, int id,
                       GradeLevel year, IList<int> examScores) {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Year = year;
            ExamScores = examScores;
        }

        public override string ToString() {
            return $"{nameof(FirstName)}: {FirstName}, " +
                   $"{nameof(LastName)}: {LastName}, " +
                   $"{nameof(Id)}: {Id}," +
                   $" {nameof(Year)}: {Year}, " +
                   $"{nameof(ExamScores)}: {ExamScores}";
        }

    }

}
