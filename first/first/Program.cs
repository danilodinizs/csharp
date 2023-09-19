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