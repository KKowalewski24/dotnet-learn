using SampleLibrary;

namespace Basics.Concepts {

    public class ConceptsMain {

        /*------------------------ FIELDS REGION ------------------------*/

        /*------------------------ METHODS REGION ------------------------*/
        public void Main() {
            LibraryUsage();
        }

        private void LibraryUsage() {
            SampleLibraryClass sampleLibraryClass = new SampleLibraryClass();
            sampleLibraryClass.Print();
        }

    }

}
