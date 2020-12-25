namespace Basics.ProgrammingGuide {

    public class Market {

        /*------------------------ FIELDS REGION ------------------------*/
        public string Name { get; set; }
        public string[] Items { get; set; }

        /*------------------------ METHODS REGION ------------------------*/
        public Market(string name, string[] items) {
            Name = name;
            Items = items;
        }

        public override string ToString() {
            return $"{nameof(Name)}: {Name}, " +
                   $"{nameof(Items)}: {Items}";
        }

    }

}
