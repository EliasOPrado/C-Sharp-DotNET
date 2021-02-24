using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // check password =============
            //int password = 2002;

            //Console.WriteLine("add password:");

            //int input = int.Parse(Console.ReadLine());

            //while (input != password)
            //{
            //    Console.WriteLine("invalid password");
            //    Console.WriteLine("add password:");
            //    input = int.Parse(Console.ReadLine());
            //}
            //    Console.WriteLine("valid password");

            // Check product code ===========
            Console.WriteLine("Which product number? (From 1 to 3 where 4 is none)");
            int input = int.Parse(Console.ReadLine());

            int a = 1;
            int b= 2;
            int c = 3;
            int d = 4;

            while (input > 0)
            {
                if(input == a)
                {
                    Console.WriteLine("Alcool: 1");
                    Console.WriteLine("Thank you");
                    break;
                }
                else if (input == b)
                {
                    Console.WriteLine("Gasolina: 2");
                    Console.WriteLine("Thank you");
                    break;
                }
                else if (input == c)
                {
                    Console.WriteLine("Diesel: 3");
                    Console.WriteLine("Thank you");
                    break;
                }
                else if (input == d)
                {
                    Console.WriteLine("Thank you");
                    break;
                }
            }
        }
    }
}
