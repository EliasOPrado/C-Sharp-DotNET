using System;

namespace poo_exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Person personA, personB;

            personA = new Person();
            personB = new Person();


            Console.WriteLine("Write the first person data:");
            Console.Write("Name: ");
            personA.Name = Console.ReadLine();
            Console.Write("Age: ");
            personA.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Write the second person data:");
            Console.Write("Name: ");
            personB.Name = Console.ReadLine();
            Console.Write("Age: ");
            personB.Age = int.Parse(Console.ReadLine());

            if (personA.Age > personB.Age)
            {
                Console.WriteLine("Oldest person: " + personA.Name);
            }
            else
            {
                Console.WriteLine("Oldest person: " + personB.Name);
            }
        }
    }
}
