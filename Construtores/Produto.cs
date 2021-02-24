using System;
namespace Construtores
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorTotalEmStoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }

        public void RemoveProdutos(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }

        public override string ToString()
        {
            return Nome +
                ", $" +
                ", " +
                Preco +
                ", $" +
                Preco +
                ", " +
                Quantidade +
                " unidades, total: " +
                ValorTotalEmStoque();
        }
    }
}
