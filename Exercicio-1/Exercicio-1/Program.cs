using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // estrutura sequencial
            Console.WriteLine("Entre com seu nome completo:");
            string frase = Console.ReadLine();
            Console.WriteLine("Quantidade de quartos na sua casa:");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preco de um produto:");
            double preco = double.Parse(Console.ReadLine());

            // create the split
            Console.WriteLine("Entre seu ultimo nome idade e altura (mesma linha):");
            string[] v = Console.ReadLine().Split(' ');
            string nome = v[0];
            string idade = v[1];
            string altura = v[2];

            Console.WriteLine( frase);
            Console.WriteLine(quartos);
            Console.WriteLine(preco);
            // details
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);

        }
    }
}
