    using System;
    namespace construtores
    {
        public class Produto
        {

            private string _nome;
            private double _preco;
            private int _quantidade;

            public Produto(string nome, double preco, int quantidade)
            {
                _nome = nome;
                _preco = preco;
                _quantidade = quantidade;
            }

            public Produto(string nome, double preco)
            {
                _nome = nome;
                _preco = preco;
                _quantidade = 5;
            }

            // you need to use set and get to get private instances of an constructor
            public string GetNome()
            {
                return _nome;
            }

            public void SetNome(string nome)
            {
                // this encapsulization is used for security reasons and set filters.
                if(nome != null && nome.Length > 1) {
                    _nome = nome;
                }

            }

            public string Nome
            {
                get { return _nome; }
                set {
                    // to use parameter you need to change nome by value
                    if (value != null && value.Length > 1)
                    {
                        _nome = value;
                    }
                }
            }

            public double Preco
            {
                get { return _preco; }
            }

            public int Quantidade
            {
                get { return _quantidade; }
            }
       

    
            public double ValorTotalEmEstoque()
            {
                return _preco * _quantidade;
            }
            public void AdicionarProdutos(int quantidade)
            {
                _quantidade += quantidade;
            }
            public void RemoverProdutos(int quantidade)
            {
                _quantidade -= quantidade;
            }
            public override string ToString()
            {
                return Nome
                + ", $ "
                + Preco.ToString("F2")
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2");
            }
        }
    }
