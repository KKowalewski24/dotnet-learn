using System;

namespace Basics.ProgrammingGuide {

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]
    public class AuthorAttribute : Attribute {

        /*------------------------ FIELDS REGION ------------------------*/
        public string Name { get; private set; }
        public double Version { get; private set; }

        /*------------------------ METHODS REGION ------------------------*/
        public AuthorAttribute(string name, double version) {
            Name = name;
            Version = version;
        }

    }

}
