using System;
using System.IO;

namespace Basics.Concepts.Delegates {

    public class FileLogger {

        /*------------------------ FIELDS REGION ------------------------*/
        private readonly string logPath;

        /*------------------------ METHODS REGION ------------------------*/
        public FileLogger(string logPath) {
            this.logPath = logPath;
            Logger.WriteMessage += LogMessage;

        }

        public void DetachLogToFile() {
            Logger.WriteMessage -= LogMessage;
        }

        private void LogMessage(string message) {
            try {
                using (StreamWriter log = File.AppendText(logPath)) {
                    log.WriteLine(message);
                    log.Flush();
                }
            } catch (Exception) {
            }
        }

    }

}
