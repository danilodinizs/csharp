//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace exercicios
//{
//    internal class PessoaJurídica : Contribuinte
//    {
//        public int NumberOfEmployee { get; set; }

//        public PessoaJurídica(string name, double anualIncome, int numberOfEmployee) 
//            : base (name, anualIncome)
//        {
//            NumberOfEmployee = numberOfEmployee;
//        }

//        public override double TaxesPaid()
//        {
//            if (NumberOfEmployee < 10)
//            {
//                return AnualIncome * 0.16;
//            }
//            else
//            {
//                return AnualIncome * 0.14;
//            }
//        }
//    }
//}
