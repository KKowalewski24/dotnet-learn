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

            QueryWithoutTypeConversion(scores, scoreThreshold);
            QueryWithTypeConversion(scores, scoreThreshold);
            QuerySingleData(scores, scoreThreshold);
            MethodApproach(scores, scoreThreshold);
        }

        private static void QueryWithoutTypeConversion(int[] scores, int scoreThreshold) {
            IEnumerable<int> scoresQuery =
                from score in scores
                where score > scoreThreshold
                select score;

            scoresQuery.ToList().ForEach((score) => Console.Write($"{score} "));
            Console.WriteLine();
        }

        private static void QueryWithTypeConversion(int[] scores, int scoreThreshold) {
            IEnumerable<string> scoresQuery =
                from score in scores
                where score > scoreThreshold
                select $"The score is {score}";

            scoresQuery.ToList().ForEach(Console.WriteLine);
        }

        private static void QuerySingleData(int[] scores, int scoreThreshold) {
            int scoresCount = (
                from score in scores
                where score > scoreThreshold
                select score
            ).Count();

            Console.WriteLine(scoresCount);
        }

        private static void MethodApproach(int[] scores, int scoreThreshold) {
            IEnumerable<int> results = scores.Where((score) => score > scoreThreshold);
            results.ToList().ForEach((score) => Console.Write($"{score} "));
            Console.WriteLine();
        }

    }

}
