using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Basics.ProgrammingGuide {

    public class ProgrammingGuideMain {

        /*------------------------ FIELDS REGION ------------------------*/

        /*------------------------ METHODS REGION ------------------------*/
        public void Main() {
            WriteReadToFile();
            PrintAuthorInfo(typeof(SampleClass));
        }

        private void WriteReadToFile() {
            Person person = new Person("first", "last");
            const string filename = "person.txt";

            if (File.Exists(filename)) {
                File.Delete(filename);
            }

            IFormatter formatter = new BinaryFormatter();

            using (FileStream stream = new FileStream(filename, FileMode.Create)) {
                formatter.Serialize(stream, person);
            }

            Person person2;
            using (FileStream stream = new FileStream(filename, FileMode.Open, FileAccess.Read)) {
                person2 = (Person) formatter.Deserialize(stream);
            }

            Console.WriteLine(person2);
        }

        private void PrintAuthorInfo(Type type) {
            Attribute.GetCustomAttributes(type).ToList().ForEach((attribute) => {
                if (attribute is AuthorAttribute authorAttribute) {
                    Console.WriteLine($"{authorAttribute.Name}, {authorAttribute.Version}");
                }
            });

        }

    }

}
