using System;

namespace Basics.Concepts.Delegates {

    public class Logger {

        /*------------------------ FIELDS REGION ------------------------*/
        public static Severity LogLevel { get; set; } = Severity.Warning;

        /*------------------------ METHODS REGION ------------------------*/
        public static Action<string> WriteMessage;

        public static void LogMessage(Severity severity, string component, string msg) {
            if (severity < LogLevel) {
                return;
            }

            WriteMessage?.Invoke($"{DateTime.Now}\t{severity}\t{component}\t{msg}");
        }

    }

}
