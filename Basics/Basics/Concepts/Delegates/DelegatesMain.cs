using System;

namespace Basics.Concepts.Delegates {

    public class DelegatesMain {

        /*------------------------ FIELDS REGION ------------------------*/

        /*------------------------ METHODS REGION ------------------------*/
        public void Main() {
            DisplayAddedNumbers((num1, num2) => num1 + num2, 5, 10);
            DisplayAddedNumbers((num1, num2) => num1 - num2, 5, 10);
            DisplayAddedNumbers(Add, 5, 10);
            DisplayAddedNumbers(addFunction, 5, 10);

            int addFunction(int num1, int num2) {
                return num1 + num2;
            }

            DisplaySubtractedNumbers((num1, num2) => num1 - num2, 50, 10);

            LoggerMethodsExamples();
            FileLoggerUsage();
            EventsUsage();
        }

        /// <summary>
        /// I don't know why but it works weird
        /// </summary>
        private static void EventsUsage() {
            int filesFound = 0;
            EventHandler<FileFoundArgs> onFileFound = (sender, eventArgs) => {
                Console.WriteLine(eventArgs.FoundFile);
                filesFound++;

            };

            FileSearcher fileSearcher = new FileSearcher();
            fileSearcher.fileFound += onFileFound;
            fileSearcher.Search("/", ".cs");
            Console.WriteLine($"filesFound: {filesFound}");
        }

        private static void FileLoggerUsage() {
            FileLogger fileLogger = new FileLogger("sample.txt");
            Logger.LogMessage(
                Severity.Critical,
                nameof(DelegatesMain),
                "sample text to file"
            );
        }

        private static void LoggerMethodsExamples() {
            Logger.WriteMessage += LoggingMethods.LogToConsole;
            Logger.LogMessage(Severity.Information, nameof(DelegatesMain), "abc");
            Logger.LogMessage(Severity.Critical, nameof(DelegatesMain), "cde");

            Logger.WriteMessage += LoggingMethods.LogToFile;
            Logger.LogMessage(Severity.Information, nameof(DelegatesMain), "abc");
            Logger.LogMessage(Severity.Critical, nameof(DelegatesMain), "cde");
        }

        private int Add(int num1, int num2) {
            return num1 + num2;
        }

        private void DisplayAddedNumbers(AddNumbers addNumbers, int num1, int num2) {
            Console.WriteLine(addNumbers(num1, num2));
        }

        private void DisplaySubtractedNumbers(Func<int, int, int> addNumbers, int num1, int num2) {
            Console.WriteLine(addNumbers(num1, num2));
        }

    }

}
