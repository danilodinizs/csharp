//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace exercicios
//{
//    internal class EmployeeHeP
//    {
//        public string Name { get; set; }
//        public int Hours { get; set; }
//        public double ValuePerHour { get; set; }

//        public EmployeeHeP()
//        {

//        }

//        public EmployeeHeP(string name, int hours, double valuePerHour)
//        {
//            Name = name;
//            Hours = hours;
//            ValuePerHour = valuePerHour;
//        }

//        public virtual double Payment()
//        {
//            return ValuePerHour * Hours;
//        }
//    }
//}

//MAIN:
//Console.Write("Enter the number of employees: ");
//int n = int.Parse(Console.ReadLine());

//List<EmployeeHeP> list = new List<EmployeeHeP>();

//for (int i = 1; i <= n; i++)
//{
//    Console.WriteLine($"Employee #{i} data: ");
//    Console.Write("Outsourced (y/n)? ");
//    char yn = char.Parse(Console.ReadLine());

//    Console.Write("Name: ");
//    string name = Console.ReadLine();
//    Console.Write("Hours: ");
//    int h = int.Parse(Console.ReadLine());
//    Console.Write("Value per hour: ");
//    double vph = double.Parse(Console.ReadLine(), ci);

//    if (yn == 'y')
//    {
//        Console.Write("Additional charge: ");
//        double ac = double.Parse(Console.ReadLine(), ci);

//        list.Add(new OutsourcedEmployee(name, h, vph, ac));
//    }
//    else
//    {
//        list.Add(new EmployeeHeP(name, h, vph));
//    }

//}

//Console.WriteLine();
//Console.WriteLine("PAYMENTS: ");
//foreach (EmployeeHeP emp in list)
//{
//    Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", ci));
//}
//}
