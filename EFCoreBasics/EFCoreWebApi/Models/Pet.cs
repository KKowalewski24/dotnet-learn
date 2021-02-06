namespace EFCoreWebApi.Models {

    public class Pet : BaseEntity {

        /*------------------------ FIELDS REGION ------------------------*/
        public string Name { get; private set; }
        public Owner I { get; private set; }

        /*------------------------ METHODS REGION ------------------------*/
        protected Pet() {
        }

        public Pet(string name) {
            Name = name;
        }

        public Pet(string name, Owner i) {
            Name = name;
            I = i;
        }

        public override string ToString() {
            return $"{base.ToString()}, " +
                   $"{nameof(Name)}: {Name}, " +
                   $"{nameof(I)}: {I}";
        }

    }

}
