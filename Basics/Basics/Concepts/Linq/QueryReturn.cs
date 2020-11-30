using System;
using System.Collections.Generic;
using System.Linq;

namespace Basics.Concepts.Linq {

    public class QueryReturn {

        /*------------------------ FIELDS REGION ------------------------*/

        /*------------------------ METHODS REGION ------------------------*/
        public void Usage() {
            int[] nums = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            Console.WriteLine("Results of executing myQuery1:");
            IEnumerable<string> myQuery1 = QueryMethod1(ref nums);

            foreach (string s in myQuery1) {
                PrintWithSpace(s);
            }

            Console.WriteLine("\nResults of executing myQuery1 directly:");

            foreach (string s in QueryMethod1(ref nums)) {
                PrintWithSpace(s);
            }

            Console.WriteLine("\nResults of executing myQuery2:");
            QueryMethod2(ref nums, out IEnumerable<string> myQuery2);

            foreach (string s in myQuery2) {
                PrintWithSpace(s);
            }

            myQuery1 =
                from item in myQuery1
                orderby item descending
                select item;

            Console.WriteLine("\nResults of executing modified myQuery1:");
            foreach (string s in myQuery1) {
                PrintWithSpace(s);
            }
        }

        private IEnumerable<string> QueryMethod1(ref int[] ints) {
            return
                from i in ints
                where i > 4
                select i.ToString();
        }

        private void QueryMethod2(ref int[] ints, out IEnumerable<string> returnQ) {
            returnQ =
                from i in ints
                where i < 4
                select i.ToString();
        }

        private void PrintWithSpace(string text) {
            Console.Write(text + " ");
        }

    }

}
