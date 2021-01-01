namespace Basics.ProgrammingGuide.Generics {

    public class GenericsMain {

        /*------------------------ FIELDS REGION ------------------------*/

        /*------------------------ METHODS REGION ------------------------*/
        public void Main() {
            SampleGeneric<Person> sampleGeneric = new SampleGeneric<Person>(
                "Abc", new string[] { "Cde" }
            );
        }

    }

}
