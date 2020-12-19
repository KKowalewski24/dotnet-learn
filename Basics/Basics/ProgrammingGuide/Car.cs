using System;

namespace Basics.ProgrammingGuide {

    public class Car : IComparable<Car> {

        /*------------------------ FIELDS REGION ------------------------*/
        public string Name { get; set; }
        public string Color { get; set; }
        public int Speed { get; set; }

        /*------------------------ METHODS REGION ------------------------*/
        public Car() {
        }

        public Car(string name, string color, int speed) {
            Name = name;
            Color = color;
            Speed = speed;
        }

        public int CompareTo(Car other) {
            // Compare the colors.
            int compare = string.Compare(Color, other.Color, true);

            // If the colors are the same, compare the speeds.
            if (compare == 0) {
                compare = Speed.CompareTo(other.Speed);
                compare -= compare;
            }

            return compare;
        }

        public override string ToString() {
            return $"{nameof(Name)}: {Name}, " +
                   $"{nameof(Color)}: {Color}, " +
                   $"{nameof(Speed)}: {Speed}";
        }

    }

}
