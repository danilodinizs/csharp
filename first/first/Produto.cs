/* using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace first
{
    public class Produto
    {
        private string _nome;
        public double Preco { get; set; } 
        private int _quantidade;

        public Produto() {
            _quantidade = 6;
        }


        public Produto(string nome, double preco) : this() {
            _nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco) {
            _quantidade = quantidade;
        }

        public string Nome { 
            get { return _nome; }
            set { 
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }


        public int Quantidade
        {
            get { return _quantidade; }
            set
            {
                if (value > 0) {
                    _quantidade = value;
                }
            }
        }

        public double ValorTotalEmEstoque() {
            double total = Preco * _quantidade;
            return total;
        }

        public void AdicionarProdutos(int quantidade) {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            _quantidade -= quantidade;
        }

        public override string ToString() {
            return _nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + _quantidade
                + " unidades, Total: $ " 
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture); ;
        }


    }
} 


*/