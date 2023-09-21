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
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture); 
        }


    }
} 




MAIN:
/* using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.Serialization;

namespace first
{
    internal class Program
    {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: "); 
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), ci);
            
            Produto produto = new Produto(nome, preco);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + produto);

            produto.Preco = 6000.00;

            Console.WriteLine();
            Console.Write("Digite o número de produtos a serem adicionados ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(qte);

            Console.WriteLine();

            Console.WriteLine("R$" + produto.Preco.ToString("F2", ci));

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + produto);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a serem eliminados do estoque: ");
            qte = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados finais: " + produto); 
        }

    }

} 
*/