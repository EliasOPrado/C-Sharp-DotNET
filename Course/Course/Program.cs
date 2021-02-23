using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n1 = 126;
            int n2 = 1000;
            // for bigger number than this you need long type
            int n3 = 2147483647;
            long n4 = 2147483648L;
            bool completo = false;
            // char type needs a simple '' to recognize the character
            char sexo = 'F';
            char letra = '\u0041'; // unicode para a letra.
            // float needs a letter f at the end of the float number
            float n5 = 4.5f;
            // double
            double n6 = 4.5;
            // string is imutable
            string nome = "Maria Gimenes";
            // object generico
            object obj1 = "Patrick O'Connel";
            object obj2 = 4.3f;

            Console.WriteLine(completo);
            Console.WriteLine(sexo);
            Console.WriteLine(letra);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine("=============================");

            int idade = 32;
            double saldo = 10.35456;
            string nome2 = "Maria";
            // place holder, F2 is the number of numbers to show of a float.
            Console.WriteLine("{0} tem {1} anos e {2:F2} de reais em saldo.", nome2, idade, saldo);

            // interpolacao
            Console.WriteLine($"{nome2} tem {idade} e {saldo:F2} reais.");

            // concatenation
            Console.WriteLine(nome2 + " tem " + idade + " e " + saldo.ToString("F2") + " de reais.");
        }
    }
}
