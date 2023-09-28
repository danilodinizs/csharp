//using exercicios;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace exercicios
//{
//    internal class AccountwEx
//    {
//        public int Number { get; set; }
//        public string Holder { get; set; }
//        public double Balance { get; private set; }
//        public double WithdrawLimit { get; set; }

//        public AccountwEx()
//        {

//        }
//        public AccountwEx(int number, string holder, double balance, double withdrawLimit)
//        {
//            Number = number;
//            Holder = holder;
//            Balance = balance;
//            WithdrawLimit = withdrawLimit;
//        }

//        public void Deposit(double amount)
//        {
//            Balance += amount;
//        }

//        public void Withdraw(double amount)
//        {
//            if (Balance < amount) 
//            {
//                throw new DomainException("Not enough balance");
//            }
//            else if (amount > WithdrawLimit)
//            {
//                throw new DomainException("The amount exceeds withdraaw limit");
//            }
//            Balance -= amount;
//        }
//    }
//}

//MAIN:

//try
//{
//    Console.WriteLine("Enter account data");
//    Console.Write("Number: ");
//    int number = int.Parse(Console.ReadLine());
//    Console.Write("Holder: ");
//    string holder = Console.ReadLine();
//    Console.Write("Initial balance: ");
//    double balance = double.Parse(Console.ReadLine(), ci);
//    Console.Write("Withdraw limit: ");
//    double withdrawLimit = double.Parse(Console.ReadLine(), ci);

//    AccountwEx acc = new AccountwEx(number, holder, balance, withdrawLimit);

//    Console.WriteLine();
//    Console.Write("Enter amount for withdraw: ");
//    double withdraw = double.Parse(Console.ReadLine(), ci);

//    acc.Withdraw(withdraw);

//    Console.WriteLine("New balance: " + acc.Balance.ToString("F2", ci));
//}
//catch (DomainException e)
//{
//    Console.WriteLine("Withdraw error: " + e.Message);
//}