using System;

namespace modificador_de_parametro {
    class Program {
        static void Main(string[] args) {

            // sem params
            //int r1 = Calculator.Sum(new int[] { 10, 20, 30, 40 });// 100
            //int r2 = Calculator.Sum(new int[] { 10, 20, 40 });// 70

            // com params
            int r1 = Calculator.Sum(10, 20, 30, 40 );// 100
            int r2 = Calculator.Sum( 10, 20, 40 );// 70

            Console.WriteLine(r1);
            Console.WriteLine(r2);

        }
    }
}
