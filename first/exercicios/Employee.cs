//using exercicios;
//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace exercicios
//{
//    internal class Employee
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public double Salary { get; private set; }

//        public Employee() {

//        }

//        public Employee(int id, string name) {
//            Id = id;
//            Name = name;
//        }

//        public Employee(int id, string name, double salary) : this(id, name) {
//            Salary = salary;
//        }

//        public void increaseSalary(double percentage) {
//            Salary += (percentage / 100) * Salary;
//        }

//        public override string ToString() {
//            return Id
//                + ", "
//                + Name
//                + ", "
//                + Salary.ToString("F2", CultureInfo.InvariantCulture);
//        }

//    }
//}

//MAIN:

//Console.Write("How many employees will be registered? ");
//int n = int.Parse(Console.ReadLine());

//List<Employee> list = new List<Employee>();

//for (int i = 0; i < n; i++) {
//    Console.WriteLine("Employee #" + (i + 1));
//    Console.Write("Id: ");
//    int id = int.Parse(Console.ReadLine());
//    Console.Write("Name: ");
//    string name = Console.ReadLine();
//    Console.Write("Salary: ");
//    double salary = double.Parse(Console.ReadLine(), ci);
//    list.Add(new Employee(id, name, salary));
//    Console.WriteLine();
//}

//Console.Write("Enter the employee id that will have salary increase: ");
//int idS = int.Parse(Console.ReadLine());

//Employee emp = list.Find(x => x.Id == idS);
//if (emp != null) {
//    Console.Write("Enter the percentage: ");
//    double percentage = double.Parse(Console.ReadLine(), ci);
//    emp.increaseSalary(percentage);
//}
//else {
//    Console.WriteLine("This id does not exist!");
//}

//Console.WriteLine();
//Console.WriteLine("Updated list of employees: ");
//foreach (Employee obj in list) {
//    Console.WriteLine(obj);
//}