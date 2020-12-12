using System.Collections.Generic;

namespace Basics.ProgrammingGuide.Linq {

    public class Student {

        /*------------------------ FIELDS REGION ------------------------*/
        public int ID { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public List<int> Scores;

        /*------------------------ METHODS REGION ------------------------*/
        public Student() {
        }

        public Student(List<int> scores, int id, string first,
                       string last, string street, string city) {
            Scores = scores;
            ID = id;
            First = first;
            Last = last;
            Street = street;
            City = city;
        }

        public override string ToString() {
            return $"{nameof(Scores)}: {Scores}, " +
                   $"{nameof(ID)}: {ID}, " +
                   $"{nameof(First)}: {First}, " +
                   $"{nameof(Last)}: {Last}, " +
                   $"{nameof(Street)}: {Street}, " +
                   $"{nameof(City)}: {City}";
        }

    }

}
