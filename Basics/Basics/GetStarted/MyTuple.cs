namespace Basics.GetStarted {

    public class MyTuple {

        /*------------------------ FIELDS REGION ------------------------*/
        private double number;
        private string text;

        /*------------------------ METHODS REGION ------------------------*/
        public MyTuple(double number, string text) {
            this.number = number;
            this.text = text;
        }

        public override string ToString() {
            return $"{nameof(number)}: {number}, {nameof(text)}: {text}";
        }

    }

}
