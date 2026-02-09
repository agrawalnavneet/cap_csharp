using System;
using System.Collections.Generic;
using System.Text.Json;

record Studen(string Name, int Score);

class Format
{
    static string BuildJson(string[] items, int minScore)
    {
        List<Studen> students = new List<Studen>();

        foreach (string item in items)
        {
            if (string.IsNullOrWhiteSpace(item))
                continue;

            string[] parts = item.Split(':');
            if (parts.Length != 2)
                continue;

            if (!int.TryParse(parts[1], out int score))
                continue;

            students.Add(new Studen(parts[0], score));
        }

        students.RemoveAll(s => s.Score < minScore);

        students.Sort((a, b) =>
        {
            int scoreCompare = b.Score.CompareTo(a.Score);
            if (scoreCompare != 0)
                return scoreCompare;
            return string.Compare(a.Name, b.Name, StringComparison.Ordinal);
        });

        return JsonSerializer.Serialize(students);
    }

   public  static void format()
    {
        string[] items = {
            "Ali:90",
            "gopi:75",
            "Charlie:90",
            "krishna:60"
        };

        string json = BuildJson(items, 80);
        Console.WriteLine(json);
    }
}
