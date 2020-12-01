namespace Basics.Tutorials {

    public abstract class Shape {

        /*------------------------ FIELDS REGION ------------------------*/
        public abstract double Area { get; }
        public abstract double Perimeter { get; }

        /*------------------------ METHODS REGION ------------------------*/
        public static double GetArea(Shape shape) {
            return shape.Area;
        }

        public static double GetPerimeter(Shape shape) {
            return shape.Perimeter;
        }

        public override string ToString() {
            return GetType().Name;
        }

    }

}
