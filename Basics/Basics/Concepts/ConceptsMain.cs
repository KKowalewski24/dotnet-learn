using System;
using SampleLibrary;

namespace Basics.Concepts {

    public class ConceptsMain {

        /*------------------------ FIELDS REGION ------------------------*/

        /*------------------------ METHODS REGION ------------------------*/
        public void Main() {
            // LibraryUsage();
            // PartialUsage();
            // TupleUsage();
            // InterfaceDefaultImplUsage();
        }

        private static void InterfaceDefaultImplUsage() {
            // First Approach
            var sample = new InterfaceClass();
            var control = sample as IControl;
            control.Paint();
            var surface = sample as IControl;
            surface.Paint();
            
            // Second Approach
            InterfaceClass sample1 = new InterfaceClass();
            IControl control1 = sample1;
            control1.Paint();
            ISurface surface2 = sample1;
            surface2.Paint();
        }

        private void TupleUsage() {

            (string city, int pop, double size) = QueryCityData("New York City");
            Console.WriteLine(city);
            Console.WriteLine(pop);
            Console.WriteLine(size);
        }

        private (string, int, double) QueryCityData(string name) {
            if (name == "New York City") {
                return (name, 8175133, 468.48);
            }

            return ("", 0, 0);
        }

        private void PartialUsage() {

            SamplePartial samplePartial = new SamplePartial();
            samplePartial.PrintAbc();
            samplePartial.PrintCde();
        }

        private void LibraryUsage() {
            SampleLibraryClass sampleLibraryClass = new SampleLibraryClass();
            sampleLibraryClass.Print();
        }

    }

}
