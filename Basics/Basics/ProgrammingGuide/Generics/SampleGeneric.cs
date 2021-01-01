namespace Basics.ProgrammingGuide.Generics {

    public class SampleGeneric<T> : Market where T : Person {

        /*------------------------ FIELDS REGION ------------------------*/

        /*------------------------ METHODS REGION ------------------------*/
        public SampleGeneric(string name, string[] items)
            : base(name, items) {
        }

    }

}
