using System;

namespace Basics.ProgrammingGuide.Properties {

    public class TimePeriod {

        /*------------------------ FIELDS REGION ------------------------*/
        public const int SecondsInHour = 3600;

        private double _seconds;

        /*------------------------ METHODS REGION ------------------------*/
        public double Hours {
            get => _seconds / SecondsInHour;
            set {
                if (value < 0 || value > 24) {
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} must be between 0 and 24."
                    );
                }

                _seconds = value * SecondsInHour;
            }
        }

    }

}
