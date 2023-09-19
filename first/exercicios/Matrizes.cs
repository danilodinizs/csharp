////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

////namespace exercicios
////{
////    internal class Matrizes
////    {
////        Console.Write("Digite o tamanho da sua matriz quadrada: ");
////            int n = int.Parse(Console.ReadLine());

////            int[,] matriz = new int[n, n];

////            int soma = 0;
////            for (int i = 0; i < n; i++) {

////                Console.WriteLine("Digite os " + n + " números da " + (i + 1) + "° linha");
////                string[] values = Console.ReadLine().Split(' ');

////                for (int j = 0; j < n; j++) {
////                    matriz[i, j] = int.Parse(values[j]);
////                    if (double.Parse(values[j]) < 0) {
////                        soma += 1;
////                    }
////                }

////            }

////            Console.WriteLine("Main diagonal: ");

////            for (int i = 0; i < n; i++) {
////                Console.Write(matriz[i, i] + " ");
////            }
////            Console.WriteLine();

////            Console.WriteLine("Negative numbers = " + soma);

////            Console.WriteLine();
////            Console.Write("Matriz completa: ");

////            for (int i = 0; i < n; i++) {
////                Console.WriteLine();
////                for (int j = 0; j < n; j++) {
////                    Console.Write(matriz[i, j] + " ");
////                }
////            }
////    }
////}

//exercício:

//Console.Write("Digite a quantidade de linhas e colunas da sua matriz, respectivamente: ");
//string[] linhasEcolunas = Console.ReadLine().Split(' ');
//int m = int.Parse(linhasEcolunas[0]);
//int n = int.Parse(linhasEcolunas[1]);

//int[,] matriz = new int[m, n];

//for (int i = 0; i < m; i++) {
//    Console.WriteLine("Digite os " + n + " números da " + (i + 1) + "° linha");
//    string[] values = Console.ReadLine().Split(' ');
//    for (int j = 0; j < n; j++) {
//        matriz[i, j] = int.Parse(values[j]);
//    }
//}
//Console.WriteLine();
//Console.WriteLine("Sua matriz completa: ");
//for (int i = 0; i < m; i++) {
//    Console.WriteLine();
//    for (int j = 0; j < n; j++) {
//        Console.Write(matriz[i, j] + " ");
//    }
//}
//Console.WriteLine();
//Console.WriteLine();
//Console.Write("Digite o número que deseja verificar: ");
//int x = int.Parse(Console.ReadLine());

//for (int i = 0; i < m; i++) {
//    for (int j = 0; j < n; j++) {
//        if (x == matriz[i, j]) {
//            Console.WriteLine("Posição " + i + "," + j + ": ");
//            if (i > 0) {
//                Console.WriteLine("Up: " + matriz[i - 1, j]);
//            }
//            if (j > 0) {
//                Console.WriteLine("Left: " + matriz[i, j - 1]);
//            }
//            if (i < m - 1) {
//                Console.WriteLine("Down: " + matriz[i + 1, j]);
//            }
//            if (j < n - 1) {
//                Console.WriteLine("Right: " + matriz[i, j + 1]);
//            }
//            Console.WriteLine();
//        }

//    }
//}
