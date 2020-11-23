using System;

namespace Basics.Concepts {

    public interface IControl {

        public string Name { get; set; }

        void Paint() {
            Console.WriteLine(nameof(IControl));
        }

    }

}
