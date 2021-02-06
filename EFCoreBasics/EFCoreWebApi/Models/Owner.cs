using System.Collections.Generic;

namespace EFCoreWebApi.Models {

    public class Owner : BaseEntity {

        /*------------------------ FIELDS REGION ------------------------*/
        private readonly IList<Pet> _pets = new List<Pet>();

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public IEnumerable<Pet> Pets => _pets;

        /*------------------------ METHODS REGION ------------------------*/
        protected Owner() {
        }

        public Owner(string firstName, string lastName) {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString() {
            return $"{base.ToString()}, " +
                   $"{nameof(FirstName)}: {FirstName}, " +
                   $"{nameof(LastName)}: {LastName}, " +
                   $"{nameof(Pets)}: {Pets}";
        }

    }

}
