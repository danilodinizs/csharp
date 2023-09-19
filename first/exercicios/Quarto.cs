/*
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    internal class Quarto
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }

        public Quarto() {
        }

        public Quarto(string nome, string email) {
            Nome = nome;
            Email = email;
        }

        public Quarto(string nome, string email, int room) : this(nome, email) {
            Room = room;
        }

        public override string ToString() {
            return Room
                + ": "
                + Nome
                + ", "
                + Email;
        }
    }
}


MAIN:

using System.Globalization;

namespace exercicios
{
    internal class Program
    {
        static void Main(string[] args) {

            CultureInfo ci = CultureInfo.InvariantCulture;

            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            Quarto[] vetor = new Quarto[10];

            for (int i = 0; i < n; i++) {
                Console.WriteLine();
                Console.WriteLine("Rent #" + (i + 1) + ": ");
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                vetor[room] = new Quarto(nome, email, room);
            }

            for (int i = 0; i < vetor.Length; i++) {
                if (vetor[i] != null) {
                    Console.WriteLine(vetor[i]);
                }
            }

        }
    }
}

*/