using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Basics.ProgrammingGuide.CustomCollection;
using Basics.ProgrammingGuide.Iterators;
using Basics.ProgrammingGuide.Linq;

namespace Basics.ProgrammingGuide {

    public class ProgrammingGuideMain {

        /*------------------------ FIELDS REGION ------------------------*/

        /*------------------------ METHODS REGION ------------------------*/
        public void Main() {
            WriteReadToFile();
            PrintAuthorInfo(typeof(SampleClass));
            SortCarsExample();
            ListColors();
            IteratorsUsage();
            new LinqUsage().Main();
        }

        private void WriteReadToFile() {
            Person person = new Person("first", "last");
            const string filename = "person.txt";

            if (File.Exists(filename)) {
                File.Delete(filename);
            }

            IFormatter formatter = new BinaryFormatter();

            using (FileStream stream = new FileStream(filename, FileMode.Create)) {
                formatter.Serialize(stream, person);
            }

            Person person2;
            using (FileStream stream = new FileStream(filename, FileMode.Open, FileAccess.Read)) {
                person2 = (Person) formatter.Deserialize(stream);
            }

            Console.WriteLine(person2);
        }

        private void PrintAuthorInfo(Type type) {
            Attribute.GetCustomAttributes(type).ToList().ForEach((attribute) => {
                if (attribute is AuthorAttribute authorAttribute) {
                    Console.WriteLine($"{authorAttribute.Name}, {authorAttribute.Version}");
                }
            });
        }

        private void SortCarsExample() {
            List<Car> cars = new List<Car> {
                new Car("car1", "blue", 20),
                new Car("car2", "red", 50),
                new Car("car3", "green", 10),
                new Car("car4", "blue", 50),
                new Car("car5", "blue", 30),
                new Car("car6", "red", 60),
                new Car("car7", "green", 50)
            };

            PrintCars(cars);
            cars.Sort();
            PrintCars(cars);
        }

        private void PrintCars(List<Car> cars) {
            foreach (Car car in cars) {
                Console.WriteLine(car);
            }

            Console.WriteLine("------------------------");
        }

        private void ListColors() {
            AllColors colors = new AllColors();

            foreach (Color color in colors) {
                Console.Write(color.Name + " ");
            }

            Console.WriteLine();
        }

        private void IteratorsUsage() {
            Zoo zoo = new Zoo();
            zoo.AddMammal("Whale");
            zoo.AddMammal("Rhinoceros");
            zoo.AddBird("Penguin");
            zoo.AddBird("Warbler");

            PrintAnimalName(zoo);
            PrintAnimalName(zoo.Birds);
            PrintAnimalName(zoo.Mammals);
        }

        private void PrintAnimalName(IEnumerable zooItems) {
            foreach (string name in zooItems) {
                Console.Write(name + " ");
            }

            Console.WriteLine();
        }

    }

}
