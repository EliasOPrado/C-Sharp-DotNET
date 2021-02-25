using System;

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
        }
    }
}
