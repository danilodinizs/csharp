/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    internal class ConversorDeMoeda
    {
        public static double Valor;
        public static double Quantidade;

        public static double Reais(double value, double quantity) {
            return value * (quantity + quantity * 0.06);
        }
    }
}

/* 
    MAIN:

using System.Globalization;

namespace exercicios
{
    internal class Program
    {
        static void Main(string[] args) {

            CultureInfo ci = CultureInfo.InvariantCulture;

            Console.Write("Qual é a cotação do dólar? ");
            double cotação = double.Parse(Console.ReadLine(), ci);

            Console.Write("Quantos dólares você vai comprar? ");
            double quantidade = double.Parse(Console.ReadLine(), ci);

            double conversao = ConversorDeMoeda.Reais(cotação, quantidade);

            Console.WriteLine("Valor a ser pago em reais = " + conversao.ToString("F2", ci));
        }
    }
}

*/