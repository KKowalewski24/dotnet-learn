using System.Threading.Tasks;
using Basics.GetStarted;
using Basics.Tutorials;

namespace Basics {

    class Program {

        static async Task Main(string[] args) {
            // GetStartedMain getStartedMain = new GetStartedMain();
            // getStartedMain.Main();

            TutorialsMain tutorialsMain = new TutorialsMain();
            await tutorialsMain.Main();
        }

    }

}
