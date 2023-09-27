//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace exercicios
//{
//    internal abstract class Contribuinte
//    {
//        public string Name { get; set; }
//        public double AnualIncome { get; set; }

//        public Contribuinte(string name, double anualIncome) { 
//            Name = name;
//            AnualIncome = anualIncome;
//        }

//        public abstract double TaxesPaid(); 
//    }
//}

//MAIN:

//List<Contribuinte> list = new List<Contribuinte>();

//Console.Write("Enter the number of tax payers: ");
//int n = int.Parse(Console.ReadLine());

//for (int i = 1; i <= n; i++)
//{
//    Console.WriteLine($"Tax payer #{i} data: ");
//    Console.Write("Individual or company (i/c)? ");
//    char ic = char.Parse(Console.ReadLine());
//    Console.Write("Name: ");
//    string name = Console.ReadLine();
//    Console.Write("Anual income: ");
//    double anualIncome = double.Parse(Console.ReadLine(), ci);

//    if (ic == 'i')
//    {
//        Console.Write("Health expenditures: ");
//        double healthEx = double.Parse(Console.ReadLine(), ci);
//        list.Add(new PessoaFísica(name, anualIncome, healthEx));
//    }
//    else
//    {
//        Console.Write("Number of employees: ");
//        int numberOfEmp = int.Parse(Console.ReadLine());
//        list.Add(new PessoaJurídica(name, anualIncome, numberOfEmp));
//    }
//}

//Console.WriteLine();

//double sum = 0;
//Console.WriteLine("TAXES PAID: ");
//foreach (Contribuinte contribuinte in list)
//{
//    Console.WriteLine(contribuinte.Name + ": $ " + contribuinte.TaxesPaid().ToString("F2", ci));
//    sum += contribuinte.TaxesPaid();

//}

//Console.WriteLine();
//Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", ci));