using System.Collections.Generic;

namespace Basics.ProgrammingGuide.Properties {

    public class Date {

        /*------------------------ FIELDS REGION ------------------------*/
        private int _month = 7;
        private readonly IList<int> _monthsNumbers = new List<int>();

        public int Month {
            get => _month;
            set {
                if (value > 0 && value < 13) {
                    _month = value;
                }
            }
        }

        public IList<int> MonthsNumber => _monthsNumbers;

        /*------------------------ METHODS REGION ------------------------*/
        public Date() {
            for (int i = 0; i < 12; i++) {
                _monthsNumbers.Add(i);
            }
        }

    }

}
