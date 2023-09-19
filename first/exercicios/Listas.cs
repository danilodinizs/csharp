//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Globalization;

//namespace exercicios
//{
//    internal class Listas
//    {
//        List<string> list = new List<string>();

//        list.Add("fodase");
//        list.Add("mano");
//        list.Add("toti");
//        list.Insert(0, "mlk");
//        list.Add("zica");

//        Console.WriteLine();

//        foreach (string obj in list) {
//           Console.WriteLine(obj);
//           Console.WriteLine("================================================");
//        }
//        Console.WriteLine();
//        Console.WriteLine("quantas palavras: " + list.Count);
//        Console.WriteLine();

//        string s1 = list.Find(x => x[0] == 'm');
//        Console.WriteLine("primeiro m: " + s1);
//        string s2 = list.FindLast(x => x[0] == 'm');
//        Console.WriteLine("ultimo m: " + s2);

//        Console.WriteLine();
//        int pos1 = list.FindIndex(x => x[0] == 'm');
//        Console.WriteLine("posição começa m: " + pos1);
//        int pos2 = list.FindLastIndex(x => x[0] == 'm');
//        Console.WriteLine("posição começa m: " + pos2);

//        Console.WriteLine();

//        List<string> list2 = list.FindAll(x => x.Length == 4);
//        foreach (string obj in list2) {
//           Console.WriteLine("quatro letras: " + obj);
//        }

//        Console.WriteLine();

//        list.Remove("mlk");
//        foreach (string obj in list) {
//            Console.WriteLine(obj);
//        }

//        Console.WriteLine();
//        Console.WriteLine("====================");
//        Console.WriteLine();

//        list.RemoveAll(x => x[0] == 'f');
//        foreach (string obj in list) {
//            Console.WriteLine(obj);
//        }

//        Console.WriteLine();
//        Console.WriteLine("====================");
//        Console.WriteLine();

//        list.RemoveAt(2);
//        foreach (string obj in list) {
//            Console.WriteLine(obj);
//        }

//        Console.WriteLine();
//        Console.WriteLine("====================");
//        Console.WriteLine();

//        list.RemoveRange(0, 2);
//        foreach (string obj in list) {
//            Console.WriteLine(obj);
//        }
//    }
//}




