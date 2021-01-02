using System;
using System.IO;

namespace Basics.ProgrammingGuide.FileOperations {

    public class FileMain {

        /*------------------------ FIELDS REGION ------------------------*/

        /*------------------------ METHODS REGION ------------------------*/
        public void Main() {
            string directoryPath = Path.Combine(
                Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\"),
                "ProgrammingGuide",
                "FileOperations"
            );

            FilesInfo(directoryPath);
            HardDriveInfo();
            ReadAllLinesInAllFiles();

            foreach (string line in File.ReadLines(Directory.GetFiles(directoryPath)[0])) {
                Console.WriteLine(line);
            }
        }

        private void ReadAllLinesInAllFiles() {
            foreach (string file in Directory.GetFiles("ProgrammingGuide")) {
                foreach (string line in File.ReadAllLines(file)) {
                    Console.WriteLine(line);
                }
            }
        }

        private void FilesInfo(string directoryPath) {
            foreach (string file in Directory.GetFiles(directoryPath)) {
                FileInfo fileInfo = new FileInfo(file);
                Console.WriteLine(fileInfo.Name);
                Console.WriteLine(fileInfo.DirectoryName);
                Console.WriteLine(fileInfo.Length);
                Console.WriteLine(fileInfo.IsReadOnly);
            }
        }

        private void HardDriveInfo() {
            DriveInfo driveInfo = new DriveInfo(@"C:\");
            Console.WriteLine(driveInfo.Name);
            Console.WriteLine(driveInfo.DriveFormat);
            Console.WriteLine(driveInfo.DriveType);
            Console.WriteLine(driveInfo.TotalSize);
        }

    }

}
