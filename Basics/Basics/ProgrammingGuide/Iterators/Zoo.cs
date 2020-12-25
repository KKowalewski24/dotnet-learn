using System.Collections;
using System.Collections.Generic;

namespace Basics.ProgrammingGuide.Iterators {

    public class Zoo : IEnumerable {

        /*------------------------ FIELDS REGION ------------------------*/
        private readonly IList<Animal> _animals = new List<Animal>();

        public IEnumerable Birds => AnimalsForType(AnimalType.Bird);
        public IEnumerable Mammals => AnimalsForType(AnimalType.Mammal);

        /*------------------------ METHODS REGION ------------------------*/
        public void AddBird(string name) {
            _animals.Add(new Animal(name, AnimalType.Bird));
        }

        public void AddMammal(string name) {
            _animals.Add(new Animal(name, AnimalType.Mammal));
        }

        public IEnumerator GetEnumerator() {
            foreach (Animal animal in _animals) {
                yield return animal.Name;
            }
        }

        private IEnumerable AnimalsForType(AnimalType animalType) {
            foreach (Animal animal in _animals) {
                if (animal.AnimalType == animalType) {
                    yield return animal.Name;
                }
            }
        }

    }

}
