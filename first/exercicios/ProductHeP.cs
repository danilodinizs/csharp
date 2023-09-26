//using System;
//using System.Globalization;

//namespace exercicios
//{
//    internal class ProductHeP
//    {
//        public string Name { get; set; }
//        public double Price { get; set; }

//        public ProductHeP()
//        {

//        }

//        public ProductHeP(string name, double price)
//        {
//            Name = name;
//            Price = price;
//        }

//        public virtual string PriceTag()
//        {
//            return Name
//                + " $ "
//                + Price.ToString("F2", CultureInfo.InvariantCulture);
//        }
//    }
//}

//Main:
//CultureInfo ci = CultureInfo.InvariantCulture;

//Console.Write("Enter the number of products: ");
//int n = int.Parse(Console.ReadLine());

//List<ProductHeP> list = new List<ProductHeP>();

//for (int i = 1; i <= n; i++)
//{
//    Console.WriteLine($"Product #{i} data:");
//    Console.Write("Common, used or imported (c/u/i)? ");
//    char cui = char.Parse(Console.ReadLine());
//    Console.Write("Name: ");
//    string name = Console.ReadLine();
//    Console.Write("Price: ");
//    double price = double.Parse(Console.ReadLine(), ci);

//    if (cui == 'i')
//    {
//        Console.Write("Customs fee: ");
//        double customsfee = double.Parse(Console.ReadLine(), ci);
//        list.Add(new ImportedProduct(name, price, customsfee));
//    }
//    else if (cui == 'u')
//    {
//        Console.Write("Manufacture date (DD/MM/YYYY): ");
//        DateTime date = DateTime.Parse(Console.ReadLine());
//        list.Add(new UsedProduct(name, price, date));
//    }
//    else
//    {
//        list.Add(new ProductHeP(name, price));
//    }
//}

//Console.WriteLine();
//Console.WriteLine("PRICE TAGS: ");
//foreach (ProductHeP p in list)
//{
//    Console.WriteLine(p.PriceTag());
//}