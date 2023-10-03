//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace exercicios
//{
//    internal class Testes
//    {
//        public string Name { get; set; }
//        public string Email { get; set; }

//        public override bool Equals(object? obj)
//        {
//            if (!(obj is Testes))
//            {
//                return false;
//            }
//            Testes other = obj as Testes;
//            return Email.Equals(other.Email);
//        }

//        public override int GetHashCode()
//        {
//            return Email.GetHashCode();
//        }
//    }
//}

//MAIN:

//Testes a = new Testes { Name = "Maria", Email = "maria@gmail.com" };
//Testes b = new Testes { Name = "Alex", Email = "alex@gmail.com" };

//Console.WriteLine(a.Equals(b));
//Console.WriteLine(a == b);
//Console.WriteLine(a.GetHashCode());
//Console.WriteLine(b.GetHashCode());
    
