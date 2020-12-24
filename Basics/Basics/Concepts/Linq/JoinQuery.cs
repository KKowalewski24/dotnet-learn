using System;
using System.Collections.Generic;
using System.Linq;

namespace Basics.Concepts.Linq {

    public class JoinQuery {

        /*------------------------ FIELDS REGION ------------------------*/
        private class Product {

            public string Name { get; set; }
            public int CategoryId { get; set; }

        }

        private class Category {

            public int Id { get; set; }
            public string CategoryName { get; set; }

        }

        /*------------------------ METHODS REGION ------------------------*/
        public void Usage() {
            InnerJoin();
            AnotherExample();
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

            List<Person> people = new List<Person> { magnus, terry, charlotte, arlene, rui };
            List<Pet> pets = new List<Pet> { barley, boots, whiskers, bluemoon, daisy };

            var personPet =
                from person in people
                join pet in pets on person equals pet.Owner
                select new { OwnerName = person.LastName, PetName = pet.Name };

            foreach (var item in personPet) {
                Console.WriteLine($"\"{item.OwnerName}\" is owned by {item.PetName}");
            }
        }

        private void AnotherExample() {
            List<Product> products = new List<Product> {
                new Product {Name = "Cola", CategoryId = 0},
                new Product {Name = "Tea", CategoryId = 0},
                new Product {Name = "Apple", CategoryId = 1},
                new Product {Name = "Kiwi", CategoryId = 1},
                new Product {Name = "Carrot", CategoryId = 2},
            };

            List<Category> categories = new List<Category> {
                new Category {Id = 0, CategoryName = "Beverage"},
                new Category {Id = 1, CategoryName = "Fruit"},
                new Category {Id = 2, CategoryName = "Vegetable"}
            };

            var join1 =
                from product in products
                join category in categories on product.CategoryId equals category.Id
                select new { product.Name, category.CategoryName };

            var join2 =
                from category1 in categories
                join product1 in products on category1.Id equals product1.CategoryId
                select new { product1.Name, category1.CategoryName };

            foreach (var item in join1) {
                Console.WriteLine(item.Name + ", " + item.CategoryName);
            }

            Console.WriteLine("-----------------------------");

            foreach (var item in join2) {
                Console.WriteLine(item.Name + ", " + item.CategoryName);
            }
        }

    }

}
