using System.Threading.Tasks;
using Basics.Async;
using Basics.Concepts;
using Basics.GetStarted;
using Basics.ProgrammingGuide;
using Basics.Tutorials;

namespace Basics {

    public class Program {

        public static async Task Main(string[] args) {
            new GetStartedMain().Main();
            await new TutorialsMain().Main();
            new ConceptsMain().Main();
            await new AsyncMain().Main();
            new ProgrammingGuideMain().Main();
        }

    }

}
