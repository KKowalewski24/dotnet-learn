namespace Basics.GetStarted {

    public class Point<T1, T2> {

        /*------------------------ FIELDS REGION ------------------------*/
        public static int num { get; set; }

        public T1 X { get; private set; }
        public T2 Y { get; private set; }

        /*------------------------ METHODS REGION ------------------------*/
        static Point() {
            num = 7;
        }

        public Point(T1 x, T2 y) {
            X = x;
            Y = y;
        }

    }

}
