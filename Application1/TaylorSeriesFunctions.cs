using System;


namespace Application1 {
    /// <summary>
    /// Evaluation arctg function with using Taylor Series.
    /// </summary>
    class TaylorSeriesFunctions {
        static double ToTwoPlusOne(double n) {
            return n++ + n;
        }

        static int SignValue(int value) {
            return value % 2 == 0 ? 1 : -1;
        }

        static double X(double r, double x, int n) {
            if ( n == 0 ) {
                return r;
            }

            int signValue = SignValue(n);
            double k = ToTwoPlusOne(n);
            double currentR = r + signValue * Math.Pow(x, k) / k;

            return X(currentR, x, --n);
        }

        /// <summary>
        /// Calculate arctg function with using Taylor Series for
        /// specified x and n.
        /// </summary>
        /// <param name="x">Value х(from -1 to 1).</param>
        /// <param name="n">Number of elements in Taylor Series.</param>
        public static double Arctg(double x, int n) {
            return Math.Abs(x) <= 1 ? X(x, x, n) : double.NaN;
        }

        /// <summary>
        /// Show result to Console stream out in readable format.
        /// </summary>
        /// <param name="x">Value х(from -1 to 1).</param>
        /// <param name="n">Number of elements in Taylor Series.</param>
        public static void View(double x, int n) {
            Console.WriteLine("arctg (" + x + ") = " + Arctg(x, n));
        }
    }
}
