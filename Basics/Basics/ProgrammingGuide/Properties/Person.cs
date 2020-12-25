namespace Basics.ProgrammingGuide.Properties {

    public class Person {

        /*------------------------ FIELDS REGION ------------------------*/
        private readonly string _firstName;
        private readonly string _lastName;

        public string Name => $"{_firstName} {_lastName}";

        /*------------------------ METHODS REGION ------------------------*/
        public Person(string firstName, string lastName) {
            _firstName = firstName;
            _lastName = lastName;
        }

    }

}
