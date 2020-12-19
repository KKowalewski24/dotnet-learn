using System;
using System.Collections.Generic;
using System.Linq;

namespace Basics.ProgrammingGuide {

    public class SelectMany {

        /*------------------------ FIELDS REGION ------------------------*/
        private readonly IList<string> _words = new List<string> {
            "an", "apple", "a", "day"
        };

        private readonly List<string> _phrases = new List<string> {
            "an apple a day", "the quick brown fox"
        };

        private readonly List<Bouquet> _bouquets = new List<Bouquet> {
            new Bouquet(new List<string> {"sunflower", "daisy", "daffodil", "larkspur"}),
            new Bouquet(new List<string> {"tulip", "rose", "orchid"}),
            new Bouquet(new List<string> {"gladiolis", "lily", "snapdragon", "aster", "protea"}),
            new Bouquet(new List<string> {"larkspur", "lilac", "iris", "dahlia"})
        };

        /*------------------------ METHODS REGION ------------------------*/
        public void Main() {
            FirstSample();
            SecondSample();
        }

        private void FirstSample() {
            IEnumerable<string> selectQuery =
                from word in _words
                select word.Substring(0, 1);
            PrintResult(selectQuery);

            IEnumerable<string> selectManyQuery =
                from phrase in _phrases
                from word in phrase.Split(" ")
                select word;
            PrintResult(selectManyQuery);
        }

        private void PrintResult(IEnumerable<string> names) {
            foreach (string name in names) {
                Console.Write(name + " ");
            }

            Console.WriteLine();
        }

        private void SecondSample() {
            IEnumerable<IList<string>> selectQuery =
                _bouquets.Select((bouquet) => bouquet.Flowers);
            IEnumerable<string> selectManyQuery =
                _bouquets.SelectMany((bouquet) => bouquet.Flowers);

            foreach (IList<string> list in selectQuery) {
                foreach (string item in list) {
                    Console.Write(item + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\n-----------------------------");

            foreach (string item in selectManyQuery) {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }

    }

}
