using System;

namespace vetores_exercicios {
    class Program {
        static void Main(string[] args) {

            // add value for vector of 10 rooms
            Estudante[] vect = new Estudante[10];

            Console.Write("Quantos quartos serão alugados? ");

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {

                Console.WriteLine();// cria uma linha nova
                Console.WriteLine($"Aluguel #{i}:");// adiciona o numero "1" na frente

                Console.Write("Nome: ");
                string nome = Console.ReadLine();// cria-se o nome logo abaixo

                Console.Write("Email: ");
                string email = Console.ReadLine();// cria-se o email

                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());// de 0 a 9 adiciona valores escolhidos pelo usuario
                vect[quarto] = new Estudante(nome, email);// adiciona quarto a nome e email
            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++) {
                if (vect[i] != null) {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }

        }
    }
}
