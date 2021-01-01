using System;

namespace Basics.ProgrammingGuide.Delegates {

    public delegate void StringDelegate(string str);

    public class DelegatesMain {

        /*------------------------ FIELDS REGION ------------------------*/

        /*------------------------ METHODS REGION ------------------------*/
        public void Main() {
            StringDelegate stringDelegate = PrintAndToUpperString;
            stringDelegate += PrintAndToLowerString;

            stringDelegate?.Invoke("Abc");
        }

        private void PrintAndToUpperString(string str) {
            Console.WriteLine(str.ToUpper());
        }

        private void PrintAndToLowerString(string str) {
            Console.WriteLine(str.ToLower());
        }

    }

}
