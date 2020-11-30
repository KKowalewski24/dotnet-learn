using System.Collections.Generic;

namespace Basics.Concepts.Linq {

    public class StudentsList {

        /*------------------------ FIELDS REGION ------------------------*/
        public IList<Student> Students { get; } = new List<Student> {
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

    }

}
