/*using System;
using System.Collections.Generic;
using System.Globalization;
 using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    internal class Vetores
    {
        CultureInfo ci = CultureInfo.InvariantCulture;
            
            VETOR TIPO REFERÊNCIA:

            Console.Write("Digite um número de produtos : ");
            int n = int.Parse(Console.ReadLine());

            Conta[] vet = new Conta[n];

            double soma = 0;

            for (int i = 0; i < n; i++) {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), ci);
                vet[i] = new Conta { Nome = name, Price = price };
                soma += vet[i].Price;
            }

            double media = soma / n;

            Console.WriteLine("AVERAGE HEIGHT = " + media.ToString("F2", ci));
    
            CLASSE:        
    
            public string Nome { get; set; }
            public double Price { get; set; }

=======================================================================================

            VETOR TIPO STRUCT:

               Console.WriteLine("Digite um número: ");
            int n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            double soma = 0;

            for (int i = 1; i <= n; i++) {
                vet[i] = double.Parse(Console.ReadLine(), ci);
                soma += vet[i];
            }

            double media = soma / n;

            Console.WriteLine("AVERAGE HEIGHT = " + media.ToString("F2", ci));
    }
}
            
            VETOR COMO PARÂMETRO:
    
            public static int Soma(params int[] vetor) {
                int soma = 0;
                for (int i = 0; i < vetor.Length; i++) {
                    soma += vetor[i]
                }
                return soma;
            }
            
            
*/

