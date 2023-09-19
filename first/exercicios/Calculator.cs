/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    internal class Calculator
    {
        public static double Pi = 3.14;

        public static double Circunferencia(double r) {
            return 2.0 * Pi * r;
        }

        public static double Volume(double r) {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
        }
    }
}

/* MAIN: 

using System.Globalization;

namespace exercicios
{
    internal class Program
    {
        static void Main(string[] args) {

            CultureInfo ci = CultureInfo.InvariantCulture;

            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), ci);

            Console.WriteLine();

            double circ = Calculator.Circunferencia(raio);
            double vol = Calculator.(raio);

            Console.WriteLine("Cincurferência: " + circ.ToString("F2", ci));
            Console.WriteLine("Volume: " + vol.ToString("F2", ci));
            Console.WriteLine("Valor de PI: " + Calculator.Pi.ToString("F2", ci));
        }
    }
}

*/
