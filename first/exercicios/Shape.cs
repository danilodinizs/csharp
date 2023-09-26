//using exercicios;

//namespace exercicios
//{
//    internal abstract class Shape
//    {
//        public Color Color { get; set; }

//        public Shape(Color color)
//        {
//            Color = color;
//        }

//        public abstract double Area();
//    }
//}

//MAIN:
//Console.Write("Enter the number of shapes: ");
//int n = int.Parse(Console.ReadLine());

//List<Shape> list = new List<Shape>();

//for (int i = 1; i <= n; i++)
//{
//    Console.WriteLine($"Shape #{i} data: ");
//    Console.Write("Rectangle or Circle (r/c)? ");
//    char rc = char.Parse(Console.ReadLine());
//    Console.Write("Color (Black/Blue/Red): ");
//    Color color = Enum.Parse<Color>(Console.ReadLine());

//    if (rc == 'r')
//    {
//        Console.Write("Width: ");
//        double width = double.Parse(Console.ReadLine(), ci);
//        Console.Write("Height: ");
//        double height = double.Parse(Console.ReadLine(), ci);

//        list.Add(new Rectangle(color, width, height));
//    }
//    else
//    {
//        Console.Write("Radius: ");
//        double radius = double.Parse(Console.ReadLine(), ci);
//        list.Add(new Circle(color, radius));
//    }

//}
//Console.WriteLine();
//Console.WriteLine("SHAPE AREAS: ");
//foreach (Shape shape in list)
//{
//    Console.WriteLine(shape.Area().ToString("F2", ci));
//}