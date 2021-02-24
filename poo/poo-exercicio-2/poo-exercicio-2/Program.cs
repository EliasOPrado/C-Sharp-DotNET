using System;

namespace poo_exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Produto: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preco: ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade em estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine( );
            Console.WriteLine("Digite um numero de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite um numero de produtos a ser removido do estoque: ");
            int rqte = int.Parse(Console.ReadLine());
            p.RemoveProdutos(rqte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
