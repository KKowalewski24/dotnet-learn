using System;
using System.IO;
using System.Linq;

namespace Basics.Concepts.Delegates {

    public class FileSearcher {

        /*------------------------ FIELDS REGION ------------------------*/
        public event EventHandler<FileFoundArgs> fileFound;

        /*------------------------ METHODS REGION ------------------------*/
        public void Search(string directory, string searchPattern) {
            Directory.EnumerateFiles(directory, searchPattern).ToList().ForEach((file) => {
                fileFound?.Invoke(this, new FileFoundArgs(file));
            });
        }

    }

}
