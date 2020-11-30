namespace Basics.Concepts.Linq {

    public class Pet {

        /*------------------------ FIELDS REGION ------------------------*/
        public string Name { get; private set; }
        public Person Owner { get; private set; }

        /*------------------------ METHODS REGION ------------------------*/
        public Pet(string name, Person owner) {
            Name = name;
            Owner = owner;
        }

        public override string ToString() {
            return $"{nameof(Name)}: {Name}, " +
                   $"{nameof(Owner)}: {Owner}";
        }

    }

}
