namespace Basics.ProgrammingGuide.Linq {

    public class Teacher {

        /*------------------------ FIELDS REGION ------------------------*/
        public int ID { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public string City { get; set; }

        /*------------------------ METHODS REGION ------------------------*/
        public Teacher() {
        }

        public Teacher(int id, string first, string last, string city) {
            ID = id;
            First = first;
            Last = last;
            City = city;
        }

    }

}
