using System;
namespace exercicio_conta_bancaria {
    public class ContaBancaria {

        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }


        public ContaBancaria(int numero, string titular){
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular) {
            Saldo = saldo;
        }

        public void Deposito(double quantia) {
            Saldo += quantia;
        }

        public void Saque(double quantia) {
            Saldo -= quantia + 5.00;
        }

        public override string ToString() {
            return "Conta " +
                Numero +
                ", titular: " +
                Titular +
                ", saldo: $" +
                Saldo.ToString("F2");
        }

    }
}
