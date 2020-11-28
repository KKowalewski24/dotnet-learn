namespace Basics.Concepts.Linq {

    public class Country {

        /*------------------------ FIELDS REGION ------------------------*/
        public string Name { get; private set; }

        public int PostalCode { get; private set; }

        /*------------------------ METHODS REGION ------------------------*/
        public Country(string name, int postalCode) {
            Name = name;
            PostalCode = postalCode;
        }

        public override string ToString() {
            return $"{nameof(Name)}: {Name}, {nameof(PostalCode)}: {PostalCode}";
        }

    }

}
