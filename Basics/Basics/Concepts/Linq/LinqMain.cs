using System;
using System.Collections.Generic;
using System.Linq;

namespace Basics.Concepts.Linq {

    public class LinqMain {

        /*------------------------ FIELDS REGION ------------------------*/
        private readonly StudentsList _studentsList = new StudentsList();

        /*------------------------ METHODS REGION ------------------------*/
        public void Main() {
            const int scoreThreshold = 80;
            int[] scores = { 97, 92, 81, 60 };

            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] words = { "a", "b", "c", "d", "e", "f", "g", "h", "i" };

            IList<Country> countries = new List<Country> {
                new Country("Germany", 101),
                new Country("Poland", 102),
                new Country("Austria", 103),
                new Country("Switzerland", 104)
            };

            QueryPlayground queryPlayground = new QueryPlayground();
            queryPlayground.QueryWithoutTypeConversion(scores, scoreThreshold);
            queryPlayground.QueryWithTypeConversion(scores, scoreThreshold);
            queryPlayground.QuerySingleData(scores, scoreThreshold);
            queryPlayground.MethodApproach(scores, scoreThreshold);
            queryPlayground.MultipleDataSources(numbers, words);
            queryPlayground.GroupUsage(countries);
            queryPlayground.NewTypeUsage(countries);
            queryPlayground.LetUsage();

            new MethodSyntax().Usage();
            QueryHighScores(1, 90);
            new QueryReturn().Usage();
            GroupBySingleProperty();
            GroupBySubstring();
            GroupByRange();
            QueryNestedGroups();
            new FilterQuery().Usage(_studentsList.Students);
            new JoinQuery().Usage();
        }

        private void QueryNestedGroups() {
            IEnumerable<IGrouping<GradeLevel, IGrouping<string, Student>>> queryNestedGroups =
                from student in _studentsList.Students
                group student by student.Year
                into yearGroup
                from lastNameGroup in
                from student in yearGroup
                group student by student.LastName
                group lastNameGroup by yearGroup.Key;

            foreach (IGrouping<GradeLevel, IGrouping<string, Student>> outerGroup in
                queryNestedGroups) {
                Console.WriteLine($"DataClass.Student Level = {outerGroup.Key}");

                foreach (IGrouping<string, Student> innerGroup in outerGroup) {
                    Console.WriteLine($"\tNames that begin with: {innerGroup.Key}");

                    foreach (Student innerGroupElement in innerGroup) {
                        Console.WriteLine(
                            $"\t\t{innerGroupElement.LastName} {innerGroupElement.FirstName}"
                        );
                    }
                }
            }
        }

        private void GroupByRange() {
            IOrderedEnumerable<IGrouping<int, Student>> queryNumericRange =
                from student in _studentsList.Students
                let percentile = GetPercentile(student)
                group student by percentile
                into percentGroup
                orderby percentGroup.Key
                select percentGroup;

            foreach (IGrouping<int, Student> studentGroup in queryNumericRange) {
                Console.WriteLine($"Key: {studentGroup.Key * 10}");
                foreach (Student student in studentGroup) {
                    Console.WriteLine($"\t{student.LastName}, {student.FirstName}, {student.Year}");
                }
            }
        }

        private void GroupBySubstring() {
            IEnumerable<IGrouping<char, Student>> queryFirstLetters =
                from student in _studentsList.Students
                group student by student.LastName[0];

            foreach (var studentGroup in queryFirstLetters) {
                Console.WriteLine($"Key: {studentGroup.Key}");
                foreach (var student in studentGroup) {
                    Console.WriteLine($"\t{student.LastName}, {student.FirstName}");
                }
            }
        }

        private void GroupBySingleProperty() {
            IOrderedEnumerable<IGrouping<string, Student>> queryLastNames =
                from student in _studentsList.Students
                group student by student.LastName
                into newGroup
                orderby newGroup.Key
                select newGroup;

            foreach (var nameGroup in queryLastNames) {
                Console.WriteLine($"Key: {nameGroup.Key}");
                foreach (Student student in nameGroup) {
                    Console.WriteLine($"\t{student.LastName}, {student.FirstName}");
                }
            }
        }

        private void QueryHighScores(int examNumber, int score) {
            var highScores =
                from student in _studentsList.Students
                where student.ExamScores[examNumber] > score
                select new { Name = student.FirstName, Score = student.ExamScores[examNumber] };

            foreach (var item in highScores) {
                Console.WriteLine($"{item.Name,-15}{item.Score}");
            }
        }

        private int GetPercentile(Student student) {
            double average = student.ExamScores.Average();
            return average > 0 ? (int)average / 10 : 0;
        }

    }

}
