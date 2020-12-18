using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Basics.ProgrammingGuide.Linq {

    public class LinqUsage {

        /*------------------------ FIELDS REGION ------------------------*/
        private readonly List<Student> _students = new List<Student> {
            new Student {
                First = "Svetlana",
                Last = "Omelchenko",
                ID = 111,
                Street = "123 Main Street",
                City = "Seattle",
                Scores = new List<int> {97, 92, 81, 60}
            },
            new Student {
                First = "Claire",
                Last = "O’Donnell",
                ID = 112,
                Street = "124 Main Street",
                City = "Redmond",
                Scores = new List<int> {75, 84, 91, 39}
            },
            new Student {
                First = "Sven",
                Last = "Mortensen",
                ID = 113,
                Street = "125 Main Street",
                City = "Lake City",
                Scores = new List<int> {88, 94, 65, 91}
            }
        };

        private readonly List<Teacher> _teachers = new List<Teacher> {
            new Teacher {First = "Ann", Last = "Beebe", ID = 945, City = "Seattle"},
            new Teacher {First = "Alex", Last = "Robinson", ID = 956, City = "Redmond"},
            new Teacher {First = "Michiyo", Last = "Sato", ID = 972, City = "Tacoma"}
        };

        private readonly double[] _radii = { 1, 2, 3 };

        /*------------------------ METHODS REGION ------------------------*/
        public void Main() {
            MultipleInputsToOneSequence();
            XmlFromSource();

            CalculateInQuery();
        }

        private void CalculateInQuery() {
            IEnumerable<double> output = _radii.Select((it) => it * it * Math.PI);
            foreach (double number in output) {
                Console.WriteLine(number);
            }
        }

        private void MultipleInputsToOneSequence() {
            const string seattle = "Seattle";

            IEnumerable<string> peopleInSeattle = (
                from student in _students
                where student.City == seattle
                select student.Last
            ).Concat(
                from teacher in _teachers
                where teacher.City == seattle
                select teacher.Last
            );

            foreach (string person in peopleInSeattle) {
                Console.WriteLine(person);
            }
        }

        private void XmlFromSource() {
            XElement studentToXml = new XElement(
                "Root",
                from student in _students
                let scores = string.Join(",", student.Scores)
                select new XElement(
                    "Student",
                    new XElement("First", student.First),
                    new XElement("Last", student.Last),
                    new XElement("Scores", scores)
                )
            );

            Console.WriteLine(studentToXml);
        }

    }

}
