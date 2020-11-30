using System;
using System.Collections.Generic;
using System.Linq;

namespace Basics.Concepts.Linq {

    public class LinqMain {

        /*------------------------ FIELDS REGION ------------------------*/

        /*------------------------ METHODS REGION ------------------------*/
        public void Main() {
            const int scoreThreshold = 80;
            int[] scores = {97, 92, 81, 60};

            int[] numbers = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            string[] words = {"a", "b", "c", "d", "e", "f", "g", "h", "i"};

            IList<Country> countries = new List<Country> {
                new Country("Germany", 101),
                new Country("Poland", 102),
                new Country("Austria", 103),
                new Country("Switzerland", 104)
            };

            QueryWithoutTypeConversion(scores, scoreThreshold);
            QueryWithTypeConversion(scores, scoreThreshold);
            QuerySingleData(scores, scoreThreshold);
            MethodApproach(scores, scoreThreshold);
            MultipleDataSources(numbers, words);
            GroupUsage(countries);
            NewTypeUsage(countries);
            LetUsage();
        }

        private void QueryWithoutTypeConversion(int[] scores, int scoreThreshold) {
            IEnumerable<int> scoresQuery =
                from score in scores
                where score > scoreThreshold
                select score;

            scoresQuery.ToList().ForEach((score) => Console.Write($"{score} "));
            Console.WriteLine();
        }

        private void QueryWithTypeConversion(int[] scores, int scoreThreshold) {
            IEnumerable<string> scoresQuery =
                from score in scores
                where score > scoreThreshold
                select $"The score is {score}";

            scoresQuery.ToList().ForEach(Console.WriteLine);
        }

        private void QuerySingleData(int[] scores, int scoreThreshold) {
            int scoresCount = (
                from score in scores
                where score > scoreThreshold
                select score
            ).Count();

            Console.WriteLine(scoresCount);
        }

        private void MethodApproach(int[] scores, int scoreThreshold) {
            IEnumerable<int> results = scores.Where((score) => score > scoreThreshold);
            results.ToList().ForEach((score) => Console.Write($"{score} "));
            Console.WriteLine();
        }

        private void MultipleDataSources(int[] numbers, string[] words) {
            // Remember that this produce - Cartesian product
            IEnumerable<string> result =
                from number in numbers
                from word in words
                select word;

            result.ToList().ForEach((it) => { Console.Write(it + " "); });
            Console.WriteLine();
        }

        private void GroupUsage(IEnumerable<Country> countries) {
            var queryCountryGroups =
                from country in countries
                orderby country.PostalCode descending
                group country by country.Name;
            queryCountryGroups.ToList().ForEach((country) => Console.Write($"{country.Key} "));
            Console.WriteLine();
        }

        private void NewTypeUsage(IEnumerable<Country> countries) {
            var queryNameAndPostalCode =
                from country in countries
                select new {country.Name, country.PostalCode};

            queryNameAndPostalCode.ToList().ForEach((item) => {
                Console.WriteLine($"Name: {item.Name}, Code: {item.PostalCode}");
            });
        }

        private void LetUsage() {
            string[] names = {
                "Svetlana Omelchenko", "Claire O'Donnell", "Sven Mortensen", "Cesar Garcia"
            };

            IEnumerable<string> queryFirstNames =
                from name in names
                let firstName = name.Split(" ")[0]
                select firstName;

            for (int index = 0; index < queryFirstNames.Count(); index++) {
                Console.WriteLine($"{queryFirstNames.ToList()[index]}, index: {index}");
            }
        }

    }

}
