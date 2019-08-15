using System;

namespace Application2 {

    class Hexagon : IComparable {
        double a;
        double s;

        public Hexagon() { }

        public Hexagon(double _a) {
            if ( _a >= 0 ) {
                a = _a;
                SquareHexagon();
            }
        }

        public double A {
            get { return a; }
            set {
                if ( value >= 0 ) {
                    a = value;
                    SquareHexagon();
                }
            }
        }

        public double S {
            get { return s; }
            set {
                if ( value >= 0 ) {
                    s = value;
                    SideHexagon();
                }
            }
        }

        void SquareHexagon() {
            s = 3 * Math.Sqrt(3) / 2 * ( a * a );
        }

        void SideHexagon() {
            a = Math.Sqrt(2 * S / ( 3 * Math.Sqrt(3) ));
        }

        public void View() {
            Console.WriteLine("S(" + a + ") = " + s + "");
        }

        public int CompareTo(object a) {
            Hexagon b = (Hexagon) a;
            return b.S > this.S ? 1 : b.S < this.S ? -1 : 0;
        }
    }

    class Program {
        static void Main(string[] args) {
            const int numOfSampleValues = 10;

            Random rand = new Random();
            Hexagon[] values = new Hexagon[numOfSampleValues];

            Console.WriteLine("Not sorted array:");

            for ( int i = 0; i < values.Length; i++ ) {
                double randomValue = (double) rand.Next(100) / 10;
                values[i] = new Hexagon(randomValue);
                values[i].View();
            }

            Console.WriteLine("Sorted array:");

            Array.Sort(values);

            for ( int i = 0; i < values.Length; i++ ) {
                values[i].View();
            }

            Console.ReadKey();
        }
    }
}
