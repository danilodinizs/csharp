/* using exercicios;
using System;
using System.Globalization;

namespace exercicios
{
    internal class Retangulo
    {
    
        public double Altura;
        public double Largura;

        public double Area() {
            return Altura * Largura;
        }

        public double Perimetro() {
            return Altura * 2 + Largura * 2;
        }

        public double Diagonal() {
            return Math.Sqrt(Altura * Altura + Largura * Largura);
        }
    }
} */

/* MAIN:

        CultureInfo ci = CultureInfo.InvariantCulture;

        Retangulo ret = new Retangulo();

        Console.WriteLine("Entre com a largura e altura do retângulo: ");
        ret.Largura = double.Parse(Console.ReadLine(), ci);
        ret.Altura = double.Parse(Console.ReadLine(), ci);

        Console.WriteLine();
        Console.WriteLine("ÁREA = " + ret.Area().ToString("F2", ci));
        Console.WriteLine("PERÍMETRO = " + ret.Perimetro().ToString("F2", ci));
        Console.WriteLine("DIAGONAL = " + ret.Diagonal().ToString("F2", ci));

*/

 
    