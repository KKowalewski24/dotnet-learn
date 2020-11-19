using System;

namespace Basics.Tutorials {

    public class Square : Shape {

        /*------------------------ FIELDS REGION ------------------------*/
        public double Side { get; }

        /*------------------------ METHODS REGION ------------------------*/
        public Square(double side) {
            Side = side;
        }

        public override double Area => Math.Pow(Side, 2);

        public override double Perimeter => Side * 4;

        public double Diagonal => Math.Round(Math.Sqrt(2) * Side, 2);

    }

}
