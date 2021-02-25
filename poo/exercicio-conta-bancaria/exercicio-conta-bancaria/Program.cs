using System;

namespace exercicio_conta_bancaria {
    class Program {
        static void Main(string[] args) {

            ContaBancaria conta;

            Console.Write("Entre o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Havera deposito inicial (s/n): ");
            char resp = char.Parse(Console.ReadLine());

            if(resp == 's' || resp == 'S') {
                // saldo positivo
                Console.Write("Entre o valor de deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numero, titular, depositoInicial);
            } else {
                // saldo zero
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.Write("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para deposito:");
            double quantia = double.Parse(Console.ReadLine());
            conta.Deposito(quantia);

            Console.WriteLine();
            Console.Write("Entre um valor para saque:");
            quantia = double.Parse(Console.ReadLine());
            conta.Saque(quantia);
            Console.WriteLine("Dados atualizados da conta");
            Console.WriteLine(conta);
        }
    }
}
