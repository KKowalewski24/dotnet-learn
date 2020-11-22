using System;
using System.Collections.Generic;
using System.Linq;

namespace Basics.GetStarted {

    public class GetStartedMain {

        /*------------------------ FIELDS REGION ------------------------*/

        /*------------------------ METHODS REGION ------------------------*/
        public void Main() {
            Console.WriteLine("Hello World!");
            int[,] array = new int[5, 5];

            Console.WriteLine(array);
            Point<int, string> point = new Point<int, string>(1, "2");
            Console.WriteLine(point);

            Console.WriteLine(Type.Open);
            Console.WriteLine(Type.Close.ToString());

            Console.WriteLine(new MyTuple((1.5, 2)));

            int i = 1;
            int j = 2;
            Swap(ref i, ref j);
            Console.WriteLine($"{i} {j}");
            Out(out int number);
            Console.WriteLine($"number: {number}");

            Sample(1, 2, 3, 45, 45, "78");

            Person person = new Person(5);
            Console.WriteLine(person);
            List<int> numbers = new List<int>();
            numbers.Add(1);

            numbers.ToList().ForEach((it) => Console.WriteLine(it));
        }

        private void Sample(params object[] args) {
            args.ToList().ForEach((it) => Console.WriteLine(it));
        }

        private void Out(out int num) {
            num = 2;
        }

        private void Swap(ref int x, ref int y) {
            int temp = x;
            x = y;
            y = temp;
        }

    }

}
