using System;

class Parsee
{
    public static void parsee()
    {
        string[] tokens = { "10", "20", "abc", "999999999999", "-5", "30" };

        int sum = 0;
        foreach (string token in tokens){
            if (int.TryParse(token, out int value))
            {
                sum += value;
            }
        }

        Console.WriteLine(sum);
    }
}
