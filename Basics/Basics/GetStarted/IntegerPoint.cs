namespace Basics.GetStarted {

    public class IntegerPoint : Point<int, int> {

        /*------------------------ FIELDS REGION ------------------------*/
        public int Sum { get; private set; }

        /*------------------------ METHODS REGION ------------------------*/
        public IntegerPoint(int x, int y)
            : base(x, y) {
        }

        public IntegerPoint(int x, int y, int sum)
            // This is the way to call another ctor in current class
            : this(x, y) {
            Sum = sum;
        }

    }

}
