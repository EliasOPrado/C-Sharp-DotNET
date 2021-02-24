using System;

namespace escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite tres numeros");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            // Ira pegar o valor e compara-los sabendo qual o maior
            double resultado = Maior(n1, n2, n3);

            Console.WriteLine("Maior = " + resultado);
        }
        // Escopo de funcoes
        static int Maior(int a, int b, int c)
        {
            int m;

            if (a > b && a > c)
            {
                m = a;
            }else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }
    }
}
