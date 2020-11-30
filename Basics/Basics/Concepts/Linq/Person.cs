namespace Basics.Concepts.Linq {

    public class Person {

        /*------------------------ FIELDS REGION ------------------------*/
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        /*------------------------ METHODS REGION ------------------------*/
        public Person(string firstName, string lastName) {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString() {
            return $"{nameof(FirstName)}: {FirstName}, " +
                   $"{nameof(LastName)}: {LastName}";
        }

    }

}
