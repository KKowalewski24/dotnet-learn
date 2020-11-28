using System;
using System.Threading.Tasks;
using Basics.Concepts;
using Basics.GetStarted;
using Basics.Tutorials;

namespace Basics {

    public class Program {

        public static async Task Main(string[] args) {
            // GetStartedMain getStartedMain = new GetStartedMain();
            // getStartedMain.Main();

            // TutorialsMain tutorialsMain = new TutorialsMain();
            // await tutorialsMain.Main();
            ConceptsMain conceptsMain = new ConceptsMain();
            conceptsMain.Main();
        }

    }

}
