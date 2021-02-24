using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // for loop

            Console.Write("Add an int value to check if it is within a range:");
            int input = int.Parse(Console.ReadLine());

            for(int i = 0; i < input; i++)
            {
                if (Enumerable.Range(10, 20).Contains(i))
                {
                    Console.WriteLine(i + "in");
                }
                else
                {
                    Console.WriteLine(i + "out");
                }
            }
        }
    }
}
