namespace EFCoreWebApi.Models {

    public class Pet : BaseEntity {

        /*------------------------ FIELDS REGION ------------------------*/
        public string Name { get; private set; }
        public Owner Owner { get; private set; }

        /*------------------------ METHODS REGION ------------------------*/
        protected Pet() {
        }

        public Pet(string name) {
            Name = name;
        }

        public Pet(string name, Owner i) {
            Name = name;
            Owner = i;
        }

        public override string ToString() {
            return $"{base.ToString()}, " +
                   $"{nameof(Name)}: {Name}, " +
                   $"{nameof(Owner)}: {Owner}";
        }

    }

}
