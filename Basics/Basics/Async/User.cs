namespace Basics.Async {

    public class User {

        /*------------------------ FIELDS REGION ------------------------*/
        public string Name { get; private set; }
        public int Age { get; private set; }

        /*------------------------ METHODS REGION ------------------------*/
        public User(string name, int age) {
            Name = name;
            Age = age;
        }

    }

}
