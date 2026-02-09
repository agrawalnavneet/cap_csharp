using System;

class Objec
{
    public static void objec()
    {
        object[] values = { 10, "hello", true, 5, null, 20, 3.5 };

        int sum = 0;

        foreach (object v in values)
        {
            if (v is int x)
            {
                sum += x;
            }
        }

        Console.WriteLine(sum);
    }
}
