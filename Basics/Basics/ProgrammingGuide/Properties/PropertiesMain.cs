using System;
using System.Collections.Generic;

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

            Date date = new Date();
            IList<int> monthsNumber = date.MonthsNumber;
            Console.WriteLine(monthsNumber.Count);
            monthsNumber.Add(152);
            Console.WriteLine(monthsNumber.Count);
            Console.WriteLine(date.MonthsNumber.Count);
        }

    }

}
