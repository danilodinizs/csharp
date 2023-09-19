/* using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    internal class Conta
    {

        
        /
        public int NumeroConta { get; private set; }
        public string Nome { get; set; }
        public double Deposito { get; private set; }

        public Conta() {

        }

        public Conta(int numeroConta) {
            NumeroConta = numeroConta;
        }

        public Conta(int numeroConta, string nome) : this(numeroConta) {
            Nome = nome;
        }
        public Conta(int numeroConta, string nome, double deposito) : this(numeroConta, nome) {
            AdicionarSaldo(deposito);
        }

        public void AdicionarSaldo(double quantia) {
            Deposito += quantia;
        }

        public void RemoverSaldo(double quantia) {
            Deposito -= quantia + 5.00;
        }

        public override string ToString() {
            return "Conta "
                + NumeroConta
                + ", Titular: "
                + Nome
                + ", Saldo: $ "
                + Deposito.ToString("F2", CultureInfo.InvariantCulture);
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

            Conta conta;

            Console.Write("Entre com o núemro da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char simounao = char.Parse(Console.ReadLine());
            if (simounao == 's' || simounao == 'S') {
                Console.Write("Entre com o valor de deposito: ");
                double deposito = double.Parse(Console.ReadLine(), ci);
                conta = new Conta(numeroConta, nome, deposito);
            }
             
            else { 
                conta = new Conta(numeroConta, nome);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com um valor para depósito: ");
            double adicionarSaldo = double.Parse(Console.ReadLine(), ci);
            conta.AdicionarSaldo(adicionarSaldo);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com um valor para saque: ");
            double removerSaldo = double.Parse(Console.ReadLine(), ci);
            conta.RemoverSaldo(removerSaldo);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
        }
    }
}

*/