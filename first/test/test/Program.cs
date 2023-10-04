using System.Linq;
using test.Entities;

static void Print<T>(string message, IEnumerable<T> collection)
{
    Console.WriteLine(message);
    foreach (T obj in collection)
    {
        Console.WriteLine(obj);
    }
    Console.WriteLine();
}

Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 3 };
Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

List<Product> products = new List<Product>() {
    new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
    new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
    new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
    new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
    new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
    new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
    new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
    new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
    new Product() { Id = 9, Name = "Macbook", Price = 1800.0, Category = c2 },
    new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
    new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
};

var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.00);
Print("TIER 1 AND PRICE < 900.00: ", r1);

var r2 = products.Where(p => p.Category.Tier == 3).Select(p => p.Name);
Print("TIER TOOLS: ", r2);

var r3 = products.Where(p => p.Name.StartsWith('C')).Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name});
Print("'C' PRODUCTS: ", r3);

var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
Print("TIER 1: ", r4);

var r5 = r4.Skip(2).Take(4);
Print("MISTERY: ", r5);

var r6 = products.Where(p => p.Id == 3).SingleOrDefault();
Console.WriteLine("ONE: " + r6);
Console.WriteLine();

var r7 = products.Max(p => p.Price);
Console.WriteLine("MAX PRICE: " + r7);

var r8 = products.Min(p => p.Price);
Console.WriteLine("MIN PRICE: " + r8);

var r9 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
Console.WriteLine("SUM TIER 3: " + r9);

var r10 = products.Where(p => p.Category.Id == 2).Sum(p => p.Price);
Console.WriteLine("SUM TIER 1: " + r10);

var r11 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
Console.WriteLine("AVERAGE TIER 3: " + r11);

var r12 = products.Where(p => p.Category.Id == 4).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
Console.WriteLine("AVERAGE TIER 4: " + r12);

var r13 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate((x, y) => x + y);
Console.WriteLine("AGGREGATE SUM TIER 3: " + r13);

var r14 = products.Where(p => p.Category.Id == 4).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
Console.WriteLine("AGGREGATE SUM TIER 4: " + r14);

Console.WriteLine();
var r15 = products.GroupBy(p => p.Category);
foreach (IGrouping<Category, Product> group in r15)
{
    Console.WriteLine("Category " + group.Key.Name + ":");
    foreach (Product p in group)
    {
        Console.WriteLine(p);
    }
    Console.WriteLine();
} 

