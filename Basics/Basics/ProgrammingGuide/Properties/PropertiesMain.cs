using System;

namespace Basics.ProgrammingGuide.Properties {

    public class PropertiesMain {

        /*------------------------ FIELDS REGION ------------------------*/

        /*------------------------ METHODS REGION ------------------------*/
        public void Main() {
            TimePeriod timePeriod = new TimePeriod();
            timePeriod.Hours = 24;
            Console.WriteLine($"Time in hours: {timePeriod.Hours}");

            Person person = new Person("Magnus", "Hedlund");
            Console.WriteLine(person.Name);

            SaleItem item = new SaleItem("Shoes", 19.95m);
            Console.WriteLine($"{item.Name}: sells for {item.Price:C2}");
        }

    }

}
