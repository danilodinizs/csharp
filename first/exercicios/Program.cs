using System.Globalization;
using exercicios;

namespace first
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), ci);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), ci);

                AccountwEx acc = new AccountwEx(number, holder, balance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine(), ci);

                acc.Withdraw(withdraw);

                Console.WriteLine("New balance: " + acc.Balance.ToString("F2", ci));
            }
            catch (DomainException e) 
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }


        }
    }
}