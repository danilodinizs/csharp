Console.WriteLine("Enter file full path: ");
string path = Console.ReadLine();

try
{

    using (StreamReader sr = File.OpenText(path))
    {

        Dictionary<string, int> dictionary = new Dictionary<string, int>();


        while (!sr.EndOfStream)
        {
            string[] line = sr.ReadLine().Split(',');
            string name = line[0];
            int votos = int.Parse(line[1]);

            if (dictionary.ContainsKey(name))
            {
                dictionary[name] += votos;
            }
            else
            {
                dictionary[name] = votos;
            }
        }




        foreach (KeyValuePair<string, int> kvp in dictionary)
        {
            Console.WriteLine(kvp.Key + ": " + kvp.Value);
        }
    }
}
catch (IOException e)
{
    Console.WriteLine("Any error ocurred!");
    Console.WriteLine(e.Message);
}
