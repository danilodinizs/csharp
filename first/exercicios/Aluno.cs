/* using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    internal class Aluno
    {

        public string Nome;
        public double N1;
        public double N2;
        public double N3;

        public double NotaFinal() {
            return N1 + N2 + N3;

        }

        public bool Aprovado() {

            if (NotaFinal() >= 60) {
                return true;
            }
            else {
                return false;
            }
        }

        public double NotaRestante() {
            if (Aprovado()) {
                return 0.0;
            }
            else {
                return 60.0 - NotaFinal();
            }
        }
    }
}

/* MAIN:

        CultureInfo ci = CultureInfo.InvariantCulture;

        Aluno aluno = new Aluno();

        Console.Write("Nome do aluno: ");
        aluno.Nome = Console.ReadLine();

        Console.WriteLine("Digite as três notas do aluno: ");

        aluno.N1 = double.Parse(Console.ReadLine(), ci);
        aluno.N2 = double.Parse(Console.ReadLine(), ci);
        aluno.N3 = double.Parse(Console.ReadLine(), ci);

        Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal().ToString("F2", ci));

        if (aluno.Aprovado()) {
             Console.WriteLine("APROVADO");
         }
        else {
             Console.WriteLine("REPROVADO");
             Console.WriteLine("FALTARAM " + aluno.NotaRestante().ToString("F2", ci)
             + " PONTOS");
         }
*/