using System.Globalization;
using test.Entities;

Console.Write("Enter full file path: ");
string path = Console.ReadLine();
Console.Write("Enter salary: ");
double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

List<Employee> emp = new List<Employee>();

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string[] fields = sr.ReadLine().Split(',');
            string name = fields[0];
            string email = fields[1];
            double salaryE = double.Parse(fields[2], CultureInfo.InvariantCulture);
            emp.Add(new Employee(name, email, salaryE));
        }
    }

    Console.WriteLine("Email of people whose salary is more than " + salary.ToString("F2", CultureInfo.InvariantCulture) + ": ");

    var emails =
        emp.Where(e => e.Salary > salary).OrderBy(e => e.Name).Select(e => e.Email);

    foreach (var email in emails)
    {
        Console.WriteLine(email);
    }

    var sum =
        emp.Where(e => e.Name.StartsWith('M')).Sum(e => e.Salary);

    Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));

}
catch (IOException e)
{
    Console.WriteLine("An error ocurred!");
    Console.WriteLine(e.Message);
}