using System;
using System.IO;

class Filelo
{
    public static void file()
    {
        string inputFile = "log.txt";
        string outputFile = "error.txt";

        string[] lines = File.ReadAllLines(inputFile);

        using (StreamWriter writer = new StreamWriter(outputFile))
        {
            foreach (string line in lines)
            {
                if (line.Contains("ERROR"))
                {
                    writer.WriteLine(line);
                }
            }
        }

        Console.WriteLine("ERROR logs saved to error.txt");
    }
}
