using System;

namespace Basics.Concepts {

    public interface ISurface {

        public int Type { get; set; }

        void Paint() {
            Console.WriteLine(nameof(ISurface));
        }

    }

}
