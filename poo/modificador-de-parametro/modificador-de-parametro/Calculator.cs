using System;
namespace modificador_de_parametro {
    public class Calculator {

        // Estes sao met-dos repetitivos

        //public static int Sum(int n1, int n2) {
        //    return n1 + n2;
        //}
        //public static int Sum(int n1, int n2, int n3) {
        //    return n1 + n2 + n3;
        //}
        //public static int Sum(int n1, int n2, int n3, int n4) {
        //    return n1 + n2 + n3 + n4;
        //}

        // solucao para nao repetir
        public static int Sum(params int[] numbers) {
            int sum = 0;

            // pega o tamanho do vetor e adiciona ao numbers
            for (int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
