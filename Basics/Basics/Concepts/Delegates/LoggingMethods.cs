using System;
using System.IO;

namespace Basics.Concepts.Delegates {

    public class LoggingMethods {

        /*------------------------ FIELDS REGION ------------------------*/

        /*------------------------ METHODS REGION ------------------------*/
        public static void LogToConsole(string message) {
            Console.Error.WriteLine(message);
        }

        /// <summary>
        /// This is more consistent solution in opposite what has been shown in FileLogger.cs
        /// </summary>
        public static void LogToFile(string message) {
            try {
                DateTime today = DateTime.Today;
                string filename = $"{today.Year}-{today.Month}-{today.Day}.txt";
                using (StreamWriter log = File.AppendText(filename)) {
                    log.WriteLine(message);
                    log.Flush();
                }
            } catch (Exception) {

            }
        }

    }

}
