using System;
using System.Collections.Generic;

namespace Basics.Concepts {

    public class Properties {

        /*------------------------ FIELDS REGION ------------------------*/
        public ICollection<string> StringList { get; } = new List<string> {
            "first", "second", "third"
        };

        public string FirstName {
            get => _firstName;
            set {
                if (string.IsNullOrWhiteSpace(value)) {
                    throw new ArgumentException("First name must not be blank");
                }

                _firstName = value;
            }
        }

        private string _firstName;

        /*------------------------ METHODS REGION ------------------------*/

    }

}
