using System;
using System.Collections.Generic;
using System.Linq;

namespace Basics.Concepts.Linq {

    public class JoinQuery {

        /*------------------------ FIELDS REGION ------------------------*/

        /*------------------------ METHODS REGION ------------------------*/
        public void Usage() {
            InnerJoin();
        }

        private void InnerJoin() {
            Person magnus = new Person("Magnus", "Hedlund");
            Person terry = new Person("Terry", "Adams");
            Person charlotte = new Person("Charlotte", "Weiss");
            Person arlene = new Person("Arlene", "Huff");
            Person rui = new Person("Rui", "Raposo");

            Pet barley = new Pet("Barley", terry);
            Pet boots = new Pet("Boots", terry);
            Pet whiskers = new Pet("Whiskers", charlotte);
            Pet bluemoon = new Pet("Blue Moon", rui);
            Pet daisy = new Pet("Daisy", magnus);

            List<Person> people = new List<Person> {magnus, terry, charlotte, arlene, rui};
            List<Pet> pets = new List<Pet> {barley, boots, whiskers, bluemoon, daisy};

            var personPet =
                from person in people
                join pet in pets on person equals pet.Owner
                select new {OwnerName = person.LastName, PetName = pet.Name};

            foreach (var item in personPet) {
                Console.WriteLine($"\"{item.OwnerName}\" is owned by {item.PetName}");
            }
        }

    }

}
