using System.Collections.Generic;

namespace Basics.ProgrammingGuide {

    public class Bouquet {

        /*------------------------ FIELDS REGION ------------------------*/
        public IList<string> Flowers { get; set; }

        /*------------------------ METHODS REGION ------------------------*/
        public Bouquet(IList<string> flowers) {
            Flowers = flowers;
        }

    }

}
