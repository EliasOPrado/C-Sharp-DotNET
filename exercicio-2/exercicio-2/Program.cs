using System;

namespace exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // check if the number is negative
            Console.Write("add a number:");
            // add the value
            int number = int.Parse(Console.ReadLine());
            Check(number);
            
        }
      static  int Check(int a) { 

            if(a < 0){
                Console.WriteLine("NEGATIVE");
            }
            else
            {
                Console.WriteLine("POSITIVE");
            }
            return a;
        }
    }
}
