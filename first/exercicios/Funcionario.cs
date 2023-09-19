/* using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem) {
            SalarioBruto = (SalarioBruto * porcentagem / 100) + SalarioBruto;
        }

        public override string ToString() {
            return Nome + ", R$ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
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

            Funcionario func = new Funcionario();

            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();

            Console.Write("Salário bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), ci);

            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), ci);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + func);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double p = double.Parse(Console.ReadLine(), ci);
            func.AumentarSalario(p);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + func);

        }

    }
}

*/
