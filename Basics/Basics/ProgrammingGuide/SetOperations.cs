using System;
using System.Collections.Generic;
using System.Linq;

namespace Basics.ProgrammingGuide {

    public class SetOperations {

        /*------------------------ FIELDS REGION ------------------------*/
        private readonly string[] _planets = {
            "Mercury", "Venus", "Venus", "Earth", "Mars", "Earth"
        };

        private readonly string[] planets1 = {
            "Mercury", "Venus", "Earth", "Jupiter"
        };

        private readonly string[] planets2 = {
            "Mercury", "Earth", "Mars", "Jupiter"
        };

        /*------------------------ METHODS REGION ------------------------*/
        public void Main() {
            DistinctUsage();
            Console.WriteLine("-----------------------------------");
            ExceptUsage();
            Console.WriteLine("-----------------------------------");
            IntersectUsage();
            Console.WriteLine("-----------------------------------");
            UnionUsage();
        }

        private void DistinctUsage() {
            IEnumerable<IEnumerable<char>> distinctPlanets =
                from planet in _planets.Distinct()
                select planet;

            foreach (var planet in distinctPlanets) {
                Console.Write(planet + " ");
            }

            Console.WriteLine();
        }

        private void ExceptUsage() {
            IEnumerable<string> exceptPlanets =
                from planet in planets1.Except(planets2)
                select planet;

            foreach (string exceptPlanet in exceptPlanets) {
                Console.Write(exceptPlanet + " ");
            }

            Console.WriteLine();
        }

        private void IntersectUsage() {
            IEnumerable<string> exceptPlanets =
                from planet in planets1.Intersect(planets2)
                select planet;

            foreach (string exceptPlanet in exceptPlanets) {
                Console.Write(exceptPlanet + " ");
            }

            Console.WriteLine();
        }

        private void UnionUsage() {
            IEnumerable<string> exceptPlanets =
                from planet in planets1.Union(planets2)
                select planet;

            foreach (string exceptPlanet in exceptPlanets) {
                Console.Write(exceptPlanet + " ");
            }

            Console.WriteLine();
        }

    }

}
