namespace Basics.GetStarted {

    public class Person {

        /*------------------------ FIELDS REGION ------------------------*/
        public string Name { get; set; }
        public int Age { get; set; }

        /*------------------------ METHODS REGION ------------------------*/
        public Person(int age) {
            Age = age;
        }

        public virtual void Calculate() {

        }

        public override string ToString() {
            return $"{nameof(Name)}: {Name}, {nameof(Age)}: {Age}";
        }

    }

}
