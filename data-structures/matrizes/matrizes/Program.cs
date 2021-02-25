using System;

namespace matrizes {
    class Program {
        static void Main(string[] args) {

            // estanciando matriz e o double tem 2 linhas e tres colunas
            //double[,] mat = new double[2, 3];
            
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for(int i = 0; i < n; i++) {
                /*
                 ira pegar tod-s os valores da primeira linha e separalos por espaco
                 e esses valores serao adicionados em values string.
                 */
                string[] values = Console.ReadLine().Split(' ');

                for(int j = 0; j < n; j++) {
                    // o j sera colocado na frente do i na matriz.
                    mat[i, j] = int.Parse(values[j]);
                }

            }

            Console.WriteLine("Diagonal da matriz:");
            for (int i = 0; i < n; i++) {
                Console.WriteLine(mat[i, i] + " ");
            }

            Console.WriteLine("Numeros negativos:");
            int count = 0;
            for(int i = 0; i < n; i++) {
                for(int j = 0; j < n; j++) {
                    if(mat[i,j] < 0) {
                        count++;
                    }
                }
            }
            Console.WriteLine("Numeros negativos: " + count);
        }
    }
}
