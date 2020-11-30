using System;
using System.Collections.Generic;
using System.Linq;

namespace Basics.Concepts.Linq {

    public class LinqMain {

        /*------------------------ FIELDS REGION ------------------------*/
        private IList<Student> _students = new List<Student> {
            new Student(
                "Terry", "Adams", 120,
                GradeLevel.SecondYear,
                new List<int> {99, 82, 81, 79}
            ),
            new Student(
                "Fadi", "Fakhouri", 116,
                GradeLevel.ThirdYear,
                new List<int> {99, 86, 90, 94}
            ),
            new Student(
                "Hanying", "Feng", 117,
                GradeLevel.FirstYear,
                new List<int> {93, 92, 80, 87}
            ),
            new Student(
                "Cesar", "Garcia", 114,
                GradeLevel.FourthYear,
                new List<int> {97, 89, 85, 82}
            ),
            new Student(
                "Debra", "Garcia", 115,
                GradeLevel.ThirdYear,
                new List<int> {35, 72, 91, 70}
            ),
            new Student(
                "Hugo", "Garcia", 118,
                GradeLevel.SecondYear,
                new List<int> {92, 90, 83, 78}
            ),
            new Student(
                "Sven", "Mortensen", 113,
                GradeLevel.FirstYear,
                new List<int> {88, 94, 65, 91}
            ),
            new Student(
                "Claire", "O'Donnell", 112,
                GradeLevel.FourthYear,
                new List<int> {75, 84, 91, 39}
            ),
            new Student(
                "Svetlana", "Omelchenko", 111,
                GradeLevel.SecondYear,
                new List<int> {97, 92, 81, 60}
            ),
            new Student(
                "Lance", "Tucker", 119,
                GradeLevel.ThirdYear,
                new List<int> {68, 79, 88, 92}
            ),
            new Student(
                "Michael", "Tucker", 122,
                GradeLevel.FirstYear,
                new List<int> {94, 92, 91, 91}
            ),
            new Student(
                "Eugene", "Zabokritski", 121,
                GradeLevel.FourthYear,
                new List<int> {96, 85, 91, 60}
            )
        };

        /*------------------------ METHODS REGION ------------------------*/
        public void Main() {
            const int scoreThreshold = 80;
            int[] scores = {97, 92, 81, 60};

            int[] numbers = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            string[] words = {"a", "b", "c", "d", "e", "f", "g", "h", "i"};

            IList<Country> countries = new List<Country> {
                new Country("Germany", 101),
                new Country("Poland", 102),
                new Country("Austria", 103),
                new Country("Switzerland", 104)
            };

            // QueryPlayground queryPlayground = new QueryPlayground();
            // queryPlayground.QueryWithoutTypeConversion(scores, scoreThreshold);
            // queryPlayground.QueryWithTypeConversion(scores, scoreThreshold);
            // queryPlayground.QuerySingleData(scores, scoreThreshold);
            // queryPlayground.MethodApproach(scores, scoreThreshold);
            // queryPlayground.MultipleDataSources(numbers, words);
            // queryPlayground.GroupUsage(countries);
            // queryPlayground.NewTypeUsage(countries);
            // queryPlayground.LetUsage();

            // MethodSyntax methodSyntax = new MethodSyntax();
            // methodSyntax.Usage();
            QueryHighScores(1, 90);
        }

        public void QueryHighScores(int examNumber, int score) {
            var highScores =
                from student in _students
                where student.ExamScores[examNumber] > score
                select new {Name = student.FirstName, Score = student.ExamScores[examNumber]};

            foreach (var item in highScores) {
                Console.WriteLine($"{item.Name,-15}{item.Score}");
            }
        }

        private int GetPercentile(Student student) {
            double average = student.ExamScores.Average();
            return average > 0 ? (int) average / 10 : 0;
        }

    }

}
