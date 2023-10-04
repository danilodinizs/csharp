//using Interfaces.Entities;
//using Interfaces.Services;
//using System.Globalization;

//CultureInfo ci = CultureInfo.InvariantCulture;

//List<Product> list = new List<Product>();

//Console.Write("Enter the number of products: ");
//int n = int.Parse(Console.ReadLine());

//for (int i = 0; i < n; i++)
//{
//    string[] vect = Console.ReadLine().Split(',');
//    double price = double.Parse(vect[1], ci);
//    list.Add(new Product(vect[0], price));
//}

//CalculationService calculationService = new CalculationService();

//Console.WriteLine("Most expensive: ");
//Console.WriteLine(calculationService.Max(list));


