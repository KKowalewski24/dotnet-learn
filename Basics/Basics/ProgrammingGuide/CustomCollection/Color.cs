namespace Basics.ProgrammingGuide.CustomCollection {

    public class Color {

        /*------------------------ FIELDS REGION ------------------------*/
        public string Name { get; set; }

        /*------------------------ METHODS REGION ------------------------*/
        public Color(string name) {
            Name = name;
        }

        public override string ToString() {
            return $"{nameof(Name)}: {Name}";
        }

    }

}
