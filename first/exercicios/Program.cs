using System.Globalization;
using exercicios;
using System.IO;

namespace first
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            string sourcePath = @"c:\temp\file1.txt";
            string targetPath = @"c:\temp\file2.txt";
            string path = @"c:\temp\file1.txt";

            StreamReader sr = null;
            try
            {
                //FileInfo fileInfo = new FileInfo(sourcePath);
                //fileInfo.CopyTo(targetPath);
                //string[] lines = File.ReadAllLines(sourcePath);
                //foreach (string line in lines)
                //{
                //    Console.WriteLine(line);
                //}

                //Console.WriteLine("=======================");

                //sr = File.OpenText(path);
                //while (!sr.EndOfStream)
                //{
                //    string line1 = sr.ReadLine();

                //   Console.WriteLine(line1);
                //}
                Console.WriteLine("========================");

                using (StreamReader sr1 = File.OpenText(path))
                    while (!sr1.EndOfStream)
                    {
                        string line1 = sr.ReadLine();
                        Console.WriteLine(line1);
                    }

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

        }
    }
}