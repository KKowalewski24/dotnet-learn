using System.Collections;

namespace Basics.ProgrammingGuide.CustomCollection {

    public class AllColors : IEnumerable {

        /*------------------------ FIELDS REGION ------------------------*/
        private Color[] _colors = {
            new Color("red"), new Color("blue"), new Color("green")
        };

        /*------------------------ METHODS REGION ------------------------*/
        public IEnumerator GetEnumerator() {
            return new ColorEnumerator(_colors);
        }

        private class ColorEnumerator : IEnumerator {

            private readonly Color[] _colors;
            private int _position = -1;

            public object Current => _colors[_position];

            public ColorEnumerator(Color[] colors) {
                _colors = colors;
            }

            public bool MoveNext() {
                _position++;
                return _position < _colors.Length;
            }

            public void Reset() {
                _position = -1;
            }

        }

    }

}
