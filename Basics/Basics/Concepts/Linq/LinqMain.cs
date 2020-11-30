using System.Collections.Generic;

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

            // QueryPlayground queryPlayground = new QueryPlayground();
            // queryPlayground.QueryWithoutTypeConversion(scores, scoreThreshold);
            // queryPlayground.QueryWithTypeConversion(scores, scoreThreshold);
            // queryPlayground.QuerySingleData(scores, scoreThreshold);
            // queryPlayground.MethodApproach(scores, scoreThreshold);
            // queryPlayground.MultipleDataSources(numbers, words);
            // queryPlayground.GroupUsage(countries);
            // queryPlayground.NewTypeUsage(countries);
            // queryPlayground.LetUsage();

            MethodSyntax methodSyntax = new MethodSyntax();
            methodSyntax.Usage();
        }

    }

}
