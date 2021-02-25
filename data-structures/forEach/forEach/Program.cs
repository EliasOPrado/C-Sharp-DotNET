using System;

// para a List<string>
using System.Collections.Generic;

namespace forEach {
    class Program {
        static void Main(string[] args) {

            string[] vect = new string[] { "maria", "peter", "joao", "ana" };

            for(int i = 0; i < vect.Length; i++) {
                Console.WriteLine(vect[i]);
            }

            Console.WriteLine("=========================");

            // usando foreach
            foreach(string obj in vect) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("=========================");
            // ============ Listas =========
            List<string> list = new List<string>();

            list.Add("Oliveira");
            list.Add("Joao");
            list.Insert(1, "Bob");// Oliveira Bob Joao

            foreach(string i in list) {
                Console.WriteLine(i):
            }
            // Add(), Insert(), Find(), FindLast(), Remove(), RemoveAll(), RemoveRange(x, y)
        }
    }
}
