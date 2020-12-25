namespace Basics.ProgrammingGuide.Iterators {

    public class Animal {

        /*------------------------ FIELDS REGION ------------------------*/
        public string Name { get; private set; }
        public AnimalType AnimalType { get; private set; }

        /*------------------------ METHODS REGION ------------------------*/
        public Animal(string name, AnimalType animalType) {
            Name = name;
            AnimalType = animalType;
        }

        public override string ToString() {
            return $"{nameof(Name)}: {Name}, " +
                   $"{nameof(AnimalType)}: {AnimalType}";
        }

    }

}
