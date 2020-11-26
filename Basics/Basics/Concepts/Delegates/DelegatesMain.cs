using System;

namespace Basics.Concepts.Delegates {

    public class DelegatesMain {

        /*------------------------ FIELDS REGION ------------------------*/

        /*------------------------ METHODS REGION ------------------------*/
        public void Main() {
            DisplayAddedNumbers((num1, num2) => num1 + num2, 5, 10);
            DisplayAddedNumbers((num1, num2) => num1 - num2, 5, 10);
            DisplayAddedNumbers(Add, 5, 10);
            DisplayAddedNumbers(addFunction, 5, 10);

            int addFunction(int num1, int num2) {
                return num1 + num2;
            }

            DisplaySubtractedNumbers((num1, num2) => num1 - num2, 50, 10);
        }

        private int Add(int num1, int num2) {
            return num1 + num2;
        }

        private void DisplayAddedNumbers(AddNumbers addNumbers, int num1, int num2) {
            Console.WriteLine(addNumbers(num1, num2));
        }

        private void DisplaySubtractedNumbers(Func<int, int, int> addNumbers, int num1, int num2) {
            Console.WriteLine(addNumbers(num1, num2));
        }

    }

}
