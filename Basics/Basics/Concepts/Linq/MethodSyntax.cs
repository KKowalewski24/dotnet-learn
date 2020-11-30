using System;
using System.Collections.Generic;
using System.Linq;

namespace Basics.Concepts.Linq {

    public class MethodSyntax {

        /*------------------------ FIELDS REGION ------------------------*/

        /*------------------------ METHODS REGION ------------------------*/
        public void Usage() {
            IList<int> numbers1 = new List<int> {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            IList<int> numbers2 = new List<int> {15, 14, 11, 13, 19, 18, 16, 17, 12, 10};

            double average = numbers1.Average();
            Console.WriteLine($"average: {average}");

            IEnumerable<int> concatenation = numbers1.Concat(numbers2);
            foreach (int number in concatenation) {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            IEnumerable<int> numbersGreater15 = concatenation.Where((number) => number > 15);
            foreach (int number in numbersGreater15) {
                Console.WriteLine($"number: {number}");
            }

            Console.WriteLine("------------------------");

            foreach (int number in concatenation.Where((number) => number < 15).ToList()) {
                Console.WriteLine($"number: {number}");
            }

            Console.WriteLine("------------------------");

            concatenation.Where((number) => number < 15).ToList().ForEach((number) => {
                Console.WriteLine($"number: {number}");
            });
            
            Console.WriteLine("------------------------");
        }

    }

}
