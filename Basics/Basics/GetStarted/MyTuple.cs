namespace Basics.GetStarted {

    public class MyTuple {

        /*------------------------ FIELDS REGION ------------------------*/
        (double, int) tup;

        /*------------------------ METHODS REGION ------------------------*/
        public MyTuple((double, int) tup) {
            this.tup = tup;
        }

        public override string ToString() {
            return $"{nameof(tup)}: {tup}";
        }

    }

}
