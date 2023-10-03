/*
namespace exercicios
{
    internal class Files
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Files() { 
        }

        public Files(string name, double price) {
            Name = name;
            Price = price;
        }

        public Files(string name, double price, int quantity) : this(name, price)
        {
            Quantity = quantity;
        }

        public double FinalPrice() { 
            return Price * Quantity;
        }
    }
}


  
  MAIN: 
  
   CultureInfo ci = CultureInfo.InvariantCulture;

            Console.Write("Enter file full path: ");
            string sourceFilePath = Console.ReadLine();

            try
            {
                string[] lines = File.ReadAllLines(sourceFilePath);

                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summary.csv";

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (string line in lines)
                    {

                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], ci);
                        int quantity = int.Parse(fields[2]);

                        Files prod = new Files(name, price, quantity);

                        sw.WriteLine(prod.Name + "," + prod.FinalPrice().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred!");
                Console.WriteLine(e.Message);
            }

========================

string sourcePath = @"c:\temp\chess-system\chess-system-csharp\.gitignore";
string targetPath = @"c:\temp\file2.txt";
string path1 = @"c:\temp\file1.txt";
string path2 = @"c:\temp\testfolder";
string path3 = @"c:\temp\file1.txt";

StreamReader sr = null;
try
{
    
    FileInfo fileInfo = new FileInfo(sourcePath);
    fileInfo.CopyTo(targetPath);
    string[] lines = File.ReadAllLines(sourcePath);
    foreach (string line in lines)
    {
        Console.WriteLine(line);
    }

    Console.WriteLine("=======================");

    sr = File.OpenText(path1);
    while (!sr.EndOfStream)
    {
        string line1 = sr.ReadLine();

      Console.WriteLine(line1);
    }
    Console.WriteLine("========================");

    using (StreamReader sr1 = File.OpenText(path1))
        while (!sr1.EndOfStream)
        {
            string line1 = sr1.ReadLine();
            Console.WriteLine(line1);
        }

    Console.WriteLine("========================");

    string[] lines1 = File.ReadAllLines(sourcePath);
    using (StreamWriter sw = File.AppendText(targetPath))
    {
        foreach (string line in lines1)
        {
            sw.WriteLine(line.ToUpper());
        }
    }
    Console.WriteLine("========================");
    

    IEnumerable<string> folders = Directory.EnumerateDirectories(path2, "*.*", SearchOption.AllDirectories);
    Console.WriteLine("FOLDERS: ");
    foreach (string s in folders)
    {
        Console.WriteLine(s);

    }

    Console.WriteLine("========================");

    var files = Directory.EnumerateFiles(path2, "*.*", SearchOption.AllDirectories);
    Console.WriteLine("FILES: ");
    foreach (string s in files)
    {
        Console.WriteLine(s);

    }

    Directory.CreateDirectory(path2 + @"\newfolder");

    Console.WriteLine("========================");

    Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
    Console.WriteLine("PathSeparator: " + Path.PathSeparator);
    Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path3));
    Console.WriteLine("GetFileName: " + Path.GetFileName(path3));
    Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path3));
    Console.WriteLine("GetExtension: " + Path.GetExtension(path3));
    Console.WriteLine("GetFullPath: " + Path.GetFullPath(path3));
    Console.WriteLine("GetTempPath: " + Path.GetTempPath());
}
catch (IOException e)
{
    Console.WriteLine("An error ocurred!");
    Console.WriteLine(e.Message);
}
finally
{
    if (sr != null) sr.Close();
}

*/