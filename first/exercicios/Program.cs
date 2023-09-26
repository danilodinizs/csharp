using System.Globalization;
using exercicios;

namespace first
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            List<Contribuinte> list = new List<Contribuinte>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char ic = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), ci);

                if (ic == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthEx = double.Parse(Console.ReadLine(), ci);
                    list.Add(new PessoaFísica(name, anualIncome, healthEx));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmp = int.Parse(Console.ReadLine());
                    list.Add(new PessoaJurídica(name, anualIncome, numberOfEmp));
                }
            }

            Console.WriteLine();

            double sum = 0;
            Console.WriteLine("TAXES PAID: ");
            foreach (Contribuinte contribuinte in list)
            {
                Console.WriteLine(contribuinte.Name + ": $ " + contribuinte.TaxesPaid().ToString("F2", ci));
                sum += contribuinte.TaxesPaid();
                
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", ci));
        }
    }
}