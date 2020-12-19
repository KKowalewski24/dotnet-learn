using System;
using System.Collections.Generic;
using System.Linq;

namespace Basics.ProgrammingGuide {

    public class QuantifierOperations {

        /*------------------------ FIELDS REGION ------------------------*/
        private readonly List<Market> _markets = new List<Market> {
            new Market("Emily's", new[] {"kiwi", "cheery", "banana"}),
            new Market("Kim's", new[] {"melon", "mango", "olive"}),
            new Market("Adam's", new[] {"kiwi", "apple", "orange"})
        };

        /*------------------------ METHODS REGION ------------------------*/
        public void Main() {
            IEnumerable<string> namesAll =
                from market in _markets
                where market.Items.All((item) => item.Length == 5)
                select market.Name;

            PrintResult(namesAll);

            IEnumerable<string> namesAny =
                from market in _markets
                where market.Items.Any((item) => item.StartsWith("o"))
                select market.Name;

            PrintResult(namesAny);

            IEnumerable<string> namesContains =
                from market in _markets
                where market.Items.Contains("kiwi")
                select market.Name;

            PrintResult(namesContains);
        }

        private void PrintResult(IEnumerable<string> names) {
            foreach (string name in names) {
                Console.Write(name + " ");
            }

            Console.WriteLine();
        }

    }

}
