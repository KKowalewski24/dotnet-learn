namespace Basics.ProgrammingGuide.Properties {

    public class SaleItem {

        /*------------------------ FIELDS REGION ------------------------*/
        private string _name;
        private decimal _cost;

        public string Name {
            get => _name;
            set => _name = value;
        }

        public decimal Price {
            get => _cost;
            set => _cost = value;
        }

        /*------------------------ METHODS REGION ------------------------*/
        public SaleItem(string name, decimal cost) {
            _name = name;
            _cost = cost;
        }

        public override string ToString() {
            return $"{nameof(Name)}: {Name}, " +
                   $"{nameof(Price)}: {Price}";
        }

    }

}
