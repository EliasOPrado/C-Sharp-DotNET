using System;

namespace poo_exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.WriteLine("Adicione o nome do funcionario:");
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();

            Console.Write("Salario Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionario: " + f.Nome + ", " + "salario $" + f.SalarioLiquido());

            Console.WriteLine();
            Console.Write("Digite a porcentagem para almentar o salario: ");
            double salario = double.Parse(Console.ReadLine());
            f.AumentarSalario(salario);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + f);
            

        }
    }
}
