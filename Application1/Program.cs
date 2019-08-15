using System;

namespace Application1 {
    class Program {
        static void Main(string[] args) {
            const int numOfIterationsInTaylorSeries = 5400;

            for ( int i = 20, j = i / 2; i >= 0; --i ) {
                double x = 1.0 - (double) i / j;
                TaylorSeriesFunctions.View(x, numOfIterationsInTaylorSeries);
            }

            Console.ReadKey();
        }
    }
}
