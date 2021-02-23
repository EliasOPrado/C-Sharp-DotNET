using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte n1 = 126;
            //int n2 = 1000;

            //// for bigger number than this you need long type
            //int n3 = 2147483647;
            //long n4 = 2147483648L;
            //bool completo = false;

            //// char type needs a simple '' to recognize the character
            //char sexo = 'F';
            //char letra = '\u0041'; // unicode para a letra.

            //// float needs a letter f at the end of the float number
            //float n5 = 4.5f;

            //// double
            //double n6 = 4.5;

            //// string is imutable
            //string nome = "Maria Gimenes";
            // object generico
            //object obj1 = "Patrick O'Connel";
            //object obj2 = 4.3f;

            //Console.WriteLine(completo);
            //Console.WriteLine(sexo);
            //Console.WriteLine(letra);
            //Console.WriteLine(nome);
            //Console.WriteLine(obj1);
            //Console.WriteLine(obj2);
            //Console.WriteLine(n1);
            //Console.WriteLine(n2);
            //Console.WriteLine(n3);
            //Console.WriteLine(n4);
            //Console.WriteLine(n5);
            //Console.WriteLine(n6);
            //Console.WriteLine("=============================");

            //int idade = 32;
            //double saldo = 10.35456;
            //string nome2 = "Maria";
            //// place holder, F2 is the number of numbers to show of a float.
            //Console.WriteLine("{0} tem {1} anos e {2:F2} de reais em saldo.", nome2, idade, saldo);

            //// interpolacao
            //Console.WriteLine($"{nome2} tem {idade} e {saldo:F2} reais.");

            //// concatenation
            //Console.WriteLine(nome2 + " tem " + idade + " e " + saldo.ToString("F2") + " de reais.");

            //Console.WriteLine("=============================");

            // conversao implicita e casting

            //double a;
            //float b;
            //int c;

            //a = 5.1;

            // When turning a double to a float there is a lost of 4 bit.
            // Since double is 8 bits whereas float is four.
            // therefore there is will be a lost of bits.
            //b = (float)a;

            //================

            //c = (int)a;
            

            //Console.WriteLine(c);

            Console.WriteLine("=============================");

            //===========================

            // Operadores aritimeticos

            //int a = 4 + 3 * 2;//10
            //int b = (4 + 3) * 2;//14
            //int c = 17 % 3; // 2

            // Need use casting (float) or (double) or use a float numer as 10.0
            //double d = (double) 10 / 8; //1.25

            //double a = 1.0, b = -3.0, c = -4.0;

            //// Formula de bascara // Math.Pow(x, y) is the "at the power"
            //double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
            //// square root or raiz quadrada Math.sqrt(x)
            //double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            //double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            //Console.WriteLine(delta);
            //Console.WriteLine(x1);
            //Console.WriteLine(x2);

            // Entrada de dados ============

            //string frase = Console.ReadLine();
            //string x = Console.ReadLine();
            //string y = Console.ReadLine();
            //string z = Console.ReadLine();

            //Console.WriteLine("Voce digitou: " + frase);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

            //string s = Console.ReadLine();
            //string[] vet = s.Split(' ');
            //string p1 = vet[0];
            //string p2 = vet[1];
            //string p3 = vet[2];

            //Console.WriteLine(p1);
            //Console.WriteLine(p2);
            //Console.WriteLine(p3);

            //===== fazendo a leitura de um numero inteiro

            //int n1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Voce digitou");
            //Console.Write(n1);

            // 
        }
    }
}
