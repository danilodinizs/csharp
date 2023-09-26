//namespace exercicios
//{
//    internal class Account
//    {
//        public int Number { get; private set; }
//        public string Holder { get; private set; }
//        public double Balance { get; protected set; }

//        public Account()
//        {

//        }

//        public Account(int number, string holder, double balance)
//        {
//            Number = number;
//            Holder = holder;
//            Balance = balance;
//        }

//        public virtual void Withdraw(double amount)
//        {
//            Balance -= amount + 5.0;
//        }

//        public void Depoist(double amount)
//        {
//            Balance += amount;
//        }
//    }
//}

//MAIN HERANÇA E POLIMORFISMO:

    //CultureInfo ci = CultureInfo.InvariantCulture;

            //Account acc = new Account(1001, "Danilo", 500.00);
            //Account acc1 = new SavingsAccount(1002, "Daniel", 500.00, 0.01);

            //acc.Withdraw(10.0);
            //acc1.Withdraw(10.0);

            //Console.WriteLine(acc.Balance);
            //Console.WriteLine(acc1.Balance);

            //Account acc = new Account(1001, "Danilo", 0.0);
            //BusinessAccount bAcc = new BusinessAccount(1002, "Daniel", 0.0, 500.0);

            //Account acc1 = bAcc;
            //Account acc2 = new BusinessAccount(1003, "Davi", 0.0, 300.0);
            //Account acc3 = new SavingsAccount(1002, "Daniel", 300.0, 0.01);

            //BusinessAccount bAcc1 = (BusinessAccount)acc2;
            //BusinessAccount bAcc2 = acc2 as BusinessAccount;
            //Console.WriteLine(bAcc1.LoanLimit.ToString("F2", ci));
            //Console.WriteLine(bAcc2.LoanLimit.ToString("F2", ci));
            //bAcc1.Loan(300.0);

            // BusinessAccount bAcc2 = (BusinessAccount)acc3;  erro crasso

            //if (acc3 is BusinessAccount)
            //{
            //    BusinessAccount bAcc3 = (BusinessAccount)acc3;
            //}
            //else if (acc3 is SavingsAccount)
            //{
            //    SavingsAccount sAcc = (SavingsAccount)acc3;
            //    sAcc.UpdateBalance();
            //    Console.WriteLine(sAcc.Balance);
            //    Console.WriteLine("burro burro burro");
            //}

            //Console.Write("Number: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.Write("Holder: ");
            //string holder = Console.ReadLine();
            //Console.Write("Balance: ");
            //double balance = double.Parse(Console.ReadLine(), ci);
            //Console.Write("Loan Limit: ");
            //double loanLimit = double.Parse(Console.ReadLine(), ci);

            //BusinessAccount businessAccount = new BusinessAccount(n, holder, balance, loanLimit);

            //Console.Write("Withdraw: ");
            //double withdraw = double.Parse(Console.ReadLine(), ci);
            //businessAccount.Withdraw(withdraw);
            //Console.Write("Deposit: ");
            //double deposit = double.Parse(Console.ReadLine(), ci);
            //businessAccount.Depoist(deposit);
            //Console.Write("Loan: ");
            //double loan = double.Parse(Console.ReadLine(), ci);
            //businessAccount.Loan(loan);

            //Console.WriteLine();
            //Console.WriteLine("Account balance: " + businessAccount.Balance);
            //Console.WriteLine("Loan limit: " + businessAccount.LoanLimit);