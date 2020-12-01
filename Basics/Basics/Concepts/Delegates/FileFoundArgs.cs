using System;

namespace Basics.Concepts.Delegates {

    public class FileFoundArgs : EventArgs {

        /*------------------------ FIELDS REGION ------------------------*/
        public string FoundFile { get; }

        /*------------------------ METHODS REGION ------------------------*/
        public FileFoundArgs(string foundFile) {
            FoundFile = foundFile;
        }

    }

}
