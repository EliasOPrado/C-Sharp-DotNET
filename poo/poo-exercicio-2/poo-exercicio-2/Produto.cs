using System;
namespace poo_exercicio_2
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

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
