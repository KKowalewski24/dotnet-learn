using System;
using System.IO;
using System.Xml.Serialization;

namespace Basics.ProgrammingGuide.Serialization {

    public class XmlSerializator {

        /*------------------------ FIELDS REGION ------------------------*/
        private const string XmlfileName = "xmlFile.xml";

        private readonly XmlSerializer _serializer = new XmlSerializer(typeof(Car));

        /*------------------------ METHODS REGION ------------------------*/
        public void Main() {
            Write();
            Read();
        }

        private void Write() {
            Car car = new Car("Porsche", "Grey", 340);
            using (StreamWriter streamWriter = new StreamWriter(XmlfileName)) {
                _serializer.Serialize(streamWriter, car);
            }
        }

        private void Read() {
            using (StreamReader streamReader = new StreamReader(XmlfileName)) {
                Car car = (Car)_serializer.Deserialize(streamReader);
                Console.WriteLine(car);
            }
        }

    }

}
