using System;

namespace Basics.Concepts {

    public class Discard {

        /*------------------------ FIELDS REGION ------------------------*/

        /*------------------------ METHODS REGION ------------------------*/
        public void DisplayTuple() {
            (_, int num1, int num2) = PrepareTuple();
            Console.WriteLine($"{num1}, {num2}");
        }

        private (string, int, int) PrepareTuple() {
            return ("xxx", 15, 20);
        }

    }

}
