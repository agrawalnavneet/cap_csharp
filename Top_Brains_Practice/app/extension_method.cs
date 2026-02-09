using System;
using System.Collections.Generic;

static class StringExtensions
{
    public static string[] DistinctById(this string[] items)
    {
        HashSet<string> seenIds = new HashSet<string>();
        List<string> result = new List<string>();

        foreach (string item in items)
        {
            if (string.IsNullOrEmpty(item))
                continue;

            string[] parts = item.Split(':');
            if (parts.Length != 2)
                continue;

            string id = parts[0];
            string name = parts[1];

            if (!seenIds.Contains(id))
            {
                seenIds.Add(id);
                result.Add(name);
            }
        }

        return result.ToArray();
    }
}

class Extension
{
   public static void extension()
    {
        string[] items = {
            "1:ashi",
            "2:shreya",
            "1:mansi",
            "3:laxmi",
            "2:jyoti"
        };

        string[] output = items.DistinctById();

        foreach (string name in output)
            Console.WriteLine(name);
    }
}
